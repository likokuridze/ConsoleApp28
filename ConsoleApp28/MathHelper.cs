
namespace ConsoleApp28
{
    public static class MathHelper
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Divide(int a, int b)
        {
            // თუ b არის 0, ვისვრით Exception-ს
            if (b == 0)
            {
                throw new Exception("ნულზე გაყოფა შეუძლებელია!");
            }
            return (double)a / b;
        }
    }
}
