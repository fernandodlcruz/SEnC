(function () {

  'use strict';

  angular
    .module('SEnC')
    .controller('ProfileController', profileController);

  profileController.$inject = ['$scope', 'authService'];

  function profileController($scope, authService) {

    var vm = this;
    vm.auth = authService;
    vm.profile;

    $scope.title = "Perfil";

    if (authService.getCachedProfile()) {
      vm.profile = authService.getCachedProfile();
    } else {
      authService.getProfile(profCallBack);
      /*authService.getProfile(function(err, profile) {
        vm.profile = profile;
      });*/
    }

    function profCallBack(err, profile) {
        if (!err) {
            vm.profile = profile;
            $scope.$apply();
        }
        else{
            $scope.title = err;
        }        
    }

  }

})();