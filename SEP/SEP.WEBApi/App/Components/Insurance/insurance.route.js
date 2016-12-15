(function () {

    angular.module('merchant-app.insurance').config(config)

    config.$inject = ['$stateProvider'];
    function config($stateProvider) {
        $stateProvider
			.state('main.insurance', {
                url : '/insurance',
			    views: {
			        'content@': {
			            resolve: {
			                sports: getSport
			            },
			            templateUrl: 'app/components/insurance/insurance.html',
			            controller: "InsuranceController",
			            controllerAs: 'ic'
			        }
			    }
			});

        //injektuje sport servis
        getSport.$inject = ['sportService'];    
        function getSport(sportService) {
            return sportService.query().$promise;
        }
        /*
        $promise: the promise of the original server interaction that created this instance or collection.
        On success, the promise is resolved with the same resource instance or collection object, updated with data from server.
        This makes it easy to use in resolve section of $routeProvider.when() to defer view rendering until the resource(s) are loaded.
        On failure, the promise is rejected with the http response object, without the resource property.
        If an interceptor object was provided, the promise will instead be resolved with the value returned by the interceptor.
        */
    }
})();