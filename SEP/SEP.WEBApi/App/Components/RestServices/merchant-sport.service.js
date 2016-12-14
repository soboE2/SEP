(function () {
    angular.module('sport-module').factory('sportService', sportService);

    sportService.$inject = ['$resource'];
    function sportService($resource) {
        var url = "http://travelinsurace.local/insurance/sport";
        return $resource(url, {});
    }
})