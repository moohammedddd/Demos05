using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AccessMofiriers
{
    public class TypeA
    {
        public int A { get; set; } // public
        private int B { get; set; }  // private
        protected  int C { get; set; } // protected work on inhertance it will be (private)
        private protected int D { get; set; } // private
        protected internal int E { get; set; } // internal

        public TypeA(int _A , int  _B , int _C , int _D , int _E)
        {
            A = _A;
            B = _B;
            C = _C;
            D = _D;
            E = _E;
        }
        public override string ToString()
        {
            return $"A is {A} , B is {B} , c is {C} , D is {D}, e is {E}";
        }
    }
}
