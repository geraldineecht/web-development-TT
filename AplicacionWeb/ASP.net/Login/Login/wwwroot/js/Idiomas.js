var i = 0;
var original = document.getElementById('duplicater');
var elem = document.getElementById('remover');

function duplicate() {
    var clone = original.cloneNode(true); // "deep" clone
    clone.id = "duplicater" + ++i;
    if (i < 7) {
        original.parentNode.insertBefore(clone, original.nextSibling);
    }

    if (i >= 6) {
        elem.parentNode.removeChild(elem);
    }

}