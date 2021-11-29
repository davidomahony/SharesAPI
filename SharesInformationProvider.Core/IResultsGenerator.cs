using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharesInformationProvider.Core
{
    public interface IResultsGenerator<T>
    {
        public Task<T> GenerateResults(object information);
    }
}
