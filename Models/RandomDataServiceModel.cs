using System.ComponentModel.DataAnnotations;

namespace RandomDataServices.Models
{
    public class RandomDataServiceModel
    {
        public string ConfirmationCode { get; set; } = null!;
        public string CryptoSalt { get; set; } = null!;
        public string Filename { get; set; } = null!;
        public string ConfirmationCodeСharsCollection { get; set; } = null!;
        public string CryptoSaltCharsCollection { get; set; } = null!;
        public string FileNameCharsCollection { get; set; } = null!;
    }
}
