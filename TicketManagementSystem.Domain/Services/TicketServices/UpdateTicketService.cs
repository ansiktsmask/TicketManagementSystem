using TicketManagementSystem.Common.Entities;
using TicketManagementSystem.Domain.Repositories;

namespace TicketManagementSystem.Domain.Services.TicketServices
{
    public static class UpdateTicketService
    {
        public static void Execute(Ticket ticket) 
        {
            TicketRepository.UpdateTicket(ticket);
        }
    }
}
