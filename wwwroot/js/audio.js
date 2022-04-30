const soundEffect = new Audio()

function loadAudio(element, audioSource) {
    console.log(audioSource);
    element.src = audioSource;
    element.load()
}
function playAudio(element, startDuration) {
    element.currentTime = startDuration;
    element.play();
}
function stopAudio(element) {
    element.pause();
    element.currentTime = 0;
}

function setVolume(element, volume) {
    element.volume = volume;
}

function returnDuration(element) {
    return element.currentTime.toString()
}