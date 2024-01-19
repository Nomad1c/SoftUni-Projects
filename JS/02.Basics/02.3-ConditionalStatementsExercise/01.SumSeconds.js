function sumSeconds(data) {
    let totalSeconds = data[0] + data[1] + data[2];
    let minutes = Math.floor(totalSeconds / 60);
    let seconds = totalSeconds % 60;

    let formattedMinutes = minutes < 10 ? `${minutes}` : `0${minutes}`;
    let formattedSeconds = seconds < 10 ? `0${seconds}` : `${seconds}`;

    console.log(`${formattedMinutes}:${formattedSeconds}`);
}

sumSeconds([35, 45, 44]);
sumSeconds([22, 7, 34]);
sumSeconds([50, 50, 49]);
sumSeconds([14, 12, 10]);
sumSeconds([50, 50, 49]);
sumSeconds([14, 12, 10])