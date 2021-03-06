module.directive("addLineBtn", ['Taller', function (Taller) {
    return {
        restrict: "A",
        scope: {
            line: '=addLineBtn'
        },
        link: function (scope, element, attrs) {
            element.bind("click", function () {
                if (scope.line.descripcion != "" && scope.line.cantidad && scope.line.criterio) {
                    $("#err-line").html('');
                    Taller.addLine(scope.line);
                    console.log(Taller);
                    scope.$apply();
                } else {
                    $("#err-line").html('Todos los campos de la linea son obligatorios');
                }
            });
        }
    }
}]).directive("sendOrderBtn", ['Taller', '$location', function (Taller, $location) {
    return {
        restrict: "A",
        scope: {
            order: '=sendOrderBtn'
        },
        link: function (scope, element, attrs) {
            element.bind("click", function () {
                
                    if (scope.order.id) {
                        Taller.putOrder(scope.order);
                        scope.order = [];
                        $location.path("/orders");
                        scope.$apply();
                    } else {
                        if (scope.order.deadline) {
                            $("#err-date").html('');
                            Taller.postOrder(scope.order);
                            scope.order = [];
                            $location.path("/orders");
                            scope.$apply();
                        } else {
                            $("#err-date").html('La fecha de fin es obligatoria');
                        }
                    }

            });
        }
    }
}]).directive("viewOrderBtn", ['Taller', '$location', function (Taller, $location) {
    return {
        restrict: "A",
        scope: {
            order: '=viewOrderBtn'
        },
        link: function (scope, element, attrs) {
            element.bind("click", function () {
                $location.path("/order/" + scope.order.id);
                scope.$apply();
            });
        }
    }
}]).directive("removeLineBtn", ['Taller', function (Taller) {
    return {
        restrict: "A",
        scope: {
            line: '=removeLineBtn'
        },
        link: function (scope, element, attrs) {
            element.bind("click", function () {
                Taller.removeLine(scope.line);
                scope.$apply();
            });
        }
    }
}]).directive("editOrderBtn", ['Taller', '$location', function (Taller, $location) {
    return {
        restrict: "A",
        scope: {
            order: '=editOrderBtn'
        },
        link: function (scope, element, attrs) {
            element.bind("click", function () {
                Taller.actual_order = scope.order;
                $location.path("/edit-order");
                scope.$apply();
            });
        }
    }
}]).directive("removeOrderBtn", ['Taller', '$location', function (Taller, $location) {
    return {
        restrict: "A",
        scope: {
            order: '=removeOrderBtn'
        },
        link: function (scope, element, attrs) {
            element.bind("click", function () {
                Taller.removeOrder(scope.order.id);
                Taller.getOrders();
            });
        }
    }
}]).directive('contenteditable', function () {
    return {
        restrict: 'A', // only activate on element attribute
        require: '?ngModel', // get a hold of NgModelController
        link: function (scope, element, attrs, ngModel) {
            if (!ngModel) return; // do nothing if no ng-model

            // Specify how UI should be updated
            ngModel.$render = function () {
                element.html(ngModel.$viewValue || '');
            };

            // Listen for change events to enable binding
            element.on('blur keyup change', function () {
                scope.$apply(readViewText);
            });

            // No need to initialize, AngularJS will initialize the text based on ng-model attribute

            // Write data to the model
            function readViewText() {
                var html = element.html();

                // When we clear the content editable the browser leaves a <br> behind
                // If strip-br attribute is provided then we strip this out
                if (attrs.stripBr && html == '<br>') {
                    html = '';
                }
                ngModel.$setViewValue(html); //ngModel == linea.cantidad OR linea.descripcion
                //scope.lnUpdate = 'UPDATED';
                console.log(ngModel);
            }
        }
    };
}).directive('lnPedido',  ['Taller', function (Taller) {
    return {
        restrict: 'A', // only activate on element attribute
        scope: {
            line: '=lnPedido'
        },
        link: function (scope, element, attrs, ngModel) {

            element.on('blur keyup change', function () {
                scope.$apply(readViewText);
            });

            function readViewText() {
                var linea_pedido = { "id_linea_oferta": 0, "cantidad": 0, "id_linea_solcitud":0 };

                linea_pedido.id_linea_oferta = scope.line.id;
                linea_pedido.cantidad = parseInt(element.val());
                linea_pedido.id_linea_solcitud = scope.line.linea_solicitud_id;
                if (linea_pedido.cantidad > 0) {
                    Taller.addLineaPedido(linea_pedido);
                }else
                {
                    Taller.removeLineaPedido(linea_pedido.id_linea_oferta);
                }
            }
        }
    };
}]).directive("sendPedidoBtn", ['Taller', '$location', function (Taller, $location) {
    return {
        restrict: "A",
        link: function (scope, element, attrs) {
            element.bind("click", function () {
                Taller.postPedido();
                $location.path("/orders");
                scope.$apply();
            });
        }
    }
}]).directive("viewPedidoBtn", ['Taller', '$location', function (Taller, $location) {
    return {
        restrict: "A",
        scope: {
            pedido: '=viewPedidoBtn'
        },
        link: function (scope, element, attrs) {
            element.bind("click", function () {
                $location.path("/order-accepted/" + scope.pedido.id);
                scope.$apply();
            });
        }
    }
}]);