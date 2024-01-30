function sortNumbers(arr) {
    const sortedArr = arr.sort((a, b) => a - b);
    const result = [];

    while (sortedArr.length > 0) {
        result.push(sortedArr.shift());
        if (sortedArr.length > 0) {
            result.push(sortedArr.pop());
        }
    }

    return result;
}

const inputArray = [1, 65, 3, 52, 48, 63, 31, -3, 18, 56];
const outputArray = sortNumbers(inputArray);
console.log(outputArray);
