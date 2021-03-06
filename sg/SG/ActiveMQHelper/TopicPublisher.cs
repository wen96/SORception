﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Data;

using Apache.NMS;
using Apache.NMS.ActiveMQ;
using System.IO;

namespace ActiveMQHelper
{
    public class TopicPublisher : IDisposable
    {
        private bool _disposed;
        private readonly ISession _session;
        private readonly IConnection _connection;
        private readonly ITopic _topic;
        private static Dictionary<string, Dictionary<string, Dictionary<string, TopicPublisher>>> _publishers = new Dictionary<string, Dictionary<string, Dictionary<string, TopicPublisher>>> ();

        public IMessageProducer Producer { get; private set; }
        public string DestinationName { get; private set; }

        private static string GenerateNumber()
        {
            Random random = new Random();
            string r = "";
            int i;
            for (i = 1; i < 11; i++)
            {
                r += random.Next(0, 9).ToString();
            }
            return r;
        }

        public static TopicPublisher MakePublisher(string broker, string client_id, string topic)
        {
            IConnectionFactory connectionFactory = new ConnectionFactory(broker, client_id + "(" + GenerateNumber() + ")@" + System.Environment.MachineName);
            IConnection connection = connectionFactory.CreateConnection();
            connection.Start();
            ISession session = connection.CreateSession();
            TopicPublisher publisher = new TopicPublisher(session, connection, topic);

            return publisher;
        }

        public TopicPublisher(ISession session, IConnection connection, string topicName)
        {
            _session = session;
            _connection = connection;
            DestinationName = topicName;
            _topic = new Apache.NMS.ActiveMQ.Commands.ActiveMQTopic(DestinationName);
            Producer = session.CreateProducer(_topic);
        }

        public void SendMessage(object o, long delay = 0)
        {
            string message = ToXML(o);
            if (_disposed) throw new ObjectDisposedException(GetType().Name);
            var textMessage = Producer.CreateTextMessage(message);
            textMessage.Properties["AMQ_SCHEDULED_DELAY"] = delay;
            Producer.Send(textMessage);
        }

        public void Dispose()
        {
            if (_disposed) return;
            Producer.Close();
            Producer.Dispose();
            _session.Close();
            _connection.Close();
            _disposed = true;
        }

        public static string ToXML(object d)
        {
            using (MemoryStream memStr = new MemoryStream())
            {
                var serializer = new DataContractSerializer(d.GetType());
                serializer.WriteObject(memStr, d);
                
                memStr.Seek(0, SeekOrigin.Begin);

                using (var streamReader = new StreamReader(memStr))
                {
                    string result = streamReader.ReadToEnd();
                    return result;
                }
            }
        }
    }
}