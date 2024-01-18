import java.util.Scanner;

class BasketballEquipment {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int annualFee = Integer.parseInt(scanner.nextLine());

        double sneakersPrice = annualFee - 0.4 * annualFee;
        double outfitPrice = sneakersPrice - 0.2 * sneakersPrice;
        double ballPrice = 0.25 * outfitPrice;
        double accessoriesPrice = 0.2 * ballPrice;

        double totalCost = annualFee + sneakersPrice + outfitPrice + ballPrice + accessoriesPrice;

        System.out.println(totalCost);

        scanner.close();
    }
}
