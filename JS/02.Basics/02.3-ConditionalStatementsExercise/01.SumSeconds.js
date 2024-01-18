function sumSeconds(sec1, sec2, sec3) {
    let totalSeconds = sec1 + sec2 + sec3;
    let minutes = Math.floor(totalSeconds / 60);
    let seconds = totalSeconds % 60;

    let formattedMinutes = minutes < 10 ? `0${minutes}` : `${minutes}`;
    let formattedSeconds = seconds < 10 ? `0${seconds}` : `${seconds}`;

    return `${formattedMinutes}:${formattedSeconds}`;
}

console.log(sumSeconds(35, 45, 44));
console.log(sumSeconds(22, 7, 34));
console.log(sumSeconds(50, 50, 49));
console.log(sumSeconds(14, 12, 10));
