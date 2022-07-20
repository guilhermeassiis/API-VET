using VetApi.Models;
using VetApi.Models.Enums;

namespace VetApi.DTOS.AnimalDTOS
{
    public class ReadAnimalDTO
    {
        // public int Id { get; set; }
        public decimal Weigth { get; set; }
        public string IdentificationCode { get; set; }
        public string Name { get; set; }
        public Sex Sex { get; set; }
        public string Species { get; set; } = "Canine";
        public Tutor Tutor { get; set; }
    }
}