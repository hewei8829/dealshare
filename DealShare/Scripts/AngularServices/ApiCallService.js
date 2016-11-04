﻿AnguarModule.service('ApiCall', ['$http', function ($http) {
    var result;

    var config = { headers: {} };
    // This is used for calling get methods from web api
    this.GetApiCall = function (controllerName,methodName) {
        result = $http.get('http://dealitemsservice.azurewebsites.net/api/' + controllerName + '/' + methodName,config).success(function (data, status) {
            result = (data);
        }).error(function () {
            alert("Something went wrong");
        });
        return result;
    };

    // This is used for calling post methods from web api with passing some data to the web api controller
    this.PostApiCall = function (controllerName, methodName,obj) {
        result = $http.post('api/' + controllerName + '/' + methodName, obj).success(function (data, status) {
            result = (data);
        }).error(function () {
            alert("Something went wrong");
        });
        return result;
    };
}]);

