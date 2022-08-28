using Adapter.Interface;

namespace Adapter
{
    internal class GraficoAdapter : IGrafico
    {
        public void GerarGrafico(string titulo, List<string> x, List<int> y)
        {
            var superGeradorGrafico = new SuperGeradorGrafico();
            superGeradorGrafico.DesenharGrafico(titulo, x, y);
        }
    }
}
