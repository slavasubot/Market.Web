(function () {
    "use strict";
    var app = angular.module("Market.Web", ["common.services","ngRoute", "ui.router"]);

    //app.config(["$stateProvider", function ($stateProvider, $urlRouterProvider) {

    //    $urlRouterProvider.otherwise("/");

    //        $stateProvider.state("home", {
    //            url: "/",
    //            templateUrl:"app/template/welcomeView.html",
    //        });

    //        $stateProvider.state("categoryList", {
    //            url: "api/category",
    //            templateUrl: "app/templates/categoryListView.html",
    //            controller: "categoryController as vm"
    //        });
    //    }
    //]);


    app.config(function($routeProvider) {
        $routeProvider.when("/home", {
            controller: "",
            templateUrl: "app/templates/welcomeView.html"
        });

        $routeProvider.when("/categories", {
            controller: "categoryController as vm",
            templateUrl: "app/templates/categoryListView.html"
        });

        $routeProvider.when("/addcategory", {
            controller: "addCategoryController",
            templateUrl: "app/templates/addCategoryView.html"
        });

        $routeProvider.when("/editcategory", {
            controller: "categoryEditController",
            templateUrl: "app/templates/categoryEditView.html"
        });

    });

}());
