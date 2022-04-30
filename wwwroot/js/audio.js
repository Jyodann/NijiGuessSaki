function loadAudio(audioSource) {
    document.getElementById("audioPlayer").src = audioSource
    document.getElementById("audioPlayer").load()
}
function playAudio(startDuration) {
    document.getElementById("audioPlayer").currentTime = startDuration;
    document.getElementById("audioPlayer").play();
}
function stopAudio() {
    document.getElementById("audioPlayer").pause();
    document.getElementById("audioPlayer").currentTime = 0;
}

function setVolume(volume) {
    document.getElementById("audioPlayer").volume = volume;
}

function returnDuration() {
    return document.getElementById("audioPlayer").currentTime.toString()
}