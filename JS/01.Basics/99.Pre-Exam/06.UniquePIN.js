const generateCombinations = (inputArray) => {
    const [max1, max2, max3] = inputArray.map(Number);
    const numMax = parseInt(`${max1}${max2}${max3}`);
  
    for (let i = 2; i <= max1; i += 2) {
      for (const j of [2, 3, 5, 7]) {
        if (j > max2) {
          break;
        }
        for (let k = 2; k <= max3; k += 2) {
          console.log(`${i} ${j} ${k}`);
        }
      }
    }
  };
  
  // Example usage:
  const inputArray = [8, 2, 8]; // Replace with your input array
  generateCombinations(inputArray);
  