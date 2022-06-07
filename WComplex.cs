using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class WComplex
{
    public double real;
    public double imaginary;



    public WComplex(double real, double imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }

    public static WComplex operator +(WComplex v1, WComplex v2)
    {
        return new WComplex(v1.real + v2.real, v1.imaginary + v2.imaginary);
    }
    public static WComplex operator -(WComplex v1, WComplex v2)
    {
        return new WComplex(v1.real - v2.real, v1.imaginary - v2.imaginary);
    }
    public static WComplex operator *(WComplex v1, WComplex v2)
    {
        return new WComplex(v1.real * v2.real - v1.imaginary * v2.imaginary, v1.real * v2.imaginary + v1.imaginary * v2.real);
    }
    public static WComplex operator /(WComplex v1, WComplex v2)
    {
        return new WComplex((v1.real * v2.real + v1.imaginary * v2.imaginary) / (Math.Pow(v2.real, 2)+ Math.Pow(v2.imaginary, 2)), (v1.imaginary * v2.real - v1.real * v2.imaginary) / (Math.Pow(v2.real, 2) + Math.Pow(v2.imaginary, 2)));
    }
}
