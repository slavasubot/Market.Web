(function() {
    "use strict";

    angular
        .module("Market.Web")
        .controller("categoryEditController", categoryEditController);

    function categoryEditController(categoryResource) {
        var vm = this;
        vm.category = {};
        vm.message = "";

        categoryResource.get({ id: 1 },
            function(data) {
                vm.category = data;
                vm.originalCategory = angular.copy(data);
            });
        if (vm.category && vm.category.id) {
            vm.title = "Edit" + vm.category.name;
        }
        else {
            vm.title = "New Category";
        }

        vm.submit = function () {
            vm.message = "";
            if (vm.category.id) {
                vm.category.$update({ id: vm.category.id },
                    function(data) {
                        vm.message = "... Category Updated";
                    });
            }
            else {
                vm.category.$save(
                    function(data) {
                        vm.originalCategory = angular.copy(data);
                        vm.message = "...  Created New Category";
                    });
            }
        };

        vm.cancel = function(editForm) {
            editForm.$setPristine();
            vm.category = angular.copy(vm.originalCategory);
            vm.message = "";
        };

    }
}());