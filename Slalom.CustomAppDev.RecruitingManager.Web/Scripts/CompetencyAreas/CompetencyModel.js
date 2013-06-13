var competencyModel = function (CompetencyName) {

    var competencyPreview = getBaseCompetency(CompetencyName);
    


    function getBaseCompetency(CompetencyName) {

        var competencies = [{
            CompetencyName: 'Competency Name',
            Description: 'Competency Description',
            History: 'History',
            Level: 'level',
            InterviewedBy: 'John Doe'
        },

            { CompetencyName: 'Test',
                Description: 'Test',
                History: 'Test',
                Level: 'Test',
                InterviewedBy: 'Test'
            }];

        return competencies;
    }




    return competencyPreview;



}