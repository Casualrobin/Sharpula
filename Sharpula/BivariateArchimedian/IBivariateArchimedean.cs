namespace Sharpula
{
    public interface IBivariateArchimedean
    {
        public double BivariateCopula(double u, double v, double theta);

        public double Generator(double theta, double t);

        public double GeneratorInverse(double theta, double t);
    }
}