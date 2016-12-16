(function () {
    "use strict";
    angular.module('merchant-app.insurance').config(config)

    config.$inject = ['$stateProvider'];
    function config($stateProvider) {
        $stateProvider.state('main.insurance', {
            url: '/insurance',
            views: {
                'content@': {
                    resolve: {
                        sports: getSports,
                        regions: getRegions
                    },
                    templateUrl: 'app/components/insurance/insurance.html',
                    controller: 'InsuranceController as ic'
                }
            }
        })
        .state('main.insurance.insuranceInfo', {
            url : '/insurance/insuranceInfo',
            views: {
                'content@': {
                    resolve : {
                        sports: getSports,
                        regions: getRegions
                    },
                    templateUrl: 'app/components/insurance/insuranceinfo/insuranceinfo.html',
                    controller: 'InsuranceInfoController as iic'
                }
            }
        });

        //injektuje sport servis
        getSports.$inject = ['sportService'];
        function getSports(sportService) {
            return sportService.query().$promise;
        }
        
        //injekcija region servisa
        getRegions.$inject = ['regionService'];
        function getRegions(regionService) {
            return regionService.query().$promise;
        }

        /*
        $promise: the promise of the original server interaction that created this instance or collection.
        On success, the promise is resolved with the same resource instance or collection object, updated with data from server.
        This makes it easy to use in resolve section of $routeProvider.when() to defer view rendering until the resource(s) are loaded.
        On failure, the promise is rejected with the http response object, without the resource property.
        If an interceptor object was provided, the promise will instead be resolved with the value returned by the interceptor.
        */
    }
})();