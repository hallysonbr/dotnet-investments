using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Investments.Core.Entities;
using Investments.Core.Enums;
using Microsoft.EntityFrameworkCore;

namespace Investments.InfraStructure.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            #region Usuario

            var usuario = new Usuario("Admin", "admin@teste.com", 
            "36F583DD16F4E1E201EB1E6F6D8E35A2CCB3BBE2658DE46B4FFAE7B0E9ED872E", 
            new DateTime(1994, 04, 18), UsuarioTipoEnum.Admin);

            builder.Entity<Usuario>()
                .HasData(usuario);

            #endregion

            #region Ativos

            var ativos = new List<Ativo>
            {
                new Ativo("CDB 100%", TipoAtivoEnum.RendaFixa),
                new Ativo("Fundo Imobiliário", TipoAtivoEnum.RendaVariavel),
                new Ativo("Fundo LCI", TipoAtivoEnum.RendaVariavel),
                new Ativo("Fundo Gold", TipoAtivoEnum.Fundos),
                new Ativo("Fundo Platinum", TipoAtivoEnum.Fundos),
                new Ativo("PETR4", TipoAtivoEnum.Acoes),
                new Ativo("BBAS3", TipoAtivoEnum.Acoes),
                new Ativo("Tesouro IPCA+ 2025", TipoAtivoEnum.TesouroDireto),
                new Ativo("Tesouro Pré-Fixado 2027", TipoAtivoEnum.TesouroDireto),
                new Ativo("Caderneta de Poupança", TipoAtivoEnum.Poupanca),
                new Ativo("Bitcoin", TipoAtivoEnum.Criptomoeda),
                new Ativo("Ethereum", TipoAtivoEnum.Criptomoeda)
            };

            builder.Entity<Ativo>()
                   .HasData(ativos);

            #endregion

            return builder;
        }
    }
}