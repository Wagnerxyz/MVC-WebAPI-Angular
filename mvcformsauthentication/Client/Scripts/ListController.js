var app = angular.module("atTheMovies");
app.controller("ListController", function ($scope, $http, movieService) {
    $scope.message = "hahahah";
    $http.get("/api/movie/").then(function onSuccess(response) {
        // Handle success
        $scope.movies = response.data;
        $scope.movieCount = response.data.length;
        var status = response.status;
        var statusText = response.statusText;
        var headers = response.headers;
        var config = response.config;

    }).catch(function onError(response) {
        // Handle error
        $scope.error = response.data;
        var status = response.status;
        var statusText = response.statusText;
        var headers = response.headers;
        var config = response.config;

    });

    //var removeMovieByid = function (id) {
    //    for (var i = 0; i < $scope.movies.length; i++) {
    //        if ($scope.movies[i].id == id) {
    //            $scope.movies.splice(i, 1);
    //        }
    //    }
    //};
    //$scope.delete = function (movie) {
    //    movieService.delete(movie)
    //        .then(function () {
    //            removeMovieByid(movie.id);
    //        });
    //};

    $scope.delete = function (movie) {
        $http.delete("/api/movie/" + movie.id)
       .then(function onSuccess(response) {
           // Handle success
           $scope.movies.remove(movie);

       }).catch(function onError(response) {
           // Handle error
           $scope.error = response.data;
           var status = response.status;
           var statusText = response.statusText;
           var headers = response.headers;
           var config = response.config;

       });

    }
});