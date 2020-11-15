using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week08.Abstraction;

namespace week08.Entities
{
    public class Present : Toy
    {
        public SolidBrush RibbonColor { get; private set; }
        public SolidBrush BoxColor { get; private set; }

        public Present(Color ribbon, Color box)
        {

        }
        protected override void DrawImage(Graphics g)
        {
           
        }
    }
}
