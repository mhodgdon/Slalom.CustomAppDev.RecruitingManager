function CompetencyHelperCntrl($scope, $http) {

  //Instantiate the model for this scope

   $scope.competencies = competencyModel("test");
         

   $scope.selectedCard = '';

   $scope.getSelectedCard = function (selectedIndex) {

       $http({
           url: "http://ec2-54-214-149-243.us-west-2.compute.amazonaws.com/RMAPI/Resources/Competency/2",
           dataType: "json",
           method: "GET",
           headers: {
               "Content-Type": "application/json; charset=utf-8"
           }
       }).success(function (response) {
           alert(response);
       }).error(function (error) {
           $scope.error = error;
       });
        


      // $scope.selectedCard = $scope.competencies[selectedIndex];
       $scope.selectedCard = competencyDetailModel('test', selectedIndex);

       $('#modalView').show(5000);

   }



}
