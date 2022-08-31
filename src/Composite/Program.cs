using Composite;

var grupoRaiz = new Grupo("Questionario:");

var grupoA = new Grupo("Português");
var questao1 = new Questao("Q1");
var questao2 = new Questao("Q2");

grupoA.Add(questao1);
grupoA.Add(questao2);


var grupoB = new Grupo("Física");

var grupoB1 = new Grupo("   Mecânica");
var questao3 = new Questao("    Q3");
var questao4 = new Questao("    Q4");

grupoB1.Add(questao3);
grupoB1.Add(questao4);


var grupoB2 = new Grupo("   Óptica");
var questao5 = new Questao("    Q5");
var questao6 = new Questao("    Q6");

grupoB2.Add(questao5);
grupoB2.Add(questao6);

grupoB.Add(grupoB1);
grupoB.Add(grupoB2);

var grupoC = new Grupo("Matemática");
var questao7 = new Questao("Q7");
var questao8 = new Questao("Q8");

grupoC.Add(questao7);
grupoC.Add(questao8);


grupoRaiz.Add(grupoA);
grupoRaiz.Add(grupoB);
grupoRaiz.Add(grupoC);

grupoRaiz.Exibir();


Console.ReadKey();