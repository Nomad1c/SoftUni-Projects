import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int max1 = scanner.nextInt();  // even
        int max2 = scanner.nextInt();  // 2,3,5,7
        int max3 = scanner.nextInt();  // even

        generateCombinations(max1, max2, max3);
    }

    public static void generateCombinations(int a, int b, int c) {
        int numMax = Integer.parseInt(String.valueOf(a) + String.valueOf(b) + String.valueOf(c));

        for (int i = 2; i <= a; i += 2) {
            for (int j : new int[]{2, 3, 5, 7}) {
                if (j > b) {
                    break;
                }
                for (int k = 2; k <= c; k += 2) {
                    System.out.println(i + " " + j + " " + k);
                }
            }
        }
    }
}
