import java.util.Scanner;

class SchoolSupplies {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int pencilsCount = Integer.parseInt(scanner.nextLine());
        int markersCount = Integer.parseInt(scanner.nextLine());
        double cleaningSolutionLiters = Double.parseDouble(scanner.nextLine());
        int discountPercent = Integer.parseInt(scanner.nextLine());

        double pencilsPrice = pencilsCount * 5.80;
        double markersPrice = markersCount * 7.20;
        double cleaningSolutionPrice = cleaningSolutionLiters * 1.20;
        double total = pencilsPrice + markersPrice + cleaningSolutionPrice;

        double discount = total * (discountPercent / 100.0);
        double finalPrice = total - discount;

        System.out.println(finalPrice);

        scanner.close();
    }
}
