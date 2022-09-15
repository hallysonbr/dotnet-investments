namespace Investments.Core.Entities
{
    public abstract class EntidadeBase
    {
        public int Id { get; private set; }

        public void DefinirId(int id)
        {
            Id = id;
        }
    }
}