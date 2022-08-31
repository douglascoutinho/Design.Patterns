namespace Composite
{
    //composite
    internal class Grupo : ItemQuestionario
    {
        private IList<ItemQuestionario> questionarios = new List<ItemQuestionario>();

        public Grupo(string descricao)
            : base(descricao) { }

        public override void Add(ItemQuestionario component)
        {
            questionarios.Add(component);
        }

        public override void Remove(ItemQuestionario component)
        {
            questionarios.Remove(component);
        }

        public override void Exibir()
        {
            Console.WriteLine($"\n{Descricao}");

            foreach (var item in questionarios)
            {
                item.Exibir();
            }
        }
    }
}
