using TicketManagementSystem.Common.Entities;
using TicketManagementSystem.Domain.Repositories;

namespace TicketManagementSystem.Domain.Services.TicketServices
{
    public static class CreateTicketService
    {
        public static int Execute(Ticket ticket)
        {
            return TicketRepository.CreateTicket(ticket);
        }
    }
}
