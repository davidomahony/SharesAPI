using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharesInformationProvider.Core
{
    public interface IResponseBuilder<T>
    {
        public T BuildResponse();
    }
}
