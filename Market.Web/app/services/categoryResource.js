(function() {
    "use strict";

    angular.module("common.services")
           .factory("categoryResource", ["$resource", "appSettings", categoryResource]);

    function categoryResource($resource, appSettings) {
        return $resource(appSettings.serverPath + "/api/category/:id", null,
        {
            'query': { method: 'GET', isArray: true },
            'get': { method: 'GET' },
            'create': {method: 'POST'},
            'update': { method: 'PUT' },
            'remove': { method: 'DELETE'}
        });
    }
}());


