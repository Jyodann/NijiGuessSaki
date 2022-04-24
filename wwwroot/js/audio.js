function loadAudio(element) {
    element.load()
}
function playAudio(element) {
    stopAudio(element);
    element.play();
}
function stopAudio(element) {
    element.pause();
    element.currentTime = 0;
}

function returnDuration(element) {
    return element.currentTime.toString()
}