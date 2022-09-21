using System.Security.Cryptography;
using System.Text;
using Investments.InfraStructure.CrossCutting.Auth.Interfaces;

namespace Investments.InfraStructure.CrossCutting.Auth.Implementations
{
    public class AuthService : IAuthService
    {
        public string ComputeSha256Hash(string password)
        {
             using (SHA256 sha256Hash = SHA256.Create())
            {
                //ComputeHash
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                //Converts byte array to string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2")); //x2 - Faz conversão para representação hexadecimal
                }

                return builder.ToString();
            }
        }

        public string GenerateJwtToken(string email, string role)
        {
           return string.Empty;
        }
    }
}