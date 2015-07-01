(function() {
    "use strict";

    angular
        .module("Market.Web")
        .controller("categoryDetailController", [ "category", categoryDetailController]);

    function categoryDetailController(category) {
        var vm = this;

        vm.category = category;
            
        vm.title = "Category Detail:" + vm.category.name;

    }
}());