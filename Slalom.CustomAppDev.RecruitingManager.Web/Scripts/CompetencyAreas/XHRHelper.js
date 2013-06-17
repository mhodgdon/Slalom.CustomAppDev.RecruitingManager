function createXHRRequest(context, Competency, index) {


    if (context === 'detail') {
        var competency = getCompetencyDetail(Competency, index);
    }
    else {
        var competency = getCompetency(Competency);  
    }




    function getCompetencyDetail(Competency, index) {
        var competencyDetail = [
        {
            CompetencyName: 'Competency Name',
            CompetencyDescription: 'CompetencyDescription',
            Notes: 'Test Notes',
            Level: 'Apprentice',
            InterviewedBy: ['Person 1', 'Person 2', 'Person 3']

        },

       {
           CompetencyName: 'Competency Name 2',
           CompetencyDescription: 'CompetencyDescription 2',
           Notes: 'Test Notes2',
           Level: 'Apprentice',
           InterviewedBy: ['Person 1', 'Person 2', 'Person 3']

       }];

        return competencyDetail[index];
    }

    function getCompetency(Competency) {
        var competencyDetail = [
        {
            CompetencyName: 'Competency Name',
            CompetencyDescription: 'CompetencyDescription',
            Notes: 'Test Notes',
            Level: 'Apprentice',
            InterviewedBy: ['Person 1', 'Person 2', 'Person 3']

        },

       {
           CompetencyName: 'Competency Name 2',
           CompetencyDescription: 'CompetencyDescription 2',
           Notes: 'Test Notes2',
           Level: 'Apprentice',
           InterviewedBy: ['Person 1', 'Person 2', 'Person 3']

       }];

        return competencyDetail;
    }



    return competency;
}