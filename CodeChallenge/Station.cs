using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    class Station
    {
        private string name;
        private int id;
        private string date;
        private decimal depth;
        private string comment;

        public Station() { }
        public Station(string name, int id, string date, decimal depth, string comment)
        {
            this.name = name;
            this.id = id;
            this.date = date;
            this.depth = depth;
            this.comment = comment;
        }

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public string Date { get => date; set => date = value; }
        public decimal Depth { get => depth; set => depth = value; }
        public string Comment { get => comment; set => comment = value; }
    }
}
