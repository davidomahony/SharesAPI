using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharesInformationProvider.Core
{
    public interface IApiConnector
    {
        public void Connect();

        public bool IsConnected { get; }

        public bool CheckConnection();
    }
}
