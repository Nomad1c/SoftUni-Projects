import java.util.Scanner;

class PetFoodCost {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int dogFoodCount = Integer.parseInt(scanner.nextLine());
        int catFoodCount = Integer.parseInt(scanner.nextLine());

        double dogFoodCost = dogFoodCount * 2.50;
        double catFoodCost = catFoodCount * 4.00;

        double totalCost = dogFoodCost + catFoodCost;

        System.out.printf("%.2f lv.%n", totalCost);

        scanner.close();
    }
}
