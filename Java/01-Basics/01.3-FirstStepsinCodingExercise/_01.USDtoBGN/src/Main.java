import java.util.Scanner;

class USDtoBGNConverter {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double usdAmount = Double.parseDouble(scanner.nextLine());
        double exchangeRate = 1.79549;
        double bgnAmount = usdAmount * exchangeRate;

        System.out.printf("%.5f%n", bgnAmount);

        scanner.close();
    }
}
