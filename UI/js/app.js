/*'use strict';

var app = angular.module("SEnC", ["ngRoute"]);

app.config(function($routeProvider) {
    $routeProvider.when('/',{ templateUrl: 'view/dashboard.html', controller: "dashboardCtrl" }).
    when('/graficos',
      {
        template: 'Detalhes da Task {{task.id}}:'+
          '<h4>Nome: {{task.name}}</h4>'+ 
  '</div>'+'<a ng-href="#/"> Voltar</a>',
        controller: "TaskDetailCtrl"
      }
    ).when('/entry-list',{ templateUrl: 'view/entry-list.html', controller: "entryListCtrl" })
    .when('/entry',{ templateUrl: 'view/entry.html', controller: "entryCtrl" })
    .otherwise({redirect:'/'});
});*/

(function () {

  'use strict';

  angular
    .module('SEnC', ['auth0.auth0', 'ui.router', 'ngResource'])
    .config(config);

  config.$inject = [
    '$stateProvider',
    '$locationProvider',
    '$urlRouterProvider',
    'angularAuth0Provider'
  ];

  function config(
    $stateProvider,
    $locationProvider,
    $urlRouterProvider,
    angularAuth0Provider
  ) {

    $stateProvider
      .state('home', {
        url: '/',
        controller: 'HomeController',
        templateUrl: 'view/dashboard.html',
        controllerAs: 'vm'/*,
        onEnter: checkAuthentication*/
      })
      .state('entry-list', { 
        url: '/entry-list',
        controller: 'EntryListController',
        templateUrl: 'view/entry-list.html',
        controllerAs: "vm",
        onEnter: checkAuthentication
      })
      .state('entry', { 
        url: '/entry/{id}',
        controller: 'EntryController',
        templateUrl: 'view/entry.html', 
        controllerAs: 'vm',
        onEnter: checkAuthentication
      })
      .state('config-category', {
        url: '/config-category',
        controller: 'ConfigCategoryController',
        templateUrl: 'view/config-category.html', 
        controllerAs: 'vm'/*,
        onEnter: checkAuthentication*/
      })
      .state('config-payment', {
        url: '/config-payment',
        controller: 'ConfigPaymentController',
        templateUrl: 'view/config-payment.html', 
        controllerAs: 'vm',
        onEnter: checkAuthentication
      })
      .state('config-goal', {
        url: '/config-goal',
        controller: 'ConfigGoalController',
        templateUrl: 'view/config-goal.html', 
        controllerAs: 'vm',
        onEnter: checkAuthentication
      })
      .state('profile', {
        url: '/profile',
        controller: 'ProfileController',
        templateUrl: 'view/profile.html', 
        controllerAs: 'vm'/*,
        onEnter: checkAuthentication*/
      })
      .state('callback', {
        url: '/callback',
        controller: 'CallbackController',
        templateUrl: 'view/callback.html',
        controllerAs: 'vm',
        onEnter: checkAuthentication
      });

    // Initialization for the angular-auth0 library
    angularAuth0Provider.init({
      clientID: AUTH0_CLIENT_ID,
      domain: AUTH0_DOMAIN,
      responseType: 'token id_token',
      audience: 'https://' + AUTH0_DOMAIN + '/userinfo',
      redirectUri: AUTH0_CALLBACK_URL,
      scope: 'openid profile'
    });

    $urlRouterProvider.otherwise('/');

    $locationProvider.hashPrefix('');

    /// Comment out the line below to run the app
    // without HTML5 mode (will use hashes in routes)
    $locationProvider.html5Mode(true);
  }

  function checkAuthentication($transition$) {
    var $state = $transition$.router.stateService;
    var auth = $transition$.injector().get('authService');
    if (!auth.isAuthenticated()) {
      auth.login();
      //return $state.target('/');
    }
  }

})();

(function () {

  'use strict';

  angular
    .module('SEnC')
    .controller('HomeController', homeController);

  homeController.$inject = ['authService'];

  function homeController(authService) {

    var vm = this;
    vm.auth = authService;
    //$scope.title = "Dashboard";

  }

})();


/*
(function () {

  'use strict';

  angular
      .module('SEnC')
      .factory("TaskFactory",function(){
  var tasklist =  [
      {name:"terminar meu app",id:0},
      {name:"comprar presente",id:1}
      ]; 
    return{
      get : function(){
    return tasklist;
      }
    };
  });

})();

(function () {

  'use strict';

  angular
      .module('SEnC')
      .controller('dashboardCtrl', function ($scope,TaskFactory) {
    (function(){$scope.tasks=TaskFactory.get();$scope.title = "Dashboard";})();
  });
})();

(function () {

  'use strict';

  angular
      .module('SEnC')
      .controller('TaskDetailCtrl', function ($scope,TaskFactory,$routeParams) {
    (function(){$scope.task=TaskFactory.get()[0];})();
    //(function(){$scope.task=TaskFactory.get()[$routeParams.taskId];})();
  });

})();


(function () {

  'use strict';

  angular
      .module('SEnC')
      .directive('numbersOnly', function () {
      return {
          require: 'ngModel',
          link: function (scope, element, attr, ngModelCtrl) {
              function fromUser(text) {
                  if (text) {
                      var transformedInput = text.replace(/[^0-9]/g, '');

                      if (transformedInput !== text) {
                          ngModelCtrl.$setViewValue(transformedInput);
                          ngModelCtrl.$render();
                      }
                      return transformedInput;
                  }
                  return undefined;
              }            
              ngModelCtrl.$parsers.push(fromUser);
          }
      };
  });

})();

(function () {

  'use strict';

  angular
      .module('SEnC')
      .directive('decimalsOnly', function() {
        return {
          require: '?ngModel',
          link: function(scope, element, attrs, ngModelCtrl) {
            if(!ngModelCtrl) {
              return; 
            }

            ngModelCtrl.$parsers.push(function(val) {
              if (angular.isUndefined(val)) {
                  var val = '';
              }
              
              var clean = val.replace(/[^-0-9\,]/g, '');
              var negativeCheck = clean.split('-');
              var decimalCheck = clean.split(',');
              if(!angular.isUndefined(negativeCheck[1])) {
                  negativeCheck[1] = negativeCheck[1].slice(0, negativeCheck[1].length);
                  clean =negativeCheck[0] + '-' + negativeCheck[1];
                  if(negativeCheck[0].length > 0) {
                    clean =negativeCheck[0];
                  }                  
              }
                
              if(!angular.isUndefined(decimalCheck[1])) {
                  decimalCheck[1] = decimalCheck[1].slice(0,2);
                  clean =decimalCheck[0] + ',' + decimalCheck[1];
              }

              if (val !== clean) {
                ngModelCtrl.$setViewValue(clean);
                ngModelCtrl.$render();
              }
              return clean;
            });

            element.bind('keypress', function(event) {
              if(event.keyCode === 32) {
                event.preventDefault();
              }
            });
          }
        };
      });
})();
*/