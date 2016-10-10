angular.module('myApp')
    .factory("ProductsService", function ProductsServiceFactory($http) {
    return {
        get: function () {
            return $http.get('/api/products');
        }
    };
    })