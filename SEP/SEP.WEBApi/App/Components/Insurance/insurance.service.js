(function () {
    "use strict";

    angular.module('merchant-app.insurance', ['travelinsurance-module']).factory('insuranceService', insuranceService);

    insuranceService.$inject = ['travelInsuranceService'];

    function insuranceService(travelInsuranceService) {
        var insurance = {};
        insurance.travel = {};
        insurance.travel.sport = {}
        insurance.travel.region = {}
        insurance.travel.users = [];

        var getInsurance = function () {
            return insurance;
        };

        var setInsurance = function (value) {
            insurance = value;
        };

        var getTravelInsurance = function () {
            return insurance.travel;
        };

        var getInsuranceUsers = function () {
            return insurance.travel.users;
        };
        var getTravelInsurancePrice = function () {
            var travelInsuranceRiskItem = {};
            travelInsuranceRiskItem.RegionID = isnurance.travel.region
        }

        return {
            getInsurance: getInsurance,
            setInsurance: setInsurance,
            getTravelInsurance: getTravelInsurance,
            getInsuranceUsers: getInsuranceUsers,
            getTravelInsurancePrice: getTravelInsurancePrice
        };
    }
})();