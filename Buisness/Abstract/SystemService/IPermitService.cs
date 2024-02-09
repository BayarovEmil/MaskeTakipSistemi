using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract.SystemService
{
    public interface IPermitService
    {
        void GivePermit(Person person);
    }
}
