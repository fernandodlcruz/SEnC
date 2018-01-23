(function () {

  'use strict';

  angular
    .module('SEnC')
    .controller('ConfigGoalController', configGoalController);

    configGoalController.$inject = [
      '$scope',
      'CategoryListFactory'
    ];

    function configGoalController($scope, CategoryListFactory) {
      $scope.categoryList = CategoryListFactory.get();

      $scope.title = "Metas";
    }

})();