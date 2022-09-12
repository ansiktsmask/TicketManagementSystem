using TicketManagementSystem.Common.Exceptions;
using TicketManagementSystem.Domain.Repositories;

namespace TicketManagementSystem.Application.TicketCommands.AssignTicket
{
    public class AssignTicketRules
    {
        public void Validate(int id, string username)
        {
            using (var userRepository = new UserRepository())
            {
                if (string.IsNullOrEmpty(username) || userRepository.GetUser(username) == null)
                {
                    throw new UnknownUserException("User not found");
                }
            }

            var ticket = TicketRepository.GetTicket(id);

            if (ticket == null)
            {
                throw new ApplicationException("No ticket found for id " + id);
            }
        }
    }
}
