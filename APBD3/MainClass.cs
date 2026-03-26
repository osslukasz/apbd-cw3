namespace APBD3;

public class MainClass
{
    static void Main()
    {
        var service = new RentalService();
        
        
        var laptop = new Laptop("Dell XPS", "i7", "RTX 1050");
        var camera = new Camera ( "Aparat profesjonalny", "Canon EOS", "4K" );
        var student = new Student("Jan", "Kowalski");
        var employee = new Employee("Dr", "Nowak");

        Console.WriteLine("--- SCENARIUSZ 1: Poprawne wypożyczenie ---");
        service.Rent(student, laptop, 7); // [cite: 74]

        Console.WriteLine("\n--- SCENARIUSZ 2: Próba wypożyczenia niedostępnego ---");
        try {
            service.Rent(employee, laptop, 5); // [cite: 75]
        } catch (Exception e) { Console.WriteLine($"Błąd: {e.Message}"); }

        Console.WriteLine("\n--- SCENARIUSZ 3: Przekroczenie limitu studenta ---");
        var p1 = new Projector("projektor 1","Epson", "HD");
        var p2 = new Projector(" projektor 2","BenQ", "4K");
        service.Rent(student, p1, 7);
        try {
            service.Rent(student, p2, 7); // [cite: 76]
        } catch (Exception e) { Console.WriteLine($"Błąd: {e.Message}"); }

        Console.WriteLine("\n--- SCENARIUSZ 4: Zwrot w terminie ---");
        service.Return(laptop); // [cite: 77]

        Console.WriteLine("\n--- RAPORT KOŃCOWY ---");
        Console.WriteLine($"Dostępność laptopa po zwrocie: {laptop.Dostepny}"); // [cite: 79]
    }
}