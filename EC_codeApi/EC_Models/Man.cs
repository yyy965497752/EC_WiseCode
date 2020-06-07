using System;
using System.Collections.Generic;
using System.Text;

namespace EC_Models
{
    public class Man
    {
        public int Mid { get; set; }
        public string Mname { get; set; }
        public string Modile { get; set; }
        public int Did { get; set; }
        public bool Mstate { get; set; }
        public string Mnotes { get; set; }
        public string Dname { get; set; }
    }
    public class Deapart
    {
        public int Did { get; set; }
        public string Dname { get; set; }
    }
}
