function ConsultingSkillsController($scope) {

    $scope.competencies =
           [{
               CompetencyName: 'Competency Name',
               Description: 'Competency Description',
               History: 'History',
               Level: 'level',
               InterviewedBy: 'John Doe'
           },

            {  CompetencyName: 'Test',
                Description: 'Test',
                History: 'Test',
                Level: 'Test',
                InterviewedBy: 'Test'
            }];
        


}

 
 /* $scope.competencies = null;

    $scope.CompetencyTileData = function () {
        if ($scope.competencies == null) {
            loadCompetencies();
        }

        return $scope.competencies;
    };

    function loadCompetencies() {
        $scope.competencies = [
            {
                CompetencyName: 'Competency Name',
                Description: 'Competency Description' ,
                History: 'History',
                Level: 'level',
                InterviewedBy: 'John Doe'
            }
        ];

    }
}

*/