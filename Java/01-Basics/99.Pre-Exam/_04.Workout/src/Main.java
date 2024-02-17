import java.util.Scanner;

class RunningTraining {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int days = Integer.parseInt(scanner.nextLine());
        double initialDistance = Double.parseDouble(scanner.nextLine());
        double totalDistance = initialDistance;

        for (int i = 0; i < days; i++) {
            int increasePercentage = Integer.parseInt(scanner.nextLine());
            initialDistance += (increasePercentage / 100.0) * initialDistance;
            totalDistance += initialDistance;
        }

        double one = Math.ceil(totalDistance - 1000);
        double two = Math.ceil(1000 - totalDistance);

        if (totalDistance >= 1000) {
            System.out.printf("You've done a great job running %.0f more kilometers!%n", one);
        } else {
            System.out.printf("Sorry Mrs. Ivanova, you need to run %.0f more kilometers%n", two);
        }
    }
}
