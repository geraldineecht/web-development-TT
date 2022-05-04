
ta.addEventListener("input", function (e) {
    count.innerHTML = this.value.length;
});


function countChar() {
    var count = document.getElementById("about-input").value.length;
    document.getElementById("current").innerHTML = count;
} 