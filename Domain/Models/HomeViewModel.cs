using System;
using System.Collections.Generic;

namespace Models
{
    public class HomeViewModel
    {
        public List<Actor> Actors { get; set; }
        
        public List<Computer> Computers { get; set; }
        public List<Ram> Rams { get; set; }
        public List<HardDrive> HardDrives { get; set; }
        public List<GraphicsCard> GraphicsCards { get; set; }
        public List<Processor> Procesors { get; set; }
    }
}