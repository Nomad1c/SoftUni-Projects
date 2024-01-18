import java.util.Scanner;

class LandscapingCost {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double squareMeters = Double.parseDouble(scanner.nextLine());
        double pricePerSquareMeter = 7.61;
        double totalPrice = squareMeters * pricePerSquareMeter;
        double discount = 0.18 * totalPrice;
        double finalPrice = totalPrice - discount;

        System.out.printf("The final price is: %.2f lv.%n", finalPrice);
        System.out.printf("The discount is: %.2f lv.%n", discount);

        scanner.close();
    }
}
