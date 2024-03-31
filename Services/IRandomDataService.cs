namespace RandomDataServices.Services
{
    public interface IRandomDataService
    {
        string GetConfirmationCode(int length);
        string GetCryptoSalt(int length);
        string GetFilename(int length);
        string ConfirmationCodeCharsCollection { get; }
        string CryptoSaltCharsCollection { get; }
        string FileNameCharsCollection { get; }
    }
}
