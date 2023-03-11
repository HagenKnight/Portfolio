using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Core.Interfaces.Management
{
    public interface IUpdateEntity<TKey>
    {
        public DateTime? UpdateDate { get; set; }
        public int? AccountIdUpdateDate { get; set; }
    }
}
