using System;
namespace Sharpula.BivariateArchimedian
{
    public class Gumbel : IBivariateArchimedean
    {
        private double _u;
        private double _v;
        private double _theta;

        public Gumbel(double u, double v, double theta)
        {
            _theta = Validate.Clamp(theta, 1, double.PositiveInfinity);
            _u = u;
            _v = v;
        }

        public double BivariateCopula(double u, double v, double theta)
        {
            var expression = -Math.Pow((-Math.Log(u)), theta) + Math.Pow((-Math.Log(u)), theta);
            expression = Math.Exp(Math.Pow(-expression, 1 / theta));
            return expression;
        }

        public double Generator(double theta, double t)
        {
            return Math.Pow(-Math.Log(t), theta);
        }

        public double GeneratorInverse(double theta, double t)
        {
            return Math.Exp(Math.Pow(-t, 1/theta));
        }
    }
}
