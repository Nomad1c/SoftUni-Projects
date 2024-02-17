import java.util.Scanner;

class MyFirstProgram {
    public static void main(String[] args) {
        int height = 5364;
        int top = 8848;
        Scanner scanner = new Scanner(System.in);
        String inputString = scanner.nextLine();
        int up = Integer.parseInt(scanner.nextLine());
        int days = 1;

        while (true) {
            if (!inputString.equals("END")) {
                height += up;
            }

            if (inputString.equals("Yes")) {
                days++;
            }

            if (inputString.equals("END") || days >= 5 || height >= top) {
                break;
            }

            inputString = scanner.nextLine();

            if (!inputString.equals("END")) {
                up = Integer.parseInt(scanner.nextLine());
            }
        }

        if (top > height) {
            System.out.println("Failed!");
            System.out.println(height);
        } else {
            System.out.println("Goal reached for " + days + " days!");
        }

        scanner.close();
    }
}
