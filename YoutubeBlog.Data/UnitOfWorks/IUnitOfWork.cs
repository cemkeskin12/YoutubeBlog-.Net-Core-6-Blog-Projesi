using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Core.Entities;
using YoutubeBlog.Data.Repositories.Abstractions;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Data.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IRepository<T> GetRepository<T>() where T : class,IEntityBase, new();
        Task<int> SaveAsync();
        int Save();
    }
}
