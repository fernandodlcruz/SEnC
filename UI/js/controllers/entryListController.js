(function () {

  'use strict';

  angular
    .module('SEnC')
    .controller('EntryListController', entryListController);

    entryListController.$inject = [
      '$scope',
      'EntryFactory'
    ];

    function entryListController($scope, EntryFactory) {
      $scope.isUnique = true;
      $scope.recText;
      $scope.entryList = EntryFactory.get();

      $scope.title = "Lançamentos";
    }

})();

(function () {

  'use strict';

  angular
    .module('SEnC')
    .factory('EntryFactory', entryFactory);

  function entryFactory() {
    var entryList =  [
      {id:0,date:"20171019T00:00:00",description:"Presente Isabella",value:123.23,category:"Diversos",payMethod:"Dinheiro"},
      {id:1,date:"20171019T00:00:00",description:"Aluguel",value:123.23,category:"Moradia",payMethod:"Dinheiro"},
      {id:2,date:"20171019T00:00:00",description:"Energia elétrica",value:123.23,category:"Moradia",payMethod:"Dinheiro"},
      {id:3,date:"20171019T00:00:00",description:"Combustível",value:123.23,category:"Transporte/Locomoção",payMethod:"Cartão de crédito"},
      {id:4,date:"20171019T00:00:00",description:"Prestação do Carro",value:123.23,category:"Transporte/Locomoção",payMethod:"Cartão de crédito"},
      {id:5,date:"20171019T00:00:00",description:"Estacionamento",value:123.23,category:"Transporte/Locomoção",payMethod:"Cartão de crédito"},
      {id:6,date:"20171019T00:00:00",description:"Gás",value:123.23,category:"Moradia",payMethod:"Dinheiro"},
      {id:7,date:"20171019T00:00:00",description:"Água",value:123.23,category:"Moradia",payMethod:"Dinheiro"},
      {id:8,date:"20171019T00:00:00",description:"Roupas",value:123.23,category:"Vestuário",payMethod:"Cartão de crédito"},
      {id:9,date:"20171019T00:00:00",description:"Viagem",value:123.23,category:"Diversão",payMethod:"Dinheiro"}
      ]; 
    return{
      get: function(){
        return entryList;
      }    
    };
  }

})();