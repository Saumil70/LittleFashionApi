using System.ComponentModel.DataAnnotations;

namespace LittleFashionApi.Model
{
    public class Cards
    {
        [Key]
        public int CardId { get; set; }
        public byte[] Image { get; set; }

        public string Title { get; set; }
        public string Description { get; set; } 

    }
}
