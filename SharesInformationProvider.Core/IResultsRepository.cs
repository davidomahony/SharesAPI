using System.Threading.Tasks;

namespace SharesInformationProvider.Core
{
    public interface IResultsRepository<T>
    {
        public Task<T> FetchResults(object requestInformation);
    }
}
