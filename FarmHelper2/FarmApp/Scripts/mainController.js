(function () {
    'use strict'

    angular
        .module('FarmApp')
        .controller('MainController', MainController)

    MainController.$inject = ['$scope', '$location', 'httpService'];

    function MainController($scope, location, httpService) {

        var vm = this;
        vm.soilTypes = ['Fertil', 'Argilos', 'Arid'];
        vm.soil = {};
        vm.sendSoil = sendSoil;
        $scope.soi = {
            umiditate: 500
        };

        function sendSoil() {
            /*if (isNaN(soil.umiditate)) {
                return;
            }
            if (isNaN(soil.temperatura)) {
                return;
            }*/
            httpService.post('api/Plants', vm.soil).then(function(data){
                vm.test = data;
            });
        }

    }
})();