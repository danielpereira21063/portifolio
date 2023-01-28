﻿using Portfolio.Domain.Entities;
using Portfolio.Domain.Interfaces.Repositories;
using Portfolio.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Infra.Data.Repositories
{
    public class ProjetoRepository : Repository<Projeto>, IProjetoRepository
    {
        public ProjetoRepository(PortfolioContext context) : base(context)
        {
        }

        public ICollection<Projeto> ObterLista(int dadosPortfolioId)
        {
            return Context.Projetos.Where(x => x.DadosPortfolioId == dadosPortfolioId && !x.Inativo).ToList();
        }
    }
}
