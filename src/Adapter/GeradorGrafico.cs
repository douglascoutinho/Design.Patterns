namespace Adapter
{
    internal class GeradorGrafico
    {
        public void GerarGrafico(string titulo, List<string> x, List<int> y)
        {
            this.Titulo = titulo;
            this.XValores = x;
            this.YValores = y;

            Console.WriteLine("MeuGeradorGrafico: Gerando Gráfico");
        }

        public string? Titulo { get; private set; }
        public List<string>? XValores { get; private set; }
        public List<int>? YValores { get; private set; }
    }
}
