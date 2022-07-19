using VetApi.Models.Enums;

namespace VetApi.Models
{
    public class Veterinarian : Person
    {
        public string CRMV { get; set; }
        public Specialty Specialty { get; set; }
    }
}