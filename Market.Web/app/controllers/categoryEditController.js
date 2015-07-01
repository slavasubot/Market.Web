(function() {
    "use strict";

    angular
        .module("Market.Web")
        .controller("categoryEditController",  categoryEditController);

    function categoryEditController(categoryResource, $stateParams) {
        var vm = this;

        vm.category = {};
        
        categoryResource.get({id: $stateParams.id},
            function(data) {
                vm.category = data;
                vm.originalCategory = angular.copy(data);
            });
        

        if (vm.category && vm.category.id) {
            vm.title = "Edit:" + vm.category.name;
        }

        vm.submit = function () {
            vm.message = '';
            vm.category.$update({id: vm.category.id},
                function(data) {
                    vm.message = "... Category Updated";
                });               
        };


        vm.cancel = function(editForm) {
            editForm.$setPristine();
            vm.category = angular.copy(vm.originalCategory);
            vm.message = "";
        }
    }
}());