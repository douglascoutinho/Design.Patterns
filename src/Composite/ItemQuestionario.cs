namespace Composite
{
    // Component
    public abstract class ItemQuestionario
    {
        protected string? Descricao;

        public ItemQuestionario(string descricao)
        {
            this.Descricao = descricao;
        }

        public virtual void Add(ItemQuestionario component) { }
        public virtual void Remove(ItemQuestionario component) { }
        public abstract void Exibir();
    }
}
