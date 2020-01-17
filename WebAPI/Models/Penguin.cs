using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public enum Genus
    {
        Aptenodytes,
        Pygoscelis,
        Eudyptula,
        Spheniscus,
        Megadyptes,
        Eudyptes
    }

    public enum Gender
    {
        Female,
        Male,
        Helicopter,
        Other
    }

    public class Penguin
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }        
        public Genus Genus { get; set; }
    }
}
