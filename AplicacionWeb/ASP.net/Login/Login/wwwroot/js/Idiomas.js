
function addIdioma3() {
    var elem = document.getElementById('remover');
    elem.parentNode.removeChild(elem);

    var x = document.getElementById("addLanguage3");
    if (x.style.display === "none") {
        x.style.display = "";
    }

}