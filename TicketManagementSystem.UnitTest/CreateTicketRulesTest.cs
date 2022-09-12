using TicketManagementSystem.Application.TicketCommands.CreateTicket;
using TicketManagementSystem.Common.Enums;
using TicketManagementSystem.Common.Exceptions;

namespace TicketManagementSystem.UnitTest
{
    [TestClass]
    public class CreateTicketRulesTest
    {
        [TestMethod]
        public void TestValidation()
        {
            var rules = new CreateTicketRules();

            //No title test
            Assert.ThrowsException<InvalidTicketException>(() => rules.Validate("", TicketPriority.Medium, "Göran", "Dolor amet", DateTime.Now, false));

            //No user test
            Assert.ThrowsException<UnknownUserException>(() => rules.Validate("Lorem ipsum", TicketPriority.Medium, "Nilsgöran", "Dolor amet", DateTime.Now, false));
        }
    }
}
