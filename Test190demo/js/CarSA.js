function changeStyle1() {
    var nameValue = document.getElementById("Name").value;
    if (nameValue.length != 0) {
        document.getElementById("Name").style.borderColor = "forestgreen";
    }
    else {
        document.getElementById("Name").style.borderColor = "";
    }
}

function showSelectValue() {
    var radio = document.getElementsByName("radio");
    var question1 = document.getElementsByName("inlineRadioOptions");
    var q1 = document.getElementsByName("Q1");
    var value;
    for (i = 0; i < radio.length; i++) {
        if (radio[i].checked) {
            value = radio[i].value;
            break;
        }
    }
    if (value == "111") {
        for (var i = 0; i < question1.length; i++) {
            question1[i].style.display = "none";
        }
        for (var i = 0; i < q1.length; i++) {
            q1[i].style.display = "none";
        }
    }
}

        