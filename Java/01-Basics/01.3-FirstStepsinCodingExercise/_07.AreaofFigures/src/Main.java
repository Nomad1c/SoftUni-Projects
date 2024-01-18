import java.util.Scanner;
 class GeometryCalculator {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String figureType = scanner.nextLine();

        double area = 0.0;

        switch (figureType) {
            case "square":
                double side = Double.parseDouble(scanner.nextLine());
                area = side * side;
                break;
            case "rectangle":
                double rectangleWidth = Double.parseDouble(scanner.nextLine());
                double rectangleHeight = Double.parseDouble(scanner.nextLine());
                area = rectangleWidth * rectangleHeight;
                break;
            case "circle":
                double radius = Double.parseDouble(scanner.nextLine());
                area = Math.PI * radius * radius;
                break;
            case "triangle":
                double triangleSide = Double.parseDouble(scanner.nextLine());
                double triangleHeight = Double.parseDouble(scanner.nextLine());
                area = (triangleSide * triangleHeight) / 2;
                break;
        }

        System.out.printf("%.3f%n", area);

        scanner.close();
    }
}
