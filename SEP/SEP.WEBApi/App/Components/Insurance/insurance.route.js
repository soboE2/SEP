(function () {

    angular.module('merchant-app.insurance').config(config)

    config.$inject = ['$stateProvider', '$urlRouterProvider'];
    function config($stateProvider, $urlRouterProvider) {
        $urlRouterProvider.otherwise('/home');

        $stateProvider
			.state('main.insurance', {
                url : '/insurance',
			    views: {
			        'content@': {
			            templateUrl: 'app/components/insurance/insurance.html',
			        }
			    }
			});
    }
})();