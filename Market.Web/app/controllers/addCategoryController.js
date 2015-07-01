(function() {
    "use strict";

    angular.module("Market.Web").controller("addCategoryController",  addCategoryController);

    function addCategoryController(categoryResource) {
        var vm = this;
        
        vm.title = "New Category";
        vm.category = {};

        categoryResource.get({ id: 0 },
            function (data) {
                vm.category = data;
                vm.originalCategory = angular.copy(data);
            });


        vm.title = "New Category"; 
        

        vm.submit = function () {
            vm.message = '';
            vm.category.$save(
                function(data) {
                    vm.originalCategory = angular.copy(data);
                    vm.message = "...  Created new Category";
                });
        }
    }



}());