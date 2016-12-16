(function () {
    "use strict";
    angular.module('merchant-app.insurance').controller('InsuranceInfoController', InsuranceInfoController);

    InsuranceInfoController.$inject = ['sports', 'regions', 'insuranceService', '$state'];
    function InsuranceInfoController(sports, regions, insuranceService, $state) {
        var iic = this;

        iic.insurance = insuranceService.getInsurance();
        iic.insurance.travel = insuranceService.getTravelInsurance();
        iic.region = search(iic.insurance.travel.selectedRegion, regions)
        iic.sport = search(iic.insurance.travel.selectedSport, sports)




        function search(ID, myArray) {
            for (var i=0; i < myArray.length; i++) {
                if (myArray[i].ID == ID) {
                    return myArray[i].Name;
                }
            }
        };

    }
})();