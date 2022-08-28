using Bridge.Interface;

namespace Bridge
{
    internal class GerarXml : IGerarArquivo
    {
        public void Gerar(Funcionario funcionario)
        {
            Console.WriteLine($"Dados do funcionário: {funcionario.Nome} gerados no formato XML \n");
        }
    }
}
