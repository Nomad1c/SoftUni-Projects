import java.util.Scanner;

class CharityEvent {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int dancers = Integer.parseInt(scanner.nextLine());
        double points = Double.parseDouble(scanner.nextLine());
        String season = scanner.nextLine().toLowerCase();
        String location = scanner.nextLine().toLowerCase();

        double totalMoney = dancers * points;

        if (location.equals("abroad")) {
            totalMoney += 0.5 * totalMoney;
        }

        double expensesPercentage = 0.0;

        if (season.equals("summer") && location.equals("bulgaria")) {
            expensesPercentage = 0.05;
        } else if (season.equals("winter") && location.equals("bulgaria")) {
            expensesPercentage = 0.08;
        } else if (season.equals("summer") && location.equals("abroad")) {
            expensesPercentage = 0.1;
        } else if (season.equals("winter") && location.equals("abroad")) {
            expensesPercentage = 0.15;
        }

        double afterExpenses = totalMoney - (totalMoney * expensesPercentage);
        double charityMoney = 0.75 * afterExpenses;
        double remainingMoney = afterExpenses - charityMoney;

        double moneyPerDancer = remainingMoney / dancers;

        System.out.printf("Charity - %.2f%n", charityMoney);
        System.out.printf("Money per dancer - %.2f%n", moneyPerDancer);
    }
}
