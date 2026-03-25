namespace APBD3;

public class RentalService
{
    private readonly List<Rental> rentals = new List<Rental>();
    private const decimal DailyRate = 10.0m;

    public void Rent(User user, Sprzet item, int days)
    {
        if(!item.Dostepny)
            throw new InvalidOperationException("You cannot do that while dostepny");
        
        int active_count = rentals.Count(rental => rental.Borrower.Id == user.Id && rental.ReturnDate == null );
        if (active_count >= user.MaxRentalLimit)
            throw new InvalidOperationException("Przekroczyles limi wypozyczen");

        item.Dostepny = false;
        rentals.Add(new Rental
        {
            Borrower = user,
            Item = item,
            RentDate = DateTime.Now,
            DueDate = DateTime.Now.AddDays(days)
        });
        Console.WriteLine( "Wypozyczono " + item.Nazwa + "dla " + user.LastName);
    }

    public void Return(Sprzet item)
    {
        var rental = rentals.FirstOrDefault(rental => rental.Item.Id == item.Id);
        if (rental == null) throw new Exception("Wypozyczono  " + item.Nazwa);
        
        rental.ReturnDate = DateTime.Now;
        item.Dostepny = true;
        
        
        if (rental.ReturnDate > rental.DueDate)
        {
            int delaydays = (rental.ReturnDate.Value - rental.DueDate).Days;
            rental.Penalty = delaydays * DailyRate;
        }
        else
        {
            Console.WriteLine("Zwrocono w terminie");
        }
        
    }   
    public List<Rental> Overdue_rentals => rentals.OrderByDescending(rental => rental.ReturnDate == null && DateTime.Now > rental.DueDate).ToList();
    public List<Rental> GetUserRentals(string userId) => rentals.Where(rental => rental.Borrower.Id == userId && rental.ReturnDate == null ).ToList();    
}
    