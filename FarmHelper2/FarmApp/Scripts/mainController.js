(function () {
    'use strict'

    angular
        .module('FarmApp')
        .controller('MainController', MainController)

    MainController.$inject = ['$location', 'httpService'];

    function MainController(location, httpService) {

        var vm = this;
        vm.soilTypes = ['Fertil', 'Argilos', 'Arid'];
        vm.soil = {};
        vm.sendSoil = sendSoil;

        function sendSoil() {
            /*if (isNaN(soil.umiditate)) {
                ngToast.warning({
                    content: 'Humidity should be between 0 and 100'
                });
                return;
            }
            if (isNaN(soil.temperatura)) {
                ngToast.warning({
                    content: 'Temperature should be between 0 and 40'
                });
                return;
            }*/
            httpService.post('api/Plants', vm.soil).then(function(data){
                vm.test = data;
            });
        }

    }
})();