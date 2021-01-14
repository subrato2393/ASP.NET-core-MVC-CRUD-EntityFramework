using System;
using System.Collections.Generic;
using System.Text;

namespace Crud.DataAccessLayer
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
