(function () {
    'use strict'

    angular
        .module('FarmApp')
        .controller('MainController', MainController)

    MainController.$inject = ['$location', 'httpService'];

    function MainController(location, httpService) {

        var vm = this;
        vm.startApp = startApp;

        function startApp() {
            alert('Hello')
            location.path('/main')
            //vm.data = {}
            //vm.data.umiditate = 3
            //httpService.post('api/Plants', vm.data);
        }

    }
})();