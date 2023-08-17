using System;
using System.Collections.Generic;

namespace Infrastructure.Data
{
    public partial class Animale
    {
        public int Animalid { get; set; }
        public string? Name { get; set; }
        public string? Breed { get; set; }
        public DateTime? Birthdate { get; set; }
        public string? Sex { get; set; }
        public int? Price { get; set; }
        public string? Status { get; set; }
    }
}
