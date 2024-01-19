function calculateAquariumVolume(data) {
    const aquariumVolume = (data[0] * data[1] * data[2]) / 1000;
    const occupiedSpace = data[3] / 100;
    const neededLiters = aquariumVolume * (1 - occupiedSpace);

    console.log(neededLiters);
}

calculateAquariumVolume([85, 75, 47, 17]);
calculateAquariumVolume([105, 77, 89, 18.5]);
