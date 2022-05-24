function countChar() {
    var count = document.getElementById("about-input").value.length;
    document.getElementById("current").innerHTML = count;
}

function checkBox() {
    var checkBox = document.getElementById("check");

    if (checkBox.checked) {
        document.getElementById('SalidaAnio').disabled = true;
        document.getElementById('SalidaMes').disabled = true;
    }
    else {
        document.getElementById('SalidaAnio').disabled = false;
        document.getElementById('SalidaMes').disabled = false;
    }
}

function addAbility() {
    var elem = document.getElementById('remover');
    elem.parentNode.removeChild(elem);

    var x = document.getElementById("addAbility");
    if (x.style.display === "none") {
        x.style.display = "flex";
    }

    var y = document.getElementById("last-button");
    if (y.style.display === "none") {
        y.style.display = "block";
    }

}

function addAbility2() {
    var elem = document.getElementById('last-button');
    elem.parentNode.removeChild(elem);

    var x = document.getElementById("addAbility2");
    if (x.style.display === "none") {
        x.style.display = "flex";
    }

}




