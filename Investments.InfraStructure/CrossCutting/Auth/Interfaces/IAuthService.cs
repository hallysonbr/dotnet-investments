using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Investments.InfraStructure.CrossCutting.Auth.Interfaces
{
    public interface IAuthService
    {
         string GenerateJwtToken(string email, string role);
         string ComputeSha256Hash(string password);
    }
}