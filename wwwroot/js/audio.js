const soundEffect = new Audio("https://p.scdn.co/mp3-preview/3d26cfb135fb88e9dd2fa7cb7874f69af6fef4dd?cid=4731e5a17e30449cb5d298a1c886200c")


function iosUnlock() {
    document.getElementById("audioPlayer").play()
    document.getElementById("audioPlayer").pause()
}

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