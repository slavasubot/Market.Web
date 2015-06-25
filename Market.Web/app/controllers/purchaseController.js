
(function() {
    "use strict";
    angular
        .module("Market.Web")
        .controller("purchaseController", ["purchaseResource", purchaseController]);

    function purchaseController(purchaseResource) {
        var vm = this;

        purchaseResource.query(function(data) {
            vm.purchases = data;
        });

        //vm.purchases = [
        //    {
        //        "Id": 1,
        //       "Name": "Bananas",
        //        "Price": 38,
        //        "Buyed": "true",
        //        "BuyedTime": "01-06-2015"
        //    },
        //    {
        //        "Id": 2,
        //        "Name": "Chease",
        //        "Price": 169,
        //        "Buyed": "true",
        //        "BuyedTime": "05-06-201"
        //    }
        //];
    }
}());

