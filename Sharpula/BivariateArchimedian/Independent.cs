using System;
namespace Sharpula.BivariateArchimedian
{
    public class Independent : IBivariateArchimedean
    {
        private double _u;
        private double _v;
        private double _theta;

        //TODO: figure out if we can enforce the ctor to take these args. if not, theta not needed/wanted.
        public Independent(double u, double v, double theta = 0)
        {
            _theta = Validate.Clamp(theta, 0, 0);
            _u = u;
            _v = v;
        }

        public double BivariateCopula(double u, double v, double theta)
        {
            return u * v;
        }

        public double Generator(double theta, double t)
        {
            return -Math.Log(t);
        }

        public double GeneratorInverse(double theta, double t)
        {
            return Math.Exp(-t);
        }
    }
}
