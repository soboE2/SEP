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
        })
        .state('main.insurance.userinfo', {
            url: '/insurance/userInfo',
            views: {
                'content@': {
                    templateUrl: 'app/components/insurance/userinfo/userinfo.html',
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
    }
})();