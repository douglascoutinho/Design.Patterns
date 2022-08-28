using Bridge.Interface;

namespace Bridge
{
    internal class CalculaSalario : Arquivo
    {
        public CalculaSalario(IGerarArquivo arquivo)
            : base(arquivo) { }

        public void ProcessaSalario(Funcionario funcionario)
        {
            funcionario.Calcular();
            _arquivo.Gerar(funcionario);
        }
    }
}
