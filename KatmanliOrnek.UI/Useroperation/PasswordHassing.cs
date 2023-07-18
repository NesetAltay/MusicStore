using System.Security.Cryptography;
using System.Text;

namespace KatmanliOrnek.UI.Useroperation
{
    public static class PasswordHassing
    {
        public static string Sha256Hash(string sifre) 
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2"))); 
            }
        }
    }
}
