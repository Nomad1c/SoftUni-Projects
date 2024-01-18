import java.util.Scanner;

class Aquarium {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int length = Integer.parseInt(scanner.nextLine());
        int width = Integer.parseInt(scanner.nextLine());
        int height = Integer.parseInt(scanner.nextLine());
        double percentOccupied = Double.parseDouble(scanner.nextLine());

        int aquariumVolume = length * width * height;
        double litersNeeded = aquariumVolume * 0.001 * (1 - percentOccupied / 100);

        System.out.println(litersNeeded);

        scanner.close();
    }
}
