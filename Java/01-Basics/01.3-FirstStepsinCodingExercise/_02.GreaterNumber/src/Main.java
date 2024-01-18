import java.util.Scanner;

class LargerNumber {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int firstNumber = Integer.parseInt(scanner.nextLine());
        int secondNumber = Integer.parseInt(scanner.nextLine());

        int largerNumber = Math.max(firstNumber, secondNumber);

        System.out.println(largerNumber);

        scanner.close();
    }
}
