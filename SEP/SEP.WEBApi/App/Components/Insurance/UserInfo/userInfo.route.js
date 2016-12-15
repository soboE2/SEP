(function () {

    angular.module('merchant-app.insurance.userinfo').config(config)

    config.$inject = ['$stateProvider'];
    function config($stateProvider) {
        $stateProvider
			.state('main.insurance.userinfo', {
			    url: '/insurance/userInfo',
			    views: {
			        'content@': {
			            templateUrl: 'app/components/insurance/userinfo/userinfo.html',
			        }
			    }
			});
    }
})();