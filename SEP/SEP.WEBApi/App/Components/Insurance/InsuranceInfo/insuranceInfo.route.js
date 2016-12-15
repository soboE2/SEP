(function () {

    angular.module('merchant-app.insurance.insuranceinfo').config(config)

    config.$inject = ['$stateProvider'];
    function config($stateProvider) {
        $stateProvider
			.state('main.insurance.insuranceInfo', {
                url : '/insurance/insuranceInfo',
			    views: {
			        'content@': {
			            templateUrl: 'app/components/insurance/insuranceinfo/insuranceinfo.html',
			        }
			    }
			});
    }
})();