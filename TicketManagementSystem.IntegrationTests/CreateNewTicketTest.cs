using TicketManagementSystem.Common.Exceptions;

namespace TicketManagementSystem.IntegrationTests
{
    [TestClass]
    public class CreateNewTicketTest
    {
        [TestMethod]
        public void HappyTest()
        {
            var ticketService = new TicketService();

            var newTicketId = ticketService.CreateTicket("Lorem ipsum", Priority.Medium, "Charles", "Dolor amet", DateTime.Now, false);

            Assert.IsTrue(newTicketId > 0);

        }

        [TestMethod]
        public void NoUserTest()
        {
            var ticketService = new TicketService();

            Assert.ThrowsException<InvalidTicketException>(() => ticketService.CreateTicket("Lorem ipsum", Priority.Medium, "", "Dolor amet", DateTime.Now, false));   
        }

        //Här går det att lägga till oändligt många tester, men jag tror ni hajjar.
    }
}