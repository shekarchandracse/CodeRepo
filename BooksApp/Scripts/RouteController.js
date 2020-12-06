(function () {
    var app = angular.module("myApp", ["ngRoute"]);
    app.controller("myCtrl", function ($scope, $http) {
        $http({
            method: 'GET',
            url: '/api/Books'
        }).then(function (response) {
            $scope.Books = response.data;
        })
        $.get("https://api.ipdata.co?api-key=test", function (response) {
            $scope.Country = response.country_name;
        }, "jsonp");
    });
    var config = function ($routeProvider) {
        $routeProvider
            .when("/list",
                { templateUrl: "/MusicApp/Views/Index.html", controller: "myCtrl" })
            .otherwise(
                { redirectTo: "/MusicApp/Views/noAccess.html", controller: "myCtrl" });
    };

    app.config(config);
}()); 