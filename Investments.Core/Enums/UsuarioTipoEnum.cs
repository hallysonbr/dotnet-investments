using System.ComponentModel;

namespace Investments.Core.Enums
{
    public enum UsuarioTipoEnum
    {
        [Description("Admin")]
        Admin = 1,

        [Description("Gerente")]
        Gerente = 2,

        [Description("Cliente")]
        Cliente = 3
    }
}