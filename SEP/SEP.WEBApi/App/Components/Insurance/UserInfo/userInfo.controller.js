(function () {
    "use strict";
    angular.module('merchant-app.insurance').controller('UserInfoController', UserInfoController);
    
    UserInfoController.$inject = ['insuranceService', '$state'];
    function UserInfoController(insuranceService, $state) {
        var uic = this;

        uic.insurance = insuranceService.getInsurance();
        uic.insurance.travel = insuranceService.getTravelInsurance();

    }

})();