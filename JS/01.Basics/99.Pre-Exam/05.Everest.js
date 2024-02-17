function mountainClimbing(inputArray) {
    let height = 5364;
    const top = 8848;
    let inputIndex = 0;
    let inputString = inputArray[inputIndex++];
    let up = parseInt(inputArray[inputIndex++]);
    let days = 1;

    while (true) {
        if (inputString !== "END") {
            height += up;
        }

        if (inputString === "Yes") {
            days++;
        }

        if (inputString === "END" || days >= 5 || height >= top) {
            break;
        }

        inputString = inputArray[inputIndex++];

        if (inputString !== "END") {
            up = parseInt(inputArray[inputIndex++]);
        }
    }

    if (top > height) {
        console.log("Failed!");
        console.log(height);
    } else {
        console.log(`Goal reached for ${days} days!`);
    }
}

// Example usage:
const inputArray = ["Yes", "100", "No", "50", "Yes", "200", "END"];
mountainClimbing(inputArray);
