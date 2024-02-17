import java.util.Scanner;

class BacheloretteParty {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double partyPrice = Double.parseDouble(scanner.nextLine());
        int loveMessages = Integer.parseInt(scanner.nextLine());
        int waxRoses = Integer.parseInt(scanner.nextLine());
        int keychains = Integer.parseInt(scanner.nextLine());
        int caricatures = Integer.parseInt(scanner.nextLine());
        int luckySurprises = Integer.parseInt(scanner.nextLine());

        double totalSum = loveMessages * 0.60 + waxRoses * 7.20 + keychains * 3.60
                + caricatures * 18.20 + luckySurprises * 22.0;

        int totalItems = loveMessages + waxRoses + keychains + caricatures + luckySurprises;

        if (totalItems >= 25) {
            totalSum *= 0.65; // apply 35% discount
        }

        double hostingCost = totalSum * 0.10;
        totalSum -= hostingCost;

        if (totalSum >= partyPrice) {
            double remainingMoney = totalSum - partyPrice;
            System.out.printf("Yes! %.2f lv left.%n", remainingMoney);
        } else {
            double neededMoney = partyPrice - totalSum;
            System.out.printf("Not enough money! %.2f lv needed.%n", neededMoney);
        }
    }
}
