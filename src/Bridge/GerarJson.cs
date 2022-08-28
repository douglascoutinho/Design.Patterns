using Bridge.Interface;

namespace Bridge
{
    internal class GerarJson : IGerarArquivo
    {
        public void Gerar(Funcionario funcionario)
        {
            Console.WriteLine($"Dados do funcionário: {funcionario.Nome} gerados no formato JSON \n");
        }
    }
}
