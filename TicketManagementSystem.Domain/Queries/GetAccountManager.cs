
using TicketManagementSystem.Common.Entities;
using TicketManagementSystem.Domain.Repositories;

namespace TicketManagementSystem.Domain.Queries
{
    public class GetAccountManager
    {
        public User Execute()
        {
            var userRepository = new UserRepository();

            return userRepository.GetUser("Sarah");
        }
    }
}
