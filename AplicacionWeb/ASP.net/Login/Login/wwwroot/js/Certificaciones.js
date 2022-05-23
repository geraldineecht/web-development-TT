var i = 0;
var original = document.getElementById('duplicater');
var elem = document.getElementById('remover');

function duplicate() {
    var clone = original.cloneNode(true); // "deep" clone
    clone.id = "duplicater" + ++i;
    if (i < 8) {
        original.parentNode.insertBefore(clone, original.nextSibling);
    }

    if (i >= 7) {
        elem.parentNode.removeChild(elem);
    }

}