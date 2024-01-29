function generateEmployeeList(employees) {
    const employeeList = {};

    for (let employee of employees) {
        const name = employee;
        const personalNum = name.replace(/\s/g, '').length + 1;
        employeeList[name] = personalNum;
    }

    for (let name in employeeList) {
        console.log(`Name: ${name} -- Personal Number: ${employeeList[name]}`);
    }
}

const employees1 = [
    'Silas Butler',
    'Adnaan Buckley',
    'Juan Peterson',
    'Brendan Villarreal'
];
generateEmployeeList(employees1);

const employees2 = [
    'Samuel Jackson',
    'Will Smith',
    'Bruce Willis',
    'Tom Holland'
];
generateEmployeeList(employees2);
