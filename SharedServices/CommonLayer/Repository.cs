using SharedServices.CommonLayer.ICommonLayer;
using SharedServices.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedServices.CommonLayer
{
    public class Repository<TEntity, TEntityKey> : IRepository<TEntity, TEntityKey> where TEntity : EntityBase<TEntityKey>

    {
        public void Dispose()
        {            
        }
    }
}
