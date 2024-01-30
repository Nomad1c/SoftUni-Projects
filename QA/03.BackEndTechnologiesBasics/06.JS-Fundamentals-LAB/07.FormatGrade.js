function formatGrade(grade) {
    const roundedGrade = grade.toFixed(2);

    if (grade < 3.00) {
        console.log(`Fail (${Math.floor(grade)})`);
    } else if (grade < 3.50) {
        console.log(`Poor (${roundedGrade})`);
    } else if (grade < 4.50) {
        console.log(`Good (${roundedGrade})`);
    } else if (grade < 5.50) {
        console.log(`Very good (${roundedGrade})`);
    } else {
        console.log(`Excellent (${roundedGrade})`);
    }
}

formatGrade(3.33);
formatGrade(4.50);
formatGrade(2.99);
