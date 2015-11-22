using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_ShirtShop
{
    public class TShirt
    {
        public TShirtSize size;
        public TShirtColor color;

        public TShirt()
        {
            this.size = TShirtSize.M;
            this.color = TShirtColor.Red;
        }
       
        public TShirt(TShirtSize size,TShirtColor color)
        {
            this.size = size;
            this.color = color;
        }
        public TShirtSize Size
        {
            get { return size; }
        }
        
        public TShirtColor Color
        {
            get { return color; }
        }
     
    }
}
