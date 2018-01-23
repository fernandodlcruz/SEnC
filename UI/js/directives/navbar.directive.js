(function() {
  
  'use strict';
  
  angular
    .module('SEnC')
    .directive('navbar', navbar);
    
  function navbar() {
    return {
      templateUrl: 'view/navbar.html',
      controller: navbarController,
      link: function(scope, element) {

        element.parent().append('<script src="js/metisMenu.min.js"></script>');
        element.parent().append('<script src="js/sb-admin-2.js"></script>');

    },
      controllerAs: 'vm'
    }
  }

  navbarController.$inject = ['authService'];
    
  function navbarController(authService) {
    var vm = this;
    vm.auth = authService;
    vm.profile;

    if (authService.getCachedProfile()) {
      vm.profile = authService.getCachedProfile();
    } else {
      authService.getProfile(profCallBack);
    }

    function profCallBack(err, profile) {
        if (!err) {
            vm.profile = profile;
            $scope.$apply();
        }
    }
  }
  
})();