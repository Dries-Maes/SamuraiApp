using System;
using System.Collections.Generic;
using System.Text;

namespace SamuraiApp.Models
{
    public class Samurai
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public Era Era { get; set; }
        public DateTime DayOfBirth { get; set; }
        public bool HasDied { get; set; }
        public string ImagePath { get; set; }

        public Samurai()
        {
            //
        }
    }
}