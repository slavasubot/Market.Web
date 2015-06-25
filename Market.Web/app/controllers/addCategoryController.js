(function () {
    "use strict";

    angular
        .module("Market.Web")
        .controller("addCategoryController", addCategoryController);

    function addCategoryController(categoryResource) {
        var vm = this;
        vm.category = {};
        vm.message = "";

        categoryResource.get({id: 0},
            function (data) {
                vm.category = data;
                //vm.originalCategory = angular.copy(data);
            });
        
            vm.title = "New Category";
        

        vm.submit = function () {
            vm.message = "";
            
                vm.category.$save(
                    function (data) {                      
                        vm.message = "...  Created New Category";
                    });  
        };     
    }
}());





//studentsManagement.controller("stCreateController", [
//    "$scope", "stDataService", "$rootScope", "$location", function ($scope, stDataService, $rootScope, $location) {
//        $rootScope.title = "Create student";
//        $scope.saveStudent = function (student) {
//            stDataService.create(student).$promise.then(function () {
//                $location.url("/");
//                $("#stsNav").toggleClass("active");
//                $("#stCreate").removeClass("active");
//                alertify.log(student.Name + " added successfully.");
//            });
//        };
//    }
//]);