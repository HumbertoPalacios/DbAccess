using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDEMO.Demo1
{
    //ABSTRACT, means you cannot create an instance of this it can only be inherited
    public abstract class TableBase
    {
        public double H { get; set; }
        public abstract double GetArea(double h, double w);

        public virtual double GetArea2(double h, double w)
        {
            return h * w / 2;
        }
        
    }

    public interface ITableBase
    {
        double H { get; set; }
        double W { get; set; }
        double GetArea(double h, double w);
        double GetArea2(double h, double w);
    }
}
