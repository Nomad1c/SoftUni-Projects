function calculateAquariumVolume(length, width, height, percentage) {
    const aquariumVolume = (length * width * height) / 1000;
    const occupiedSpace = percentage / 100;
    const neededLiters = aquariumVolume * (1 - occupiedSpace);

    console.log(neededLiters);
}

calculateAquariumVolume(85, 75, 47, 17);
calculateAquariumVolume(105, 77, 89, 18.5);
