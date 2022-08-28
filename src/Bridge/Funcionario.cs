namespace Bridge
{
    internal class Funcionario
    {
        public Funcionario(int id, string nome, decimal salarioBase, decimal incentivo)
        {
            this.Id = id;
            this.Nome = nome;
            this.SalarioBase = salarioBase;
            this.Incentivo = incentivo;
        }

        public int Id { get; private set; }
        public string? Nome { get; private set; }
        public decimal SalarioBase { get; private set; }
        public decimal Incentivo { get; private set; }
        public decimal SalarioTotal { get; private set; }

        internal void Calcular()
        {
            this.SalarioTotal = this.SalarioBase + this.Incentivo;
            Console.WriteLine($"Valor do slário para o funcionario: {this.Nome} é R$ {this.SalarioTotal}" );
        }
    }
}
