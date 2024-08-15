﻿namespace CircleConnect.Models
{
    public class User : BaseEntity
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
