using System;
using TicketManagementSystem.Application.TicketCommands.AssignTicket;
using TicketManagementSystem.Application.TicketCommands.CreateTicket;
using TicketManagementSystem.Common.Enums;

namespace TicketManagementSystem
{
    public class TicketService
    {
        public int CreateTicket(string title, Priority priority, string assignedTo, string description, DateTime createDate, bool isPayingCustomer)
        {
            var ticketPriority = TicketPriority.Medium;

            if (priority == Priority.High)
                ticketPriority = TicketPriority.High;
            else if (priority == Priority.Low)
                ticketPriority = TicketPriority.Low;

            var command = new CreateTicketCommand();
            return command.Execute(title, ticketPriority, assignedTo, description, createDate, isPayingCustomer);
        }

        public void AssignTicket(int ticketId, string agentName)
        {
            var command = new AssignTicketCommand();
            command.Execute(ticketId, agentName);
        }
    }
}
