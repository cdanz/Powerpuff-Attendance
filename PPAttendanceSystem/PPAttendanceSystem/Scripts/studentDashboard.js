// JavaScript Code for the StudentDashboard page

// Check-in & check-out notifications will hide after a period
$('#check-out-alert').hide();
$('#check-in-alert').hide();

// Expands student profile card data on click
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

// Green check mark replaces student avatar on check-in
function checkedIn(imgSrc, stuID) {
    var avatar = document.createElement('img');
    avatar.setAttribute("src", imgSrc);
    avatar.setAttribute("alt", "Student Avatar");
    avatar.setAttribute("class", "img-circle");
    var checkMark = document.createElement('img');
    checkMark.setAttribute("src", "/Content/AvatarIcons/check.png");
    checkMark.setAttribute("alt", "Check Mark");
    checkMark.setAttribute("class", "img-circle");



    var imgElement = document.getElementById(stuID).getElementsByTagName("img")[0];
    var elementID = document.getElementById(stuID);
    var imgSource = imgElement.getAttribute("src");
    var checkInTime = new Date().toLocaleTimeString();

	// Check-in or check-out message will appear based on if profile was already checked in or not
    if (imgSrc === imgSource) {
        elementID.insertBefore(checkMark, elementID.firstChild);
        $(imgElement).remove();
        $("#check-in-alert").fadeTo(2000, 500).slideUp(500, function () {
            $("#check-in-alert").slideUp(500);
        });
    }
    else {
        elementID.insertBefore(avatar, elementID.firstChild);
        $(imgElement).remove();
        $("#check-out-alert").fadeTo(2000, 500).slideUp(500, function () {
            $("#check-out-alert").slideUp(500);
        });
    }
}



