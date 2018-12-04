using Lks.Api.Icas.IService;
using Lks.IBaseService;

namespace Lks.Api.Icas.Service
{
    /// <summary>
    /// 作者：Ark
    /// 时间：2017.03.17
    /// 描述：服务基类
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TId"></typeparam>
    public class LksIcasService<TEntity, TId> : IBaseService<TEntity, TId>,IBaseIcasService<TEntity,TId> where TEntity : class
    {
        #region 构造器

        /// <summary>
        /// 
        /// </summary>
        public LksIcasService()
        {
            var repository = new RespositoryIcas<TEntity, TId>(new LksForIcasContext());
            this.Repository = repository;
            base.Init(repository);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbContext"></param>
        public LksIcasService(LksForIcasContext dbContext)
        {
            var repository = new RespositoryIcas<TEntity, TId>(dbContext);
            this.Repository = repository;
            base.Init(repository);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="repository"></param>
        public LksIcasService(RespositoryIcas<TEntity, TId> repository)
        {
            this.Repository = repository;
            base.Init(repository);
        }

        #endregion

        #region 属性
        
        private RespositoryIcas<TEntity, TId> _icasRespository;

        public new RespositoryIcas<TEntity, TId> Repository
        {
            get
            {
                _icasRespository.DbContext = (LksForIcasContext) BaseDbContext;
                return _icasRespository;
            }
            set => _icasRespository = value;
        }

        #endregion

        #region 方法

        #endregion
    }
}
