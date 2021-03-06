var module = angular.module("taller.module", ['ngCookies']);

module.config(['$routeProvider',
  function($routeProvider) {
      $routeProvider.
        when('/main', {
            templateUrl: 'app/templates/main.html',
            controller: 'TallerCtrl'
        }).
        when('/create-order', {
            templateUrl: 'app/templates/crearte-order.html',
            controller: 'createOrderCtrl'
        }).
        when('/edit-order', {
            templateUrl: 'app/templates/edit-order.html',
            controller: 'editOrderCtrl'
        }).
        when('/orders', {
            templateUrl: 'app/templates/orders.html',
            controller: 'TallerCtrl'
        }).
        when('/order/:id', {
            templateUrl: 'app/templates/order.html',
            controller: 'OrderCtrl'
        }).
        when('/orders-accepted', {
            templateUrl: 'app/templates/pedidos.html',
            controller: 'PedidosCtrl'
        }).
        when('/order-accepted/:id', {
            templateUrl: 'app/templates/pedido.html',
            controller: 'PedidoCtrl'
        }).
        when('/config', {
            templateUrl: 'app/templates/config.html',
            controller: 'SettingsCtrl'
        }).
        when('/login', {
            templateUrl: 'app/templates/login.html'
        }).
        otherwise({
            redirectTo: '/login'
        });
  }]);