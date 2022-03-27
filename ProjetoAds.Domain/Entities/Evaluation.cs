using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAds.Domain.Entities
{
    public class Evaluation : BaseEntity
    {
        public int QntEstrelas { get; set; }
        public long UserId { get; set; }
        public long UserIdUtilPraMim { get; set; }

        //255 Caracteres
        public string Descricao { get; set; }

        public Evaluation()
        {

        }
    }
}
