using EmailService;
using TicketManagementSystem.Common.Enums;
using TicketManagementSystem.Domain.Queries;
using TicketManagementSystem.Domain.Repositories;
using TicketManagementSystem.Domain.Services.TicketServices;

namespace TicketManagementSystem.Application.TicketCommands.CreateTicket
{
    public class CreateTicketCommand
    {
        public int Execute(string title, TicketPriority priority, string assignedTo, string description, DateTime createDate, bool isPayingCustomer)
        {
            new CreateTicketRules().Validate(title, priority, assignedTo, description, createDate, isPayingCustomer);

            priority = CheckAndSetPriority(createDate, priority, title);

            var assignedUser = new UserRepository().GetUser(assignedTo);

            var newTicket = CreateTicketMapper.Execute(title, priority, assignedTo, description, createDate, assignedUser);


            if (priority == TicketPriority.High)
            {
                var emailService = new EmailServiceProxy();
                emailService.SendEmailToAdministrator(title, assignedTo);
            }

            if (isPayingCustomer)
            {
                newTicket.AccountManager = new GetAccountManager().Execute();
                newTicket.PriceDollars = 50;
                
                if (priority == TicketPriority.High)
                {
                    newTicket.PriceDollars = 100;
                }
                
            }

            var id = CreateTicketService.Execute(newTicket);

            return id;
        }

        private TicketPriority CheckAndSetPriority(DateTime createDate, TicketPriority priority, string title)
        {
            var raisePriorityStrings = new [] { "CRASH", "IMPORTANT", "FAILURE" };


            var priorityRaised = createDate < DateTime.UtcNow - TimeSpan.FromHours(1);

            if (priorityRaised)
            {
                if (priority == TicketPriority.Low)
                {
                    priority = TicketPriority.Medium;
                }
                else if (priority == TicketPriority.Medium)
                {
                    priority = TicketPriority.High;
                }
            }
            if (raisePriorityStrings.Contains(title.ToUpper()) && !priorityRaised)
            {
                if (priority == TicketPriority.Low)
                {
                    priority = TicketPriority.Medium;
                }
                else if (priority == TicketPriority.Medium)
                {
                    priority = TicketPriority.High;
                }
            }

            return priority;
        }
    }
}
