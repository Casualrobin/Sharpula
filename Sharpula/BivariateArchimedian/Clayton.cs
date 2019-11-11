using System;

namespace Sharpula
{
    public class Clayton : IBivariateArchimedean
    {
        private double _u;
        private double _v;
        private double _theta;

        public Clayton(double u, double v, double theta)
        {
            //TODO: need to zero check here as well.
            _theta = Validate.Clamp(theta, -1, double.PositiveInfinity);
            _u = u;
            _v = v;
        }

        public double BivariateCopula(double u, double v, double theta)
        {
            var expression = Math.Pow(u, -theta) + Math.Pow(v, -theta) - 1;
            expression = Math.Max(expression, 0);
            return Math.Pow(expression, -1 / theta);
        }

        public double Generator(double theta, double t)
        {
            return (1 / theta) * (Math.Pow(t, -theta) - 1);
        }

        public double GeneratorInverse(double theta, double t)
        {
            return Math.Pow(1 + theta * t, -1 / theta);
        }
    }
}
