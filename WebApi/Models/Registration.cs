﻿namespace WebApi.Models
{
    public class Registration
    {
        public int Id { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
        public int IsActive { get; set; }
    }
}
