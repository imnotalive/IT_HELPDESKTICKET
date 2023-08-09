using System.ComponentModel.DataAnnotations;

namespace IT_HELPDESKTICKET.Models
{
    public class HelpDesk
    {

        [Key]
        public int HelpDeskID { get; set; }
        public string? Bolum { get; set; }
        public string? Personel { get; set; }
        public string? Ariza { get; set; }
        public string? Durum { get; set; }


    }
}
