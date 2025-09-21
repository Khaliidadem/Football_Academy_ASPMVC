namespace Football_Academy_ASPMVC.Models
{
    public class Subscription
    {
       
        
            public int Id { get; set; }
            public int PlayerId { get; set; }
            public virtual Player Player { get; set; }

            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public decimal Amount { get; set; }
            public string Status { get; set; } // Paid or Unpaid
        
    }
}
