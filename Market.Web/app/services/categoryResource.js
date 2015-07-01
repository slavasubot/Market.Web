(function() {

    "use strict";
    angular
        .module("common.services")
        .factory("categoryResource", ["$resource", categoryResource]);

    function categoryResource($resource) {
        return $resource("http://localhost:4750/api/category/:id", null,
            {
                'update': { method: 'PUT' },
                'delete': { method: 'DELETE'}
            });
    }
}());