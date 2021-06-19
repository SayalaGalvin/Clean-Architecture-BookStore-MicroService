using System;
using System.Collections.Generic;
using System.Text;

namespace Books.Core.Entities.Base
{
    interface IEntityBase<TId>
    {
        TId id {get;}
    }
}
