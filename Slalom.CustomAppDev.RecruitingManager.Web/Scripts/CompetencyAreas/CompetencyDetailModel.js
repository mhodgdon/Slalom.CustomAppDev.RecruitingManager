var competencyDetailModel = function (Competency, index) {

    var selectedCompetencyDetail = createXHRRequest('detail', Competency, index);

  
    return selectedCompetencyDetail;

}