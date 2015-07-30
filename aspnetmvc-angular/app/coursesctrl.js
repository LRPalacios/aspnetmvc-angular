(function () {
    "use strict";

    angular
        .module("app")
        .controller("coursesCtrl",
                    ["$scope","bootstrapedData", coursesCtrl]);

    function coursesCtrl($scope, bootstrapedData) {
        $scope.courses = bootstrapedData.courses;
    }

}());