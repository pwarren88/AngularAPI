var app = angular.module('store-example', []);


app.directive('myExample', function () {
    return {
        template: '<div> My Example Directive here!</div>'
    };
})