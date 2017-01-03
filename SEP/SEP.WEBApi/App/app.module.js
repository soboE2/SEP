(function () {
    angular.module('merchant-app', ['merchant-app.core','sport-module', 'region-module', 'merchant-app.insurance']).config(['$qProvider', function ($qProvider) {
        $qProvider.errorOnUnhandledRejections(false);
    }]);
})();