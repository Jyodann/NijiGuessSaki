const audioPlayer = null;

window.onload = (event) => {
    audioPlayer = document.getElementById("audioPlayer")
}

function iosUnlock() {
    audioPlayer.play()
    audioPlayer.pause()

    document.getElementById("iosUnlock").disabled = true;
}

function loadAudio(audioSource) {
    audioPlayer.src = audioSource
    audioPlayer.load()
}
function playAudio(startDuration) {
    audioPlayer.currentTime = startDuration;
    audioPlayer.play();
}
function stopAudio() {
    audioPlayer.pause();
    audioPlayer.currentTime = 0;
}

function setVolume(volume) {
    audioPlayer.volume = volume;
}

function returnDuration() {
    return audioPlayer.currentTime.toString()
}