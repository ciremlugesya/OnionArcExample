using Microsoft.EntityFrameworkCore.Storage;
using OnionArcExample.Application.Interfaces.Repositories;
using System;
using System.Threading.Tasks;

namespace OnionArcExample.Application.Interfaces.UnitOfWork
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        //IDbContextTransaction : EntityFrameworkCore kütüphanesine ihtiyaç vardır.
        Task<IDbContextTransaction> BeginTransactionAsync();
        public IProductRepository ProductRepository { get; }
    }
}
