﻿using Portfolio.Domain.Entities;

namespace Portfolio.Domain.Interfaces.Repositories
{
    public interface IRepository<Entity> where Entity : AbstractEntity
    {
        void Salvar(Entity entity);
        void Atualizar(Entity entity);
        Entity ObterPeloId(int id);
    }
}
