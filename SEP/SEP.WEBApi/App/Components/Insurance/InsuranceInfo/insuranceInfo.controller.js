(function () {
    "use strict";
    angular.module('merchant-app.insurance').controller('InsuranceInfoController', InsuranceInfoController);

    InsuranceInfoController.$inject = ['sports', 'regions', 'insuranceService', '$state'];
    function InsuranceInfoController(sports, regions, insuranceService, $state) {
        var iic = this;

        iic.insurance = insuranceService.getInsurance();
        iic.insurance.travel = insuranceService.getTravelInsurance();
        iic.region = search(iic.insurance.travel.regionID, regions)
        iic.sport = search(iic.insurance.travel.sportId, sports)
        insuranceService.getTravelInsurancePrice().then(function (response) {
            iic.price = response.price;
        });



        function search(ID, myArray) {
            for (var i=0; i < myArray.length; i++) {
                if (myArray[i].ID == ID) {
                    return myArray[i].Name;
                }
            }
        };

    }
})();