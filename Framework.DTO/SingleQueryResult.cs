using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.DTO
{
    public abstract class SingleQueryResult<TEntity> : QueryResult
    {
        protected SingleQueryResult(){}

        public TEntity Entity { get; set; }
    }
}
