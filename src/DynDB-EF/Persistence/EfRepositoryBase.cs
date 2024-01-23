#if NETCOREAPP
using Microsoft.EntityFrameworkCore;
#else
using System.Data.Entity;
#endif
using System.Collections;
using System.Collections.Generic;
using System.Data.Fuse.Logic;

namespace System.Data.Fuse.Persistence {
  public abstract class EfRepositoryBase  {
    protected readonly DbContext context;

    public EfRepositoryBase(DbContext dbContext) {
      this.context = dbContext;
    }

    public abstract IList GetEntitiesBase(LogicalExpression filter, PagingParams pagingParams, SortingField[] sortingParams);
    public abstract IList GetEntitiesBase(string dynamicLinqFilter, PagingParams pagingParams, SortingField[] sortingParams);

    public abstract IList<Dictionary<string, object>> GetBusinessModelsBase(LogicalExpression filter, PagingParams pagingParams, SortingField[] sortingParams);
    public abstract IList<Dictionary<string, object>> GetBusinessModelsBase(string dynamicLinqFilter, PagingParams pagingParams, SortingField[] sortingParams);

    public abstract IList<EntityRef> GetEntityRefsBase(LogicalExpression filter, PagingParams pagingParams, SortingField[] sortingParams);
    public abstract IList<EntityRef> GetEntityRefsBase(string dynamicLinqFilter, PagingParams pagingParams, SortingField[] sortingParams);

    public abstract int GetCountBase(LogicalExpression filter);

    public abstract void DeleteEntitiesBase(object[][] entityIdsToDelete);
    public abstract object AddOrUpdateBase(Dictionary<string, object> entity);

  }
}
