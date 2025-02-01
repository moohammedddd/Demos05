using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessMofiriers
{
    public class TypeB:TypeA
    {
        public int F { get; set; }
        public int G { get; set; }

        public TypeB(int _A, int _B, int _C, int _D, int _E, int _F , int _G):base(_A,_B,_C,_D,_E)
        {
            F = _F;
            G = _G;
        }
        public override string ToString()
        {
            return $"a is {A} , C is {C} , D is {D} , E is {E} , F is {F} G is {G}";
            // note B is not allowed because it is private 
        }
    }
}
