using System;

class Program {
    public static void Main(string[] args) {
        Console.Write("Enter the wind speed (in miles per hour): ");
        if (double.TryParse(Console.ReadLine(), out double windSpeed)) {
            string category = CategorizeHurricane(windSpeed);
            Console.WriteLine(category);
        } else {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    static string CategorizeHurricane(double windSpeed) {
        if (windSpeed >= 157.0) {
            return "Category Five Hurricane";
        } else if (windSpeed >= 130.0) {
            return "Category Four Hurricane";
        } else if (windSpeed >= 111.0) {
            return "Category Three Hurricane";
        } else if (windSpeed >= 96.0) {
            return "Category Two Hurricane";
        } else if (windSpeed >= 74.0) {
            return "Category One Hurricane";
        } else {
            return "Not a Hurricane";
        }
    }
}
