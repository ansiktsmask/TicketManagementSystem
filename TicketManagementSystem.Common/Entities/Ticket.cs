using TicketManagementSystem.Common.Enums;

namespace TicketManagementSystem.Common.Entities
{
    public class Ticket
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public TicketPriority Priority { get; set; }

        public string Description { get; set; } = string.Empty;

        public User AssignedUser { get; set; } = new User();

        public User? AccountManager { get; set; }

        public DateTime Created { get; set; }

        public double PriceDollars { get; set; }
    }
}
