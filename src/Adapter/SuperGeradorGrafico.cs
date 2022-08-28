namespace Adapter
{
    internal sealed class SuperGeradorGrafico
    {
        public string? Titulo { get; private set; }
        public List<string>? XValores { get; private set; }
        public List<int>? YValores { get; private set; }

        public void DesenharGrafico(string titulo, List<string> x, List<int> y)
        {
            Console.WriteLine($"SuperGeradorGrafico : Gerando {titulo} Com efeitos: {String.Join(", ", x)} e {String.Join(", ", y)}");
        }
    }
}
