function rotateArray(arr, rotations) {
    const length = arr.length;
    const actualRotations = rotations % length;

    const rotatedArray = arr.slice(actualRotations).concat(arr.slice(0, actualRotations));
    console.log(rotatedArray.join(' '));
}

rotateArray([51, 47, 32, 61, 21], 2);
rotateArray([32, 21, 61, 1], 4);
rotateArray([2, 4, 15, 31], 5);
