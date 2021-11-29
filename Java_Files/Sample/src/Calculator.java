import java.util.Scanner;

public class Calculator {
    private Scanner scanner = new Scanner(System.in);
    private int choice;
    private int a;
    private int b;

    public Calculator() {
        System.out.println("Hey I am a calculator");
        AskForChoice();
        while (choice > 4) {
            System.out.println("No Such Index \n");
            AskForChoice();
            if (choice < 5) {
                Choice(choice);
                break;
            }
        }
        scanner.close();
    }

    private void AskForChoice() {
        System.out.println("Choose any One number corresponding to required choice");
        System.out.println("1: Addition \n 2:Subtraction \n 3:Multiplication \n 4:Division");
        choice = scanner.nextInt();
    }


    private void Choice(int choice) {
        switch (choice) {
            case 1:
                System.out.println("Select Any two numbers for addition");
                a = scanner.nextInt();
                b = scanner.nextInt();
                System.out.println("The Addition of given numbers is : " + Add(a, b));
                break;
            case 2:
                System.out.println("Select Any two numbers for Subtraction");
                a = scanner.nextInt();
                b = scanner.nextInt();
                System.out.println("The Subtraction of given numbers is : " + Subtract(a, b));
                break;
            case 3:
                System.out.println("Select Any two numbers for Multiplication");
                a = scanner.nextInt();
                b = scanner.nextInt();
                System.out.println("The Multiplication of given numbers is : " + Multiply(a, b));
                break;
            case 4:
                System.out.println("Select Any two numbers for Division");
                a = scanner.nextInt();
                b = scanner.nextInt();
                System.out.println("The Division of given numbers is : " + Divide(a, b));
                break;
        }
    }

    private int Add(int a, int b) {
        return a + b;
    }

    private int Multiply(int a, int b) {
        return a * b;
    }

    private int Divide(int a, int b) {
        return a / b;
    }

    private int Subtract(int a, int b) {
        return a - b;
    }
}
