(function () {
    "use strict";
    angular.module('merchant-app.insurance').controller('InsuranceController',InsuranceController);

    InsuranceController.$inject = ['sports', 'regions', 'insuranceService', '$state'];
    function InsuranceController(sports, regions, insuranceService, $state) {
        var ic = this;

        ic.sports = sports;
        ic.regions = regions;
        ic.insurance = insuranceService.getInsurance();
        ic.insurance.travel = insuranceService.getTravelInsurance();
        ic.formName = "InsuraceController.Insurance";
        ic.goToDetails = goToDetails;


        function goToDetails() {
            if (ic.formName.$valid) {
                $state.go('main.insurance.insuranceInfo');
            }
        }
    }
})();