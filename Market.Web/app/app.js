(function() {
    "use strict";

    var app = angular.module("Market.Web", ["common.services", "ui.router"]);

    app.config(["$stateProvider", "$urlRouterProvider", function ($stateProvider, $urlRouterProvider) {

        $urlRouterProvider.otherwise("/");

        $stateProvider
            .state("categoryList", {
                url: "/categories",
                templateUrl: "app/templates/categoryListView.html",
                controller: "categoryListController as vm"

            })
            .state("home", {
                url: "/",
                templateUrl: "app/templates/welcomeView.html"
            })
            .state("categoryEdit", {
                url: "/categories/edit/:id",
                templateUrl: "app/templates/categoryEditView.html",
                controller: "categoryEditController as vm",
                resolve: {
                    categoryResource: "categoryResource",
                    category: function (categoryResource, $stateParams) {
                        var categoryId = $stateParams.id;
                        return categoryResource.get({ id: categoryId }).$promise;
                    }
                }

            })

            .state("categoryAdd", {
                url: "/categories/add/:id",
                templateUrl: "app/templates/addCategoryView.html",
                controller: "addCategoryController as vm"
            })

            .state("categoryDelete", {
                url: "/categories/delete/:id",
                templateUrl: "app/templates/categoryListView.html",
                controller: "categoryDeleteController as vm",
                resolve: {
                    categoryResource: "categoryResource",
                    category: function(categoryResource, $stateParams) {
                        var categoryId = $stateParams.id;
                        return categoryResource.delete({ id: categoryId }).$promise;
                    }
                }
            })

            .state("categoryDetail", {
                url: "/categories/:id",
                templateUrl: "app/templates/categoryDetailView.html",
                controller: "categoryDetailController as vm",
                resolve: {
                    categoryResource: "categoryResource",
                    category: function(categoryResource, $stateParams) {
                        var categoryId = $stateParams.id;
                        return categoryResource.get({ id: categoryId }).$promise;
                    }
                }
            });

        
        
    }]);

}());