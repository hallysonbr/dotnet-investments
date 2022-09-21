using System.ComponentModel;

namespace Investments.Core.Enums
{
    public enum TipoAtivoEnum
    {
        [Description("Renda Fixa")]
        RendaFixa = 1,

        [Description("Renda Variável")]
        RendaVariavel = 2,

        [Description("Fundos")]
        Fundos = 3,

        [Description("Ações")]
        Acoes = 4,

        [Description("Tesouro Direto")]
        TesouroDireto = 5,

        [Description("Poupança")]
        Poupanca = 6,
        
        [Description("Criptomoeda")]
        Criptomoeda = 7
    }
}