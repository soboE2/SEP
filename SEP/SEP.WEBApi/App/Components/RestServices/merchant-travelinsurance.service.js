(function () {
    "use strict";
    angular.module('travelinsurance-module').factory('travelInsuranceService', travelInsuranceService);

    travelInsuranceService.$inject = ['$resource'];
    function travelInsuranceService($resource) {
    	var travelInsuranceAmmountUrl = "http://travelinsurance.local/api/insurance/travelinsuranceprice";

    	var retValue = {};
    	retValue.travelAmmount = $resource(travelInsuranceAmmountUrl, {});

    	return retValue;
    }
})();