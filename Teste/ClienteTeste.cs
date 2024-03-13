using Dominio;
using ExpectedObjects;
using System.Runtime.ConstrainedExecution;

namespace Teste
{
    public class ClienteTeste
    {
        // Exemplo 02
        // Teste usando objeto anônimo, ExpectedObject com apenas um assert

        [Fact]
        public void CriarObjetoCliente()
        {
            // Arrange
            // criando um objeto anônimo
            var clienteEsperado = new
            {
                Codigo = 1,
                Nome = "Funeraria Vá com Deus",
                Endereco = "Rua das Cacaia, 12",
                Telefone = "(47) 3025-8076"
            };

            // Act
            Cliente cli = new Cliente(
                clienteEsperado.Codigo,
                clienteEsperado.Nome,
                clienteEsperado.Endereco,
                clienteEsperado.Telefone
                );

            // Assert
            clienteEsperado.ToExpectedObject().ShouldMatch( cli );


        }

        








        /*
        /* Exemplo 01
         Teste simples, usando variáveis, avaliando usando vários asserts

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
        */
    }
}