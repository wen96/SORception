module.service( 'SettingsService', [ '$rootScope', '$http', function( $rootScope, $http ) {
   var service = {
     settings: {
     	"name": "",
     	"tokens": {}
 		},
 
     getSettings: function () {
        $http({method: 'GET', url: '/api/gestion'}).
		  success(function(data, status, headers, config) {
		      service.settings.name = data.name;
       		  service.settings.tokens=data.token;
       		$rootScope.$broadcast( 'settings.update' );
		  }).
		  error(function(data, status, headers, config) {
		  	alert(status+" Valores por defecto");
		  	service.settings.name="TallerGET";
		  	service.settings.tokens = [
			   {
			        "token": "TOKEN_1",
			        "state": "REQUESTED", // 'REQUESTED', 'VALID' o 'EXPIRED'
			        "TimeStamp": "FECHA_21"
			   },
			   {
			        "token": "TOKEN_2",
			        "state": "EXPIRED", // 'REQUESTED', 'VALID' o 'EXPIRED'
			        "TimeStamp": "FECHA_21"
			   },
			   {
			        "token": "TOKEN_3",
			        "state": "VALID", // 'REQUESTED', 'VALID' o 'EXPIRED'
			        "TimeStamp": "FECHA_6"
			   }
		  	];
		  	alert("Cargado");
       		$rootScope.$broadcast( 'settings.update' );
		  });



      	

     },

     postSettings: function(){
         $http({ method: 'POST', url: '/api/gestion', data: '{"Nombre": "Taller.Net"}' }).
          success(function(data, status, headers, config) {
            SettingsService.settings.name="DesguacePOST";
            SettingsService.settings.tokens=data;
       		$rootScope.$broadcast( 'settings.update' );
          }).
          error(function(data, status, headers, config) {
            alert(status);
          });
     }

   }
 

   return service;
}]);

