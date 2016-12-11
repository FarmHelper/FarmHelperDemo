(function () {
    'use strict'

    angular
        .module('FarmApp', ['ngRoute', 'ngAnimate', 'ngAria', 'ngMaterial', 'ngMessages'])
        .config(function ($routeProvider) {
            $routeProvider
                .when("/landing", {
                    templateUrl: "FarmApp/Views/LandingPage.html"
                })
                .when("/main", {
                    templateUrl: "FarmApp/Views/MainPage.html",
                    controller: 'MainController',
                    controllerAs: 'ctrl'
                })
                .when("/questions", {
                    templateUrl: "Template/Questions"
                })
                .when("/sections", {
                    templateUrl: "Template/Sections"
                })
                .when("/administrators", {
                    templateUrl: "Template/Administrators"
                })
		        .otherwise({ redirectTo: "/landing" });
        });
})();