using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03.interfaces.question1
{
    interface IRectangle : IShape
    {
        double Width { get; }
        double Height { get; }
    }
}
