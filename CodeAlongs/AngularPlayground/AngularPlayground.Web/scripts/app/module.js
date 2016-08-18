var myApp = angular.module('demoApp', []);

myApp.controller('SimpleController',
    function($scope) {
        $scope.players = [
        { name: 'Kyrie Irving', city: 'Cleveland' },
        { name: 'Jason Kipniss', city: 'Cleveland' },
        { name: 'Bryce Harper', city: 'Washington D.C.' }
        ];
    });