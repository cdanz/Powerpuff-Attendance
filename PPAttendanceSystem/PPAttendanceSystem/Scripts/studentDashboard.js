// JavaScript Code for the StudentDashboard page
window.onload = function () {
    var studentCards = document.getElementsByClassName('check-in');
    for (let i = 0; i < studentCards.length; i++) {
        var studentCard = studentCards[i];
        studentCard.onclick = function () {
            let sID = "stu" + (i + 1);
            let stuId = document.getElementById(sID);
            $(".student-card-info > img").remove();
            $(".student-card-info span").remove();
            $(".student-card-info").prepend(stuId.innerHTML);
            $(".check-in-popup").addClass("active");
        }
    }
}


function checkedIn() {
    var checkInTime = new Date().toLocaleTimeString();
    alert("Thank you for checking in today. Check in time: " + checkInTime);
    $(".student-card-info > img").remove();
    $(".student-card-info span").remove();
    $(".check-in-popup").removeClass("active");
}



