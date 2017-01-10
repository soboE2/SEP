(function () {
    "use strict";

    angular.module('merchant-app.insurance').factory('insuranceService', insuranceService);

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
            var travelInsuranceModel = getTravelInsurance();
            var price = null;
            return travelInsuranceService.travelAmmount.getPrice(travelInsuranceModel).$promise;
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