using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAds.CrossCutting.ExtensionMethods
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> GetPaged<T>(this IEnumerable<T> list, int page, int pageSize)
        {
            var skip = (page - 1) * pageSize;

            return list.Skip(skip).Take(pageSize);
        }
    }
}
