using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDEMO.Demo1
{
    public class Table: TableBase
    {
        double _width;
        double _height;

        public Table(double width, double height)
        {
            _width = width;
            _height = height;
        }

        //OVERRIDE, 
        public override double GetArea(double h, double w)
        {
            return h * w;
        }

        public override double GetArea2(double h, double w)
        {
            return h * w / 10;
        }

        public double GetObjectArea(ITableBase tablebase)
        {
            return tablebase.H * tablebase.W;
        }

        public void TestThis()
        {
            double val = GetObjectArea(new Square());
            double val2 = GetObjectArea(new Rect());
           // double val3 = GetObjectArea(new Circle());
        }
    }

    public class Circle { }

    public class Square: ITableBase
    {
        public double H { get; set; }
        public double W { get; set; }
        public double GetArea(double h, double w)
        {
            throw new NotImplementedException();
        }

        public double GetArea2(double h, double w)
        {
            throw new NotImplementedException();
        }
    }

    public class Rect : ITableBase
    {
        public double H { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double W { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double GetArea(double h, double w)
        {
            throw new NotImplementedException();
        }

        public double GetArea2(double h, double w)
        {
            throw new NotImplementedException();
        }
    }

}
