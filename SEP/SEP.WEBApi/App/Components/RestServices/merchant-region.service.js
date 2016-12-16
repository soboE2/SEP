(function () {
    "use strict";
    angular.module('region-module').factory('regionService', regionService);

    regionService.$inject = ['$resource'];
    function regionService($resource) {
        var url = "http://travelinsurance.local/api/insurance/regions";
        return $resource(url, {});
    }
})();