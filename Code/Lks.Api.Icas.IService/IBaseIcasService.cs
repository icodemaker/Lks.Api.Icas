using Lks.IBaseService;

namespace Lks.Api.Icas.IService
{
    public interface IBaseIcasService<TEntity, TId> : IBaseService<TEntity, TId> where TEntity : class
    {
       
    }
}
