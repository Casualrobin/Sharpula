using System;

namespace Sharpula.BivariateArchimedian
{
    public class Joe : IBivariateArchimedean
    {
        private double _u;
        private double _v;
        private double _theta;

        public Joe(double u, double v, double theta)
        {
            _theta = Validate.Clamp(theta, 1, double.PositiveInfinity);
            _u = u;
            _v = v;
        }

        public double BivariateCopula(double u, double v, double theta)
        {
            var expression = Math.Pow(1-u,theta) + Math.Pow(1-v,theta) - Math.Pow(1-u,theta) * Math.Pow(1-v,theta);
            expression = Math.Pow(expression, 1 / theta);
            return 1 - expression;
        }

        public double Generator(double theta, double t)
        {
            return -Math.Log(1 - Math.Pow(1-t, theta));
        }

        public double GeneratorInverse(double theta, double t)
        {
            return 1 - Math.Pow(1 - Math.Exp(-t), 1 / theta);
        }
    }
}
