import java.util.Scanner;

class InchesToCentimetersConverter {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double inches = scanner.nextDouble();
        double centimeters = inches * 2.54;
        System.out.println(centimeters);
        scanner.close();
    }
}
