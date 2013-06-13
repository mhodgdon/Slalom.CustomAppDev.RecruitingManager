var competencyDetailModel = function (Competency, index) {

    var selectedCompetencyDetail = getCompetencyDetail(Competency, index);

    function getCompetencyDetail(Competency, index) {
        var competencyDetail = [
        {
            CompetencyName: 'Competency Name',
            CompetencyDescription: 'CompetencyDescription',
            Notes: 'Test Notes'
        },
        {
            CompetencyName: 'Competency Name 2',
            CompetencyDescription: 'CompetencyDescription 2',
            Notes: 'Test Notes 2'

        }];

        return competencyDetail[index];
    }

    return selectedCompetencyDetail;

}