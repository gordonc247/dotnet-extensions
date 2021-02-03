using System;
using System.Security.Cryptography;
using System.Text;

namespace Codefire.Extensions {
    public static class PasswordHelper {
        const string LowerCase = "abcdefghijklmnopqursuvwxyz";
        const string UpperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string Numbers = "0123456789";
        const string Specials = @"!@£$%^&*()#€";

        public static string GeneratePassword(int passwordSize, bool useLowercase, bool useUppercase, bool useNumbers, bool useSpecial)
        {
            var charSet = "";

            if (useLowercase) charSet += LowerCase;
            if (useUppercase) charSet += UpperCase;
            if (useNumbers) charSet += Numbers;
            if (useSpecial) charSet += Specials;

            var password = new char[passwordSize];
            var random = new Random();

            for (var x = 0; x < passwordSize; x++)
            {
                password[x] = charSet[random.Next(charSet.Length - 1)];
            }

            return new string(password);
        }

        public static string EncryptPassword(string password, string salt)
        {
            var inputData = Encoding.Unicode.GetBytes(password);
            var saltData = Convert.FromBase64String(salt);
            var data = new byte[inputData.Length + saltData.Length];
            Buffer.BlockCopy(inputData, 0, data, 0, inputData.Length);
            Buffer.BlockCopy(saltData, 0, data, inputData.Length, saltData.Length);

            var hashProvider = SHA256.Create();
            var hashData = hashProvider.ComputeHash(data);

            return Convert.ToBase64String(hashData);
        }
    
        public static byte[] GenerateRandomValue(int size)
        {
            using (var generator = new RNGCryptoServiceProvider())
            {
                var data = new byte[size];
                generator.GetBytes(data);

                return data;
            }
        }
    }
}