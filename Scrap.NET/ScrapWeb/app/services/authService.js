module.service('Auth', ['$rootScope', '$http', '$location', '$cookies', function ($rootScope, $http, $location, $cookies) {
   var service = {
	 
	    login: function (user) {	
	        $http({ method: 'POST', url: '/api/user/authenticate', data: "grant_type=password&username=" + user.username + "&password=" + user.password }).
			  success(function(data, status, headers, config) {
			      $cookies["SessionScrap"] = JSON.stringify(data);
			      console.log(data);
			      $http.defaults.headers.common.Authorization = 'Bearer ' + data.access_token;
			    $rootScope.$broadcast('auth.login');
	       		$location.path("/orders");
			  }).
			  error(function (data, status, headers, config) {
			      $('#err-login').html("El usuario o la contraseņo son incorrectos");
			  	console.log(status+" | "+data);
	       		$location.path("/login");
			  });    	
	    },

	    logout: function(){
	     	  $http({method: 'POST', url: '/api/logout'}).
	          success(function(data, status, headers, config) {
	              delete $cookies["SessionScrap"];
	             $http.defaults.headers.common.Authorization = ""; 
	              $rootScope.$broadcast('auth.login');
	       		$location.path("/login");
	          }).
	          error(function(data, status, headers, config) {
	            alert(status+" | "+data);
	          });
	    },

	    isLoggedIn: function () {
	    	$rootScope.$broadcast('auth.login');
	        SessionScrap = $cookies["SessionScrap"];
	        if (SessionScrap) {
	              SessionScrap = JSON.parse(SessionScrap);
	              $http.defaults.headers.common.Authorization = 'Bearer ' + SessionScrap.access_token;
                return true;
            }
	       	$location.path("/login");
        },
   	}
 
   return service;
}]);

