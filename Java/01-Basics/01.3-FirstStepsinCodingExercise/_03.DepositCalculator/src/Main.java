import java.util.Scanner;

class DepositCalculator {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double depositedAmount = Double.parseDouble(scanner.nextLine());
        int depositTermMonths = Integer.parseInt(scanner.nextLine());
        double annualInterestRate = Double.parseDouble(scanner.nextLine());

        double interest = depositedAmount * (annualInterestRate / 100);
        double monthlyInterest = interest / 12;
        double totalAmount = depositedAmount + depositTermMonths * monthlyInterest;

        System.out.printf("%.2f%n", totalAmount);

        scanner.close();
    }
}
