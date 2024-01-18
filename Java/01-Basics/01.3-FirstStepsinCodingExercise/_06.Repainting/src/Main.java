import java.util.Scanner;

class Painting {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int nylonSquareMeters = Integer.parseInt(scanner.nextLine());
        int paintLiters = Integer.parseInt(scanner.nextLine());
        int thinnerLiters = Integer.parseInt(scanner.nextLine());
        int hoursOfWork = Integer.parseInt(scanner.nextLine());

        double nylonPrice = (nylonSquareMeters + 2) * 1.50;
        double paintPrice = (paintLiters + paintLiters * 0.10) * 14.50;
        double thinnerPrice = thinnerLiters * 5.00;
        double bagsPrice = 0.40;

        double totalMaterialsCost = nylonPrice + paintPrice + thinnerPrice + bagsPrice;
        double laborCost = (totalMaterialsCost * 0.30) * hoursOfWork;

        double totalCost = totalMaterialsCost + laborCost;

        System.out.printf("%.2f%n", totalCost);

        scanner.close();
    }
}
