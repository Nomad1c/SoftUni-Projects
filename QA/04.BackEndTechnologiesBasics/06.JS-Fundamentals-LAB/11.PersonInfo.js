function createPersonInfo(firstName, lastName, age) {
    const personInfo = {
        firstName: firstName,
        lastName: lastName,
        age: age
    };

    return personInfo;
}

const person1 = createPersonInfo("Peter", "Pan", "20");
console.log(person1);

const person2 = createPersonInfo("George", "Smith", "18");
console.log(person2);
