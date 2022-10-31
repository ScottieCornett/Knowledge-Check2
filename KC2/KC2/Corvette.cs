using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KC2
{
    public class Corvette : Chevrolet
    {
        public override string ToString() => $" Color: {Color}, Top Speed: {TopSpeed}, ModelType: {ModelType}"; 
        
        
    }
}
