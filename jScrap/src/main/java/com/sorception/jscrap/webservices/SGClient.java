/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package com.sorception.jscrap.webservices;

import com.sorception.jscrap.error.ServiceUnavailableException;
import com.sorception.jscrap.entities.SettingsEntity;
import com.sorception.jscrap.entities.TokenEntity;
import com.sorception.jscrap.entities.TokenEntity.TokenStatus;
import com.sorception.jscrap.error.ResourceNotFoundException;
import com.sorception.jscrap.generated.ExpDesguace;
import com.sorception.jscrap.generated.GetState;
import com.sorception.jscrap.generated.GetStateResponse;
import com.sorception.jscrap.generated.ObjectFactory;
import com.sorception.jscrap.generated.SignUp;
import com.sorception.jscrap.generated.SignUpResponse;
import com.sorception.jscrap.generated.TokenResponse;
import com.sorception.jscrap.generated.TokenResponseCode;
import com.sorception.jscrap.services.SettingsService;

import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.net.URI;
import java.util.logging.Level;
import java.util.logging.Logger;

import javax.xml.transform.TransformerException;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.ws.WebServiceMessage;
import org.springframework.ws.client.core.WebServiceMessageCallback;
import org.springframework.ws.client.core.WebServiceTemplate;
import org.springframework.ws.client.core.support.WebServiceGatewaySupport;
import org.springframework.ws.soap.SoapMessage;

/**
 *
 * @author kaseyo
 */
@Service
public class SGClient extends WebServiceGatewaySupport {
    
    @Autowired
    SettingsService settingsService;
    
    @Autowired
    ObjectFactory objectFactory;
    
    @Autowired
    WebServiceTemplate webServiceTemplate;
    
    private ExpDesguace desguace() {
        SettingsEntity settings = settingsService.getGlobalSettings();
        ExpDesguace desguace = objectFactory.createExpDesguace();
        desguace.setName(objectFactory.createExpDesguaceName(settings.getName()));
        return desguace;
    }
    
    public Object marshalWithSoapActionHeader(Object d, final String action) {
        return webServiceTemplate.marshalSendAndReceive(d, new WebServiceMessageCallback() {
            @Override
            public void doWithMessage(WebServiceMessage message) {
                String url = "";
                try {
                    URI uri = new URI(webServiceTemplate.getDefaultUri());
                    url = uri.getScheme() + "://" + uri.getHost() + "/";
                } catch (Exception ex) {
                    url = "http://tempuri.org/";
                } finally {
                    url += action;
                }
                logger.info("Accediendo a WS con Action: " + url + "...");
                ((SoapMessage)message).setSoapAction(url);
            }
        });
    }
    
    public TokenEntity signUp() {
        SignUp signUpRequest = objectFactory.createSignUp();
        signUpRequest.setD(objectFactory.createSignUpD(desguace()));
        try {
        	SignUpResponse response = (SignUpResponse)
                this.marshalWithSoapActionHeader(signUpRequest, "IGestionDesguace/signUp");
        	return this.createTokenEntity(response.getSignUpResult().getValue());
        } catch(Exception ex) {
        	throw new ServiceUnavailableException("Web Service not available");
        }
    }
    
    public TokenEntity getState(String temporalToken) {
        GetState getStateRequest = objectFactory.createGetState();
        getStateRequest.setId(objectFactory.createGetStateId(temporalToken));
        try {
        	GetStateResponse response = (GetStateResponse) 
                this.marshalWithSoapActionHeader(getStateRequest, "IGestionDesguace/getState");
        	TokenResponse tokenResponse = response.getGetStateResult().getValue();
        	return this.createTokenEntity(tokenResponse);
        } catch(Exception ex) {
        	throw new ServiceUnavailableException("Web Service not available");
        }
    }
    
    private TokenEntity createTokenEntity(TokenResponse tokenResponse) {
    	String token = tokenResponse.getToken().getValue();
    	TokenEntity.TokenStatus tokenStatus;
    	switch(tokenResponse.getStatus()) {
    		case CREATED:
    			tokenStatus = TokenEntity.TokenStatus.VALID;
    			break;
    		case NON_AUTHORITATIVE:
    			tokenStatus = TokenEntity.TokenStatus.TEMPORAL;
    			break;
    		case ACCEPTED:
    			tokenStatus = TokenEntity.TokenStatus.REQUESTED;
    			break;
    		default:
    			throw new ServiceUnavailableException("Error at Web Service");
    	}
    	TokenEntity tokenEntity = new TokenEntity(token, tokenStatus);
    	return tokenEntity;
    }
}
