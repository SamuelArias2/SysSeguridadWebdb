using System.Security.Cryptography;
using System.Text;

namespace SysSeguridadWebdb.Auth
{
    public static class PasswordEncryptor
    {
        public static string EncriptarMD5(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convertir el array de bytes en una cadena hexadecimal
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2")); // "X2" para formato hexadecimal en mayúscula
                }
                return sb.ToString();
            }
        }
    }
}
