using SharedServices.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedServices.CommonLayer.ICommonLayer
{
    public interface IRepository<TEntity, TEntityKey> : IDisposable where TEntity : EntityBase<TEntityKey>
    {
    }
}
