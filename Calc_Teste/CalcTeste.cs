using Projeto_para_Teste;
using Xunit;

namespace Calc_Teste
{
    public class CalcTeste
    {
        [Fact]
        public void Somar()
        {
            Assert.Equal(20, Calc.Somar(10, 10));
        }
        [Fact]
        public void Subtrair()
        {
            Assert.Equal(0, Calc.Subtracao(10, 10));
        }        
        
        [Fact]
        public void Multiplicar()
        {
            Assert.Equal(100, Calc.Multiplicar(10, 10)); //( [Valor Esperado], [Classe importada].[Método Importado da classe]([Valor para os Argumentos]) );
        }        
        
        [Fact]
        public void Dividir()
        {
            Assert.Equal(1, Calc.Divisao(10, 10));
        }


    }
}