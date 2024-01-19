function checkSpeed(speed) {
    let speedValue = Number(speed);

    if (speedValue <= 10) {
        console.log("slow");
    } else if (speedValue <= 50) {
        console.log("average");
    } else if (speedValue <= 150) {
        console.log("fast");
    } else if (speedValue <= 1000) {
        console.log("ultra fast");
    } else {
        console.log("extremely fast");
    }
}

checkSpeed("8");
checkSpeed("49.5");
checkSpeed("126");
checkSpeed("160");
checkSpeed("3500");
