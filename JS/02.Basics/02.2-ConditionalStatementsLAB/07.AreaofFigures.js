function calculateArea(figure, param1, param2) {
    let area = 0;

    switch (figure) {
        case "square":
            area = param1 * param1;
            break;
        case "rectangle":
            area = param1 * param2;
            break;
        case "circle":
            area = Math.PI * param1 * param1;
            break;
        case "triangle":
            area = (param1 * param2) / 2;
            break;
    }

    return area.toFixed(3);
}

console.log(calculateArea("square", 5));
console.log(calculateArea("rectangle", 7, 2.5));
console.log(calculateArea("circle", 6));
console.log(calculateArea("triangle", 4.5, 20));
