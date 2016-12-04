using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP.Contract.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();
    }
}
