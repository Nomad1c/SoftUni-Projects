import java.util.Scanner;

class SummerReading {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int pagesPerBook = Integer.parseInt(scanner.nextLine());
        int pagesPerHour = Integer.parseInt(scanner.nextLine());
        int daysToRead = Integer.parseInt(scanner.nextLine());

        int totalReadingTime = pagesPerBook / pagesPerHour;
        int hoursPerDay = totalReadingTime / daysToRead;

        System.out.println(hoursPerDay);

        scanner.close();
    }
}
