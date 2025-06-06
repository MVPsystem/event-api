﻿namespace EventAPI.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string ImageUrl { get; set; }
        public int TotalTickets { get; set; }
        public int TicketsSold { get; set; }
        public decimal Price { get; set; }
    }
}
