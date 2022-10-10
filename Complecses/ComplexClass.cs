using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complecses
{
    class ComplexClass
    {               
        private double im;

        public double Im
        {
            get { return im; }
            set { im = value; }
        }

        private double re;

        public double Re
        {
            get { return re; }
            set { re = value; }
        }

        public ComplexClass(double Re, double Im)
        {
            this.im = Im;
            this.re = Re;
        }

        public ComplexClass Plus(ComplexClass x)
        {
            var y = new ComplexClass(Re, Im);
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        public ComplexClass Subtract(ComplexClass x)
        {
            var y = new ComplexClass(Re, Im);
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

        public ComplexClass Divide(ComplexClass x)
        {
            var y = new ComplexClass(Re,Im);
            if (x.im == 0 || x.re == 0)
            {
                throw new Exception("На ноль делить нельзя!");
            }
            y.im = im / x.im;
            y.re = re / x.re;
            return y;
        }

        public ComplexClass Multi(ComplexClass x)
        {
            var y = new ComplexClass(Re, Im); 
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public override string ToString()
        {
            return re + "+" + im + "i";
        }
        
    }
}
