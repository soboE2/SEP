(function () {

    angular.module('merchant-app.core').config(config)

    config.$inject = ['$stateProvider', '$urlRouterProvider'];
    function config($stateProvider, $urlRouterProvider) {
        $urlRouterProvider.otherwise('/home');

        $stateProvider
			.state('main', {
			    abstract: true,
			    views: {
			        'header': {
			            templateUrl: 'app/components/core/header.html',
			        },
			        'footer': {
			            templateUrl: 'app/components/core/footer.html'
			        },
			        'menu': {
			            templateUrl: 'app/components/core/menu.html'
			        }
			    }
			})
        .state('main.home', {
            url: '/home',
            views: {
                'content@': {
                    templateUrl: 'app/components/core/home.html'
                }
            }
        });
    }
})();