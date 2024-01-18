import java.util.Scanner;

class PasswordGuess {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String inputPassword = scanner.nextLine();
        String correctPassword = "s3cr3t!P@ssw0rd";

        if (inputPassword.equals(correctPassword)) {
            System.out.println("Welcome");
        } else {
            System.out.println("Wrong password!");
        }

        scanner.close();
    }
}
