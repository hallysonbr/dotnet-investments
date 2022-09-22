using System;
using System.Collections.Generic;
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
            "7676aaafb027c825bd9abab78b234070e702752f625b752e55e55b48e607e358", 
            new DateTime(1994, 04, 18), UsuarioTipoEnum.Admin);

            usuario.DefinirId(1);

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
            
            int i = 1;
            foreach (var item in ativos)
            {
                item.DefinirId(i);
                i++;
            }

            builder.Entity<Ativo>()
                   .HasData(ativos);

            #endregion

            return builder;
        }
    }
}