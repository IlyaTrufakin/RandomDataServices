using System.Text;

namespace RandomDataServices.Services
{
    public class RandomDataService : IRandomDataService
    {
        private readonly Random random = new();
        public const string сonfirmationCodeСharsCollection = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        public const string cryptoSaltCharsCollection = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+";
        public const string fileNameCharsCollection = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        public string GetConfirmationCode(int length) => GenerateRandomString(сonfirmationCodeСharsCollection, length);

        public string GetCryptoSalt(int length) => GenerateRandomString(cryptoSaltCharsCollection, length);

        public string GetFilename(int length) => GenerateRandomString(fileNameCharsCollection, length);

        private string GenerateRandomString(string charsCollection, int length)
        {
            var result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(charsCollection[random.Next(charsCollection.Length)]);
            }
            return result.ToString();
        }
        public string ConfirmationCodeCharsCollection => сonfirmationCodeСharsCollection;
        public string CryptoSaltCharsCollection => cryptoSaltCharsCollection;
        public string FileNameCharsCollection => fileNameCharsCollection;
    }
}
