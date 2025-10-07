﻿namespace HospitalService.Models
{
    public class Hospital
    {
        public Guid HospitalId { get; set; } = new Guid();
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
        public string Contact { get; set; } = "";
        public string Email { get; set; } = "";
      //  public string Image { get; set; } = "";
    }
}
