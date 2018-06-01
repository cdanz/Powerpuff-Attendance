// JavaScript Code for the StudentDashboard page

window.onload = function () {
    var studentCards = document.getElementsByClassName('check-in');
    
    for (let i = 0; i < studentCards.length; i++) {
        var studentCard = studentCards[i];
        studentCard.onclick = function () {
            let sID = "stu" + (i + 1);
            let stuId = document.getElementById(sID);
            let classtoHide = ".emoticon" + (i + 1)
            $(classtoHide).toggleClass("active");
        }
    }
}


function checkedIn() {
    var checkInTime = new Date().toLocaleTimeString();
    alert("Thank you for checking in today. Check in time: " + checkInTime);
}



