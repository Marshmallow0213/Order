document.addEventListener("DOMContentLoaded", function () {
    var box = document.getElementById("box");
    var box = document.getElementById("BG");
    var content = document.getElementById("content");
    box.style.animation = "spin 1.5s linear";
    box.addEventListener("animationend", function () {
        box.style.display = "none";
        BG.style.display = "none";
        content.style.display = "block";
    });
});
