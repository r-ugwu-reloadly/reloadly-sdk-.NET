using Reloadly.Airtime.Dto.Response;
using Reloadly.Airtime.Filter;
using Reloadly.Core.Dto.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reloadly.Airtime.Operation
{
    public interface IOperatorOperations
    {
        Task<Operator> AutoDetectAsync(string phone, string countryCode, OperatorFilter? filter = null);
        Task<OperatorFxRate> CalculateFxRateAsync(long operatorId, decimal amount);
        Task<Operator> GetByIdAsync(long operatorId, OperatorFilter? filter = null);
        Task<Page<Operator>> ListAsync(OperatorFilter? filter = null);
        Task<IList<Operator>> ListByCountryCodeAsync(string countryCode, OperatorFilter? filter = null);
        Task<Page<Operator>> ListCommissionsAsync(OperatorFilter? filter = null);
        Task<Operator> GetCommissionByOperatorIdAsync(long operatorId);
        Task<Operator> GetMNPLookupAsync(string phone, string countryCode);
        Task<Operator> PostMNPLookupAsync(string phone, string countryCode);
    }
}