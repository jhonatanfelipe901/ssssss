using ProjetoAds.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAds.Application.Application
{
    public class ApplicationBase<TEntity> : BaseApplication, IApplicationBase<TEntity> where TEntity : class
    {
        public ApplicationBase()
        {
        }
    }
}
