//Declaring angular module
var AnguarModule = angular.module('ShowItems', []);


//Declaring angular controller
// ApiCall---This is the service name which is in ApiCallService.js file
AnguarModule.controller('ItemsController', function ($scope, $http, ApiCall) {

    $scope.fileName = 'Test';
    //Load dropdown in page load event  with get api call using service
    var result = ApiCall.GetApiCall("Values", "1").success(function (data) {
        var data = angular.fromJson(data);
        $scope.items = data;
    });
});


//Declaring angular controller
// ApiCall---This is the service name which is in ApiCallService.js file
AnguarModule.controller('UploadImageController', function ($scope, $http, ApiCall) {
    $scope.log = "stop";

    $scope.uploading = false;

    $scope.countFiles = '';
    $scope.data = []; //For displaying file name on browser
    $scope.formdata = new FormData();
    $scope.getFiles = function (file) {
        angular.forEach(file, function (value, key) {
            $scope.formdata.append(key, value);
            $scope.data.push({ FileName: value.name, FileLength: value.size });

        });
        //This line just shows you there is possible to
        //send in the extra parameter to the server.


        //$scope.countFiles = $scope.data.length == 0 ? '' : $scope.data.length + ' files selected';
        //$scope.$apply();
        //$scope.formdata.append('countFiles', $scope.countFiles);

    };

    $scope.uploadFiles = function () {
        $scope.log = "start";
        $scope.uploading = true;
        var result = ApiCall.PostApiCall("http://dealitemsservice.azurewebsites.net/api/Values", $scope.formdata).success(function (data) {
            var data = angular.fromJson(data);
            $scope.items = data;
        });
    };
});

