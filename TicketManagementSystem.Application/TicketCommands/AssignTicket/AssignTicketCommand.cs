using TicketManagementSystem.Common.Entities;
using TicketManagementSystem.Domain.Repositories;
using TicketManagementSystem.Domain.Services.TicketServices;

namespace TicketManagementSystem.Application.TicketCommands.AssignTicket
{
    public class AssignTicketCommand
    {
        public void Execute(int id, string username)
        {
            new AssignTicketRules().Validate(id, username);
            
            User user = new UserRepository().GetUser(username);

            var ticket = TicketRepository.GetTicket(id);

            ticket.AssignedUser = user;

            UpdateTicketService.Execute(ticket);
        }
    }
}
