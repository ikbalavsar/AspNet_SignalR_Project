using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR_BusinessLayer.Abstract
{
    public interface IMoneyCaseService : IGenericService<IMoneyCaseService>
    {
        decimal TTotalMoneyCaseAmount();
    }
}
