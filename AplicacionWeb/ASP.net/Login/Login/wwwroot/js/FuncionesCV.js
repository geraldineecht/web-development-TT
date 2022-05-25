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
    var z = document.getElementById("habilidad");
    if (x.style.display === "none") {
        x.style.display = "flex";
    }

    var y = document.getElementById("last-button");
    if (y.style.display === "none") {
        y.style.display = "block";
    }

    var addAbility = document.getElementById("habilidad-5")
    addAbility.style.display = "";

    var addAbility = document.getElementById("habilidad-6")
    addAbility.style.display = "";

}

function addAbility2() {
    var elem = document.getElementById('last-button');
    elem.parentNode.removeChild(elem);

    var x = document.getElementById("addAbility2");
    if (x.style.display === "none") {
        x.style.display = "flex";
    }

    var addAbility = document.getElementById("habilidad-7")
    addAbility.style.display = "";

    var addAbility = document.getElementById("habilidad-8")
    addAbility.style.display = "";


}

function habilidades() {
    var elem = document.getElementById("page1");
    elem.parentNode.removeChild(elem);

    var x = document.getElementById("page2");
    x.style.display = "";



}






