(function () {

  'use strict';

  angular
    .module('SEnC')
    .controller('ConfigCategoryController', configCategoryController);

    configCategoryController.$inject = [
      '$scope',
      '$state',
      '$window',
      'CategoryListFactory'
    ];

    function configCategoryController($scope, $state, $window, CategoryListFactory) {
      //$scope.categoryList = CategoryListFactory.get();

      CategoryListFactory.query(function(catList){
        $scope.categoryList = catList;
      })

      $scope.title = "Categorias";
      $scope.editId = "";
      $scope.editDescription = "";
      $scope.toggleModal = function(group)
      {
        if (group == null)
        {
          $scope.entry = new CategoryListFactory();
          $scope.entry.id = 0;
        }
        else
        {
          $scope.entry = group;
        }
      };

      $scope.sendData = function()
      {
        $scope.entry.usuarioId = 1;

        if ($scope.entry.id == 0)
        {
          $scope.entry.$save(function() {
            $state.reload();
          });
        }
        else
        {
          $scope.entry.$update(function() {
            $state.reload();
          });
        }
      };

      $scope.deleteData = function ()
      {
        if ($window.confirm("Deseja Realmente Deletar?"))
        {
          $scope.entry.$delete($scope.entry.id, function (){
            $state.reload();
          });
        }
      };
    }

})();

(function () {

  'use strict';

  angular
    .module('SEnC')
    .factory('CategoryListFactory', categoryListFactory);

  categoryListFactory.$inject = [
    '$resource'
  ];

  function categoryListFactory($resource) {
    var categoryList =  $resource(API_URL + "grupo/:id", { id: '@id' },
      {update: {
        method: 'PUT'
      }
    });

    return categoryList;
    
    // [
    //   {id:0,root:0,description:"Moradia",value:23,qtyEntry:2},
    //   {id:1,root:1,description:"Aluguel",value:1233.44,qtyEntry:3},
    //   {id:2,root:1,description:"Energia elétrica",value:123,qtyEntry:4},
    //   {id:6,root:1,description:"Gás",value:13,qtyEntry:0},
    //   {id:7,root:1,description:"Água",value:12,qtyEntry:2},
    //   {id:3,root:0,description:"Transporte",value:123,qtyEntry:2},
    //   {id:4,root:1,description:"Prestação do Carro",value:12323,qtyEntry:2},
    //   {id:5,root:1,description:"Estacionamento",value:1233,qtyEntry:7},
    //   {id:10,root:0,description:"Vestuário",value:12,qtyEntry:2},
    //   {id:8,root:1,description:"Roupas",value:12,qtyEntry:8},
    //   {id:11,root:0,description:"Lazer",value:12,qtyEntry:9},
    //   {id:9,root:1,description:"Viagem",value:123,qtyEntry:12}
    //   ]; 
    // return{
    //   get: function(){
    //     return categoryList;
    //   }
    // };
  }

})();