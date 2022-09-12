using TicketManagementSystem.Common.Entities;
using TicketManagementSystem.Common.Enums;

namespace TicketManagementSystem.Application.TicketCommands.CreateTicket
{
    public static class CreateTicketMapper
    {
        public static Ticket Execute(string title, TicketPriority priority, string assignedTo, string description, DateTime createDate, User assignedUser)
        {
            return new Ticket
            {
                Title = title,
                AssignedUser = assignedUser,
                Priority = priority,
                Description = description,
                Created = createDate
            };
        }
    }
}
