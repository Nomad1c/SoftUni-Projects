function calculateArea(data) {
    let area = 0;

    switch (data[0]) {
        case "square":
            area = data[1] * data[1];
            break;
        case "rectangle":
            area = data[1] * data[2];
            break;
        case "circle":
            area = Math.PI * data[1] * data[1];
            break;
        case "triangle":
            area = (data[1] * data[2]) / 2;
            break;
    }

    return area.toFixed(3);
}

console.log(calculateArea(["square", 5]));
console.log(calculateArea(["rectangle", 7, 2.5]));
console.log(calculateArea(["circle", 6]));
console.log(calculateArea(["triangle", 4.5, 20]));
