var app = angular.module('store-products', []);

app.directive('productPrice', function () {
    return {
        restrict: 'A',
        templateUrl: 'product-price.html'
    };
});
