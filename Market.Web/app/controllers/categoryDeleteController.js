(function() {
    "use strict";

    angular
        .module("Market.Web")
        .controller("categoryDeleteController", categoryDeleteController);

    function categoryDeleteController(categoryResource, $stateParams) {
        var vm = this;
        categoryResource.delete({id: $stateParams.id});
        
        categoryResource.query(function (data) {
            vm.categories = data;
        });
    }


}());