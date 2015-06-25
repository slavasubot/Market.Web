
(function() {
    "use strict";
    angular
        .module("Market.Web")
        .controller("categoryController", ["categoryResource",  categoryController]);

    function categoryController(categoryResource) {
        var vm = this;

        categoryResource.query(function(data) {
            vm.categories = data;
            console.log(vm.categories);
        });

        //$scope.deleteCategory = function(id) {
        //    categoryResource.delete({ id: id });
        //    $scope.categories = categoryResource.query();
        //}
        
    }
}());
