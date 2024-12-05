namespace TourismManagement.Tests
{
    public class ClientTests
    {
        [Fact]
        public void IsAdult_ShouldReturnTrue_WhenClientIs18OrOlder()
        {
            // Arrange: Criar um cliente que tem 18 anos ou mais
            var adultClient = new Client(1, "João Alves", "joao@ipca.com", "259486639", "912231427", new DateTime(2000, 1, 1));

            // Act: Chamar o método IsAdult()
            var result = adultClient.IsAdult();

            // Assert: Verificar se o resultado é true
            Assert.True(result);
        }

        [Fact]
        public void IsAdult_ShouldReturnFalse_WhenClientIsYoungerThan18()
        {
            // Arrange: Criar um cliente menor de idade
            var youngClient = new Client(2, "Maria José", "maria@ipca.com", "254859874", "987654321", new DateTime(2010, 1, 1));

            // Act: Chamar o método IsAdult()
            var result = youngClient.IsAdult();

            // Assert: Verificar se o resultado é false
            Assert.False(result);
        }
    }

}
