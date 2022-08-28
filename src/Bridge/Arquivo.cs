using Bridge.Interface;

namespace Bridge
{
    internal abstract class Arquivo
    {
        protected IGerarArquivo _arquivo;
        
        protected Arquivo(IGerarArquivo arquivo)
        {
            _arquivo = arquivo;
        }

        public virtual void GravaArquivo(Funcionario funcionario)
        {
            _arquivo.Gerar(funcionario);
        }
    }
}
