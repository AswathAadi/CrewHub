using Microsoft.EntityFrameworkCore;
using SharedServices.CommonLayer.ICommonLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedServices.CommonLayer
{
    public class BaseContext<T> : DbContext, IDbContext 
        where T : DbContext
    {
        public BaseContext(DbContextOptions<T> options) : base(options) { }


    }
}
