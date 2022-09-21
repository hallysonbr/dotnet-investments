namespace Investments.Application.ViewModels
{
    public class TipoAtivoViewModel
    {
        public TipoAtivoViewModel(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
    }
}