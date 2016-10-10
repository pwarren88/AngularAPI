var myApp = angular.module('myApp', ['store-products','store-example']);

myApp.controller('myController', ['$http', '$scope', '$log','ProductsService', 'Gravatar', function ($http, $scope, $log, ProductsService, Gravatar) {
    $scope.model = [];

    ProductsService.get().then(
                function (response) {
                    $scope.model = response.data;
                },
                function (response) {
                    $scope.error = true;
                    $log.log(response.status)
                }
                );

    $scope.gravatarUrl = function (email) {
        return Gravatar(email);
    };
}]);


myApp.controller("reviewController", function ($http) {
    this.review = {};

    this.addReview = function (product) {

        $http.post("api/reviews", product);

    if (!product.reviews)
        product.reviews = [];

        product.reviews.push(this.review);

        this.review = {};
    }
});




var gems = [
  
];

myApp.directive('productPanels', function () {
    return {
        restrict: 'E',
        templateUrl: 'product-panels.html',
        controller: function () {
            this.tab = 1;

            this.selectTab = function (setTab) {
                this.tab = setTab;
            }

            this.isSelected = function (checkTab) {
                return this.tab === checkTab;
            }
        },
        controllerAs: 'panel'

    }
});