function printCityInfo(city) {
    for (let key in city) {
        console.log(`${key} -> ${city[key]}`);
    }
}

const city1 = {
    name: "Sofia",
    area: 492,
    population: 1238438,
    country: "Bulgaria",
    postCode: "1000"
};
printCityInfo(city1);

const city2 = {
    name: "Plovdiv",
    area: 389,
    population: 1162358,
    country: "Bulgaria",
    postCode: "4000"
};
printCityInfo(city2);
