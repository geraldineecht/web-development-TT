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