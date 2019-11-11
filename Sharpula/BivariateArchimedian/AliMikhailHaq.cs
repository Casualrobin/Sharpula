using System;
namespace Sharpula
{
    public class AliMikhailHaq : IBivariateArchimedean
    {
        private double _u;
        private double _v;
        private double _theta;

        public AliMikhailHaq(double u, double v, double theta)
        {
            _theta = Validate.Clamp(theta, -1, 1);
            _u = u;
            _v = v;
        }

        public double BivariateCopula(double u, double v, double theta)
        {
            var expression = u * v / (1 - theta * (1 - u) * (1 - v));
            return expression;
        }

        public double Generator(double theta, double t)
        {
            var expression = (1- theta*(1-t))/t;
            return Math.Log(expression);
        }

        public double GeneratorInverse(double theta, double t)
        {
            var expression = (1 - theta);
            return expression / (Math.Exp(t) - theta);
        }
    }
}
