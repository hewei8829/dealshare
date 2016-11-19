//Declaring angular module
var AnguarModule = angular.module('ShowItems', []);


//Declaring angular controller
// ApiCall---This is the service name which is in ApiCallService.js file
AnguarModule.controller('AppController', function ($scope, $http, ApiCall) {

    //Load dropdown in page load event  with get api call using service
    var result = ApiCall.GetApiCall("Values", "1").success(function (data) {
        var data = angular.fromJson(data);
        $scope.items = data;
    });
});


