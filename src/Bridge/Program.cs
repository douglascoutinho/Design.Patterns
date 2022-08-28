using Bridge;

var funcionario = new Funcionario
(
    101,
    "Douglas Coutinho",
    3000,
    1200
);

var calculaSalario = new CalculaSalario(new GerarXml());
calculaSalario.ProcessaSalario(funcionario);

calculaSalario = new CalculaSalario(new GerarJson());
calculaSalario.ProcessaSalario(funcionario);

Console.ReadKey();
