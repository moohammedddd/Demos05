using AccessMofiriers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos05
{
    internal class Inherit:TypeA
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public Inherit(int _A, int _B, int _C, int _D, int _E, int _id , string _name , string _description): base(_A, _B, _C, _D, _E)
        {
            id = _id;
            name = _name;
            description = _description;
        }

        public override string ToString()
        {
            // C valied because it is protected 
            // Private protected not valied like (D)
            return $"id is {id} name is {name} description is {description} and c is {C} and E is {E}";
        }
    }
}
