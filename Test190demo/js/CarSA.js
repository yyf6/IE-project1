function changeStyle1() {
    var nameValue = document.getElementById("Name").value;
    if (nameValue.length != 0) {
        document.getElementById("Name").style.borderColor = "forestgreen";
    }
    else {
        document.getElementById("Name").style.borderColor = "";
    }
}


function changeStatus(){
    var carCondition = document.getElementsByName("CarStatus");
    var Uphol = document.getElementsByName("Q2");
    var car;
    for (var i = 0; i < carCondition.length; i++) {
        if (carCondition[i].value != "0") {
            Uphol[0].style.display = "initial";
        }
        else {
            Uphol[0].style.display = "none";
        }
    }
}

function showSelectValue() {
    var carCondition = document.getElementsByName("CarStatus");
    var Uphol = document.getElementsByName("UpholsteryChanging");
    if (carCondition.value == "New") {
        Uphol.style.display = "none";
    }


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

        