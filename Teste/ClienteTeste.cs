using Dominio;

namespace Teste
{
    public class ClienteTeste
    {
        [Fact]
        public void CriarObjetoCliente()
        {
            // Arrange
            int Codigo = 1;
            string Nome = "Funerária Agrícola";
            string Endereco = "Rua das Cacaia, 12";
            string Telefone = "(47) 3025-8076";

            // Act
            Cliente cli = new Cliente(Codigo,Nome,Endereco,Telefone);

            // Assert
            Assert.Equal(Codigo, cli.Codigo);
            Assert.Equal(Nome, cli.Nome);
            Assert.Equal(Endereco, cli.Endereco);
            Assert.Equal(Telefone, cli.Telefone);
        }
    }
}