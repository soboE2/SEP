(function () {
    angular.module('sport-module').factory('sportService', sportService);

    sportService.$inject = ['$resource'];
    function sportService($resource) {
        var url = "http://travelinsurance.local/api/insurance/sports";
        return $resource(url, {});
    }
})();