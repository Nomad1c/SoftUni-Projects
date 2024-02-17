import java.util.Scanner;

class CatDiet {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        int fatPercentage = Integer.parseInt(scanner.nextLine());
        int proteinPercentage = Integer.parseInt(scanner.nextLine());
        int carbohydratePercentage = Integer.parseInt(scanner.nextLine());
        int totalCalories = Integer.parseInt(scanner.nextLine());
        int waterPercentage = Integer.parseInt(scanner.nextLine());

        double fatGrams = (fatPercentage / 100.0) * totalCalories / 9;
        double proteinGrams = (proteinPercentage / 100.0) * totalCalories / 4;
        double carbohydrateGrams = (carbohydratePercentage / 100.0) * totalCalories / 4;

        double totalWeight = fatGrams + proteinGrams + carbohydrateGrams;

        double waterCalories = (waterPercentage / 100.0) * totalCalories;
        double caloriesPerGram = totalCalories / totalWeight;
        double caloriesPerGramWithoutWater = caloriesPerGram - (waterCalories / totalWeight);

        System.out.printf("%.4f%n", caloriesPerGramWithoutWater);
    }
}
