using System;
using System.Collections.Generic;
using System.Text;

namespace Books.Core.Entities.Base
{
    public abstract class EntityBase<TId> : IEntityBase<TId>
    {
        public virtual TId id { get; protected set; }
    }
}
