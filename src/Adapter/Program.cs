using Adapter;
using Adapter.Interface;

IGrafico meuGeradorGrafico = new GraficoAdapter();
var listX = new List<string> { "Volvo", "BMW", "Ford", "Mazda" };
var listY = new List<int> { 1, 2, 3 };

meuGeradorGrafico.GerarGrafico("Gráfico - 01", listX, listY);