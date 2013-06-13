function CompetencyHelperCntrl($scope) {

  //Instantiate the model for this scope

   $scope.competencies = competencyModel("test");
         

   $scope.selectedCard = '';

   $scope.getSelectedCard = function (selectedIndex) {

                $scope.selectedCard = $scope.competencies[selectedIndex];
                $('#modalView').show(5000);

            }



}
