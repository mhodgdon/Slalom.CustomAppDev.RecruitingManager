
var selectCandidateCntrl = function($scope) {

    $scope.candidates = [
    {  name: 'Brendan Schoch',
       timesInterviewed: '4',
       interviewedBy: ['Michael Bruyette', 'Larry Ficek', 'Eric Winton', 'Russell Norris'],
       Notes: ['He is ok', 'Potentially ok', 'Will do', 'Ok']
     },
    { name: 'Larry Ficek',
      interviewedBy: ['Unknown Larry has been here forever'], 
      timesInterviewed: '1', Notes: ['hire'] },
    { name: 'Michael Hodgdon', interviewedBy: ['Rob Daigneu'], timesInterviewed: '1', Notes: ['hire'] }
  ];

    
    $scope.selectedCandidate = 'Please Select';


    $scope.addCandidates = function () {

        $scope.candidates.push({ name: $scope.candidateName, interviewedBy: ['Current User'], timesInterviewed: '1', Notes: ['']});
        var selectAddedCandidate = $scope.candidates.length - 1;
        $scope.selectedCandidate = $scope.candidates[selectAddedCandidate];
        $('#addCandidateModal').hide();

    };

}


var swipeTapped = function () {
       
    var currentHeight = $('#candidateCreator').css("height");
    if (currentHeight == '325px') {
        candidateSelectFormHeight = '75px';
    }
    else {
        candidateSelectFormHeight = '325px';

    }

    $('#candidateCreator').animate({
        height: candidateSelectFormHeight
    }, 300, function () {
        if (currentHeight == '75px') {
            $('#formContainer').show();
        }
        else {
            $('#formContainer').hide();
        }


    });

}