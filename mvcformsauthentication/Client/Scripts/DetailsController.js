var app = angular.module("atTheMovies");
app.controller("DetailsController", function ($scope, $routeParams, $http) {
    $http.get("/api/movie/" + $routeParams.id).then(function (response) {
        $scope.movie = response.data;
    })
})