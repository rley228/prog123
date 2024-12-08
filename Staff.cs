using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog1
{
    public class Staff
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Division { get; set; }
        public string Hired { get; set; }
        public int Salary { get; set; }

        public Staff(int _id, string _fName, string _name, string _pos, string _div, string _hir, int _sal)
        {
            Id = _id;
            FirstName = _fName;
            Name = _name;
            Position = _pos;
            Division = _div;
            Hired = _hir;
            Salary = _sal;
        }

        public Staff() { }
    }
}
