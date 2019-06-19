using System;

namespace EventManagement.Domain
{
    public class Event
    {
        public string Name { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
    }
}