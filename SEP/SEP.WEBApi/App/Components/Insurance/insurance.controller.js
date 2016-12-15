(function () {
    angular.module('merchant-app.insurance').controller('InsuranceController', InsuranceController);

    InsuranceController.$inject = ['sports'];
    function InsuranceController(sports) {
        var ic = this;

        ic.sports = sports;
    }
})();