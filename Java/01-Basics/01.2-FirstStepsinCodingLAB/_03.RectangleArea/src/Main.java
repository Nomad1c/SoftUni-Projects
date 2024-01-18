import java.util.Scanner;

class RectangleArea {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int a = scanner.nextInt();

        int b = scanner.nextInt();

        int area = a * b;

        // Извеждане на резултата
        System.out.println(area);

        scanner.close();
    }
}
