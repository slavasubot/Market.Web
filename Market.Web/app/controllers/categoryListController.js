(function() {
    "use strict";
    angular
        .module("Market.Web")
        .controller("categoryListController", ["categoryResource", categoryListController]);

    function categoryListController(categoryResource) {
        var vm = this;

        categoryResource.query(function(data) {
            vm.categories = data;
        });

       
    }

}());