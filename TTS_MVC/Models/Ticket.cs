using System;
using System.ComponentModel.DataAnnotations;

namespace TTS_MVC.Models
{
    public class Ticket
    {
        [Key]
        public int Ticket_Id { get; set; }
        public string LoggedBy { get; set; }
        public DateTime RaisedDate { get; set; }
        public string Severity { get; set; }
        public string Ticket_Desc { get; set; }
        public string ResolvedBy { get; set; }
        public string Resolution { get; set; }
        public DateTime ResolvedDate { get; set; }
        public string Status { get; set; }
    }
}
