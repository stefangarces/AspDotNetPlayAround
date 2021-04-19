using System;

namespace aspNET.Models
{
    public class Events
    {
        //public string Title { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public string Adress { get; set; }
        public DateTime Date { get; set; }
        public bool ticketsAvailable { get; set; }
        public Organizer OrgID { get; set; }

    }
}
