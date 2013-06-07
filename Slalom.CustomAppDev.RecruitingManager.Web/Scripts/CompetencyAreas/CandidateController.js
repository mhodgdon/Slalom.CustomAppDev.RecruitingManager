
var selectCandidateCntrl = function($scope) {

    $scope.candidates = [
    { name: 'Brendan Schoch', interviewedBy: 'Michael Bruyette, Larry Ficek, Eric Winton, Russell Norris', timesInterviewed: '4', Notes: 'Fire Immediately'},
    { name: 'Larry Ficek', interviewedBy: 'Unknown Larry has been here forever', timesInterviewed: '1', Notes: 'Send to NYC' },
    { name: 'Michael Hodgdon', interviewedBy: 'Rob Daigneu', timesInterviewed: '1', Notes: 'Stop Implementing Repeaters' }
  ];

    
    $scope.selectedCandidate = 'Please Select';


    $scope.addCandidates = function () {

        $scope.candidates.push({ name: $scope.candidateName, interviewedBy: 'Current User', timesInterviewed: '1', Notes: '' });
        var selectAddedCandidate = $scope.candidates.length - 1;
        $scope.selectedCandidate = $scope.candidates[selectAddedCandidate];

    };

}


var swipeTapped = function () {
       
    var currentHeight = $('#candidateCreator').css("height");
    if (currentHeight == '200px') {
        candidateSelectFormHeight = '75px';
    }
    else {
        candidateSelectFormHeight = '200px';

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