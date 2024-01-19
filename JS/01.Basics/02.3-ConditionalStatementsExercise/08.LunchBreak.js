function lunchBreak(arr) {
    let seriesName = arr[0];
    let episodeDuration = parseInt(arr[1]);
    let breakDuration = parseInt(arr[2]);

    let lunchTime = breakDuration * 1/8;
    let restTime = breakDuration * 1/4;
    let remainingTime = breakDuration - lunchTime - restTime;

    if (remainingTime >= episodeDuration) {
        let leftFreeTime = Math.ceil(remainingTime - episodeDuration);
        console.log(`You have enough time to watch ${seriesName} and left with ${leftFreeTime} minutes free time.`);
    } else {
        let neededTime = Math.ceil(episodeDuration - remainingTime);
        console.log(`You don't have enough time to watch ${seriesName}, you need ${neededTime} more minutes.`);
    }
}

lunchBreak(["Game of Thrones", "60", "96"]); 
lunchBreak(["Teen Wolf", "48", "60"]); 
