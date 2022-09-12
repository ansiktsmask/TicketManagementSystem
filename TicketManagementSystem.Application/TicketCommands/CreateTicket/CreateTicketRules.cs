using TicketManagementSystem.Common.Enums;
using TicketManagementSystem.Common.Exceptions;
using TicketManagementSystem.Domain.Repositories;

namespace TicketManagementSystem.Application.TicketCommands.CreateTicket
{
    public class CreateTicketRules
    {
        public void Validate(string title, TicketPriority priority, string assignedTo, string description,
            DateTime createDate, bool isPayingCustomer)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new InvalidTicketException("The ticket must have a title");
            }

            if (string.IsNullOrEmpty(description))
            {
                throw new InvalidTicketException("The ticket must have a description");
            }

            if (string.IsNullOrEmpty(assignedTo))
            {
                throw new InvalidTicketException("The ticket must have an agent assigned to it");
            }



            var user = new UserRepository().GetUser(assignedTo);
            if (user == null)
            {
                throw new UnknownUserException("User " + assignedTo + " not found");
            }

        }

        }
    }
