using System;
using System.Security.Cryptography;
using System.Text;

namespace PhanMemBaoCom.Helper
{
    public class Security
    {
        //ma hoa mat khau
        public string MD5Hash(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("X2"));
                }
                return sb.ToString();
            }
        }

        //gen mat khau
        public string GenerateRandomString()
        {
            // Độ dài chuỗi ngẫu nhiên từ 8 đến 15 ký tự
            Random random = new Random();
            int length = random.Next(8, 16);

            // Các ký tự có thể sử dụng trong chuỗi
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            // Xây dựng chuỗi ngẫu nhiên
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(chars[random.Next(chars.Length)]);
            }

            return result.ToString();
        }

    }
}
