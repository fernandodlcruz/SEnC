(function () {

  'use strict';

  angular
    .module('SEnC')
    .controller('EntryController', entryController);

    entryController.$inject = [
      '$scope', 
      '$transition$', 
      'EntryFactory', 
      'CategoryFactory', 
      'PayMethodFactory'
    ];

    function entryController($scope, $transition$, EntryFactory, CategoryFactory, PayMethodFactory) {
      $scope.isUnique = true;
      $scope.recText;
      $scope.entry = EntryFactory.get()[$transition$.params().id];
      $scope.categoryList = CategoryFactory.get();
      $scope.payMethodList = PayMethodFactory.get();

      $scope.title = "Lançamentos";

      $scope.CancelButton = function() {
          if (confirm("Você perderá qualquer alteração. Confirma?"))
          {
            window.location = "/entry-list";
          }
      }

      $scope.DeleteButton = function() {
          if (confirm("Confirmaa exclusão?"))
          {
            // Validar entradas parceladas
            // e entradas recorrentes
            window.location = "/entry-list";
          }
      }
    }

})();

// Transfer to category Controller
(function () {

  'use strict';

  angular
    .module('SEnC')
    .factory('CategoryFactory', categoryFactory);

  function categoryFactory() {
    var categoryList =  [
      {id:0,description:"Diversos"},
      {id:1,description:"Transporte/Locomoção"},
      {id:2,description:"Moradia"},
      {id:3,description:"Vestuário"},
      {id:4,description:"Diversão"}
      ]; 
    return{
      get : function(){
        return categoryList;
      }    
    };
  }

})();

// Transfer to payment method Controller
(function () {

  'use strict';

  angular
    .module('SEnC')
    .factory('PayMethodFactory', payMethodFactory);

  function payMethodFactory() {
    var payMethodList =  [
      {id:0,description:"Dinheiro"},
      {id:1,description:"Cartão de crédito"}
      ]; 
    return{
      get : function(){
        return payMethodList;
      }    
    };
  }

})();