namespace APBD3;

public class Rental
{
    public User Borrower { get; set; }
    public Sprzet Item { get; set; }
    public DateTime RentDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    public DateTime DueDate { get; set; }
    public decimal Penalty { get; set; }
}