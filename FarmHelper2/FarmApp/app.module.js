(function () {
    'use strict'

    angular
        .module('FarmApp', ['ngRoute', 'ngAnimate', 'ngAria', 'ngMaterial'])
        .config(function ($routeProvider) {
            $routeProvider
                .when("/landing", {
                    templateUrl: "FarmApp/Views/LandingPage.html",
                    controller: 'LandingController',
                    controllerAs: 'ctrl'
                })
                .when("/exams", {
                    templateUrl: "Template/Exams"
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