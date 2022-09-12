namespace TicketManagementSystem.IntegrationTests
{
    [TestClass]
    public class AssignTicketTest
    {
        [TestMethod]
        public void NoSuchTicketTest()
        {
            var ticketService = new TicketService();

            Assert.ThrowsException<ApplicationException>(() => ticketService.AssignTicket(1, "Thomas"));

        }
    }
}