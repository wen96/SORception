module.controller( "OrdersCtrl", [ '$scope', 'Scrap','Auth', function( $scope, Scrap, Auth ) {
	$scope.$on( 'orders.update', function( event ) {
		$scope.orders = Scrap.orders;
	});


	Auth.isLoggedIn();
	console.log();
	Scrap.getOrders();
  	$scope.orders;

}]);
