(function () {
    "use strict";
    angular.module('merchant-app.insurance').controller('InsuranceController',InsuranceController);
    angular.module('merchant-app.insurance').directive('personRequired', PersonRequired);
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


    function PersonRequired() {
        return {
            require: 'ngModel',
            link: function (scope, elm, attrs, ctrl) {
                ctrl.$validators.personRequired = function (modelValue, viewValue) {
                    if (typeof (attrs.requiredFields) != 'undefined' && ctrl.$dirty) {
                        var requiredFields = attrs.requiredFields.split(',');
                      
                        if (modelValue != undefined && viewValue != "" && typeof(viewValue) != undefined )
                        {
                            return true;
                        }
                        for (var i = 0 ; i < requiredFields.length; i++) {
                            var field = requiredFields[i];
                            if (typeof(field) != 'undefined' && field != "" && !isNaN(field) && field > 0) {
                                return true;
                            }
                        }
                        return false;
                    }
                    
                    return true;
                };
            }
        };
    }
})();