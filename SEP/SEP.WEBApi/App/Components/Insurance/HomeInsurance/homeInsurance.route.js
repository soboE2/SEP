(function () {

    angular.module('merchant-app.insurance.homeinsurance').config(config)

    config.$inject = ['$stateProvider'];
    function config($stateProvider) {
        $stateProvider
			.state('main.insurance.homeInsurance', {
			    url: '/insurance/homeInsurance',
			    views: {
			        'content@': {
			            templateUrl: 'app/components/insurance/homeinsurance/homeinsurance.html',
			        }
			    }
			});
    }
})();