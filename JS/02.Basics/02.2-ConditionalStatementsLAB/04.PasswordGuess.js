function checkPassword(password) {
    const correctPassword = "s3cr3t!P@ssw0rd";

    if (password == correctPassword) {
        console.log("Welcome");
    } else {
        console.log("Wrong password!");
    }
}

checkPassword("qwerty");
checkPassword("s3cr3t!P@ssw0rd");
checkPassword("s3cr3t!p@ss");
