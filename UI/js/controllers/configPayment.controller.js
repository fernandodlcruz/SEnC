(function () {

  'use strict';

  angular
    .module('SEnC')
    .controller('ConfigPaymentController', configPaymentController);

    configPaymentController.$inject = [
      '$scope',
      'PaymentListFactory'
    ];

    function configPaymentController($scope, PaymentListFactory) {
      $scope.paymentList = PaymentListFactory.get();

      $scope.title = "Formas de Pagamento";
      $scope.editId = "";
      $scope.editDescription = "";
      $scope.toggleModal = function(id, desc)
      {
          $scope.editId = id;
          $scope.editDescription = desc;
      };
    }

})();

(function () {

  'use strict';

  angular
    .module('SEnC')
    .factory('PaymentListFactory', paymentListFactory);

  function paymentListFactory() {
    var paymentList =  [
      {id:0,description:"Dinheiro",value:23},
      {id:1,description:"Débito em Conta",value:23},
      {id:2,description:"Cartão de Crédito",value:1233}      
      ]; 
    return{
      get: function(){
        return paymentList;
      }
    };
  }

})();