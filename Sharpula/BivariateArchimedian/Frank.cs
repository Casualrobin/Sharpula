using System;
namespace Sharpula.BivariateArchimedian
{
    public class Frank : IBivariateArchimedean
    {
        private double _u;
        private double _v;
        private double _theta;

        public Frank(double u, double v, double theta)
        {
            //TODO: need to zero check here as well.
            _theta = Validate.Clamp(theta, double.NegativeInfinity, double.PositiveInfinity);
            _u = u;
            _v = v;
        }

        public double BivariateCopula(double u, double v, double theta)
        {
            var expression = (Math.Exp(-theta * u) - 1) * (Math.Exp(-theta * v) - 1);
            expression = expression / (Math.Exp(-theta) - 1);
            expression = Math.Log(1 + expression);
            expression = (-1 / theta) * expression;
            return expression;
        }

        public double Generator(double theta, double t)
        {
            var expression = (Math.Exp(-theta*t)-1)/(Math.Exp(-theta)-1);
            return -Math.Log(expression);
        }

        public double GeneratorInverse(double theta, double t)
        {
            var expression = 1 + Math.Exp(t)*(Math.Exp(-theta)-1);
            expression = Math.Log(expression);
            return (-1 / theta) * expression;
        }
    }
}
