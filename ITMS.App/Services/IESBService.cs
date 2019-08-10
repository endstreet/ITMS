using ITMS.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ITMS.App.Services
{
    public interface IESBService
    {
        Task<List<Register>> GetRegisters(string hospital);
        Task<List<Case>> GetCases(string hospital, string section);
    }
}
