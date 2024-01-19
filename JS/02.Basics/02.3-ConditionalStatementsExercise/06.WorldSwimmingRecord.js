function swimmingRecord(data) {
    
    let record = Number(data[0]);
    let distance = Number(data[1]);
    let timePerMeter = Number(data[2]);

    
    record = parseFloat(record);
    distance = parseFloat(distance);
    timePerMeter = parseFloat(timePerMeter);

    let resistance = Math.floor(distance / 15) * 12.5;
    let totalTime = (distance * timePerMeter) + resistance;

    if (totalTime < record) {
        console.log(`Yes, he succeeded! The new world record is ${totalTime.toFixed(2)} seconds.`);
    } else {
        let timeDifference = totalTime - record;
        console.log(`No, he failed! He was ${timeDifference.toFixed(2)} seconds slower.`);
    }
}

swimmingRecord((["10464",
"1500",
"20"])
);
swimmingRecord((["55555.67",
"3017",
"5.03"])
);
