using System;

namespace Blyzniuk_Lab4.Models
{
    public class UserCity
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public double Time { get; set; }
        public Guid UserId { get; set; }
        public Guid CityId { get; set; }
    }
}
