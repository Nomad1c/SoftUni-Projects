import java.util.Scanner;

class FoodDelivery {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int chickenMenus = Integer.parseInt(scanner.nextLine());
        int fishMenus = Integer.parseInt(scanner.nextLine());
        int vegetarianMenus = Integer.parseInt(scanner.nextLine());

        double chickenMenuPrice = chickenMenus * 10.35;
        double fishMenuPrice = fishMenus * 12.40;
        double vegetarianMenuPrice = vegetarianMenus * 8.15;

        double totalMenuPrice = chickenMenuPrice + fishMenuPrice + vegetarianMenuPrice;
        double dessertPrice = 0.20 * totalMenuPrice;
        double deliveryPrice = 2.50;

        double totalOrderPrice = totalMenuPrice + dessertPrice + deliveryPrice;

        System.out.println(totalOrderPrice);

        scanner.close();
    }
}
