var competencyModel = function (CompetencyName) {

    var competencyPreview = getBaseCompetency(CompetencyName);
    var competencyDetail = null; //Add Competency Detail Calls when selected 


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

    function getCompetencyDetail(CompetencyName) {



    }

    function createXHRRequest() {


    }




    return competencyPreview;



}