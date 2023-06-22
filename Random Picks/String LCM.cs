namespace sp
{
    class Program
    {
        public static void Main(string[] args)
        {
            int test = int.Parse(Console.ReadLine());
            for (int i = 0; i < test; i++)
            {
                result();
            }
        }

        public static void result()
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();

            int l1 = s.Length;
            int l2 = t.Length;

            int LCM;

            if (l1 > l2)
            {
                LCM = Get_LCM(l1, l2);
            }
            else
            {
                LCM = Get_LCM(l2, l1);
            }

            l1 = LCM / l1 - 1;
            l2 = LCM / l2 - 1;

            string a = s;
            string b = t;

            for (int i = 0; i < l1; i++)
            {
                s += a;
            }

            for (int i = 0; i < l2; i++)
            {
                t += b;
            }

            if (s == t)
            {
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("-1");
            }
        }

        public static int Get_LCM(int a, int b)
        {
            int GCD = Get_GCD(a, b);
            int LCM = (a * b) / GCD;

            return LCM;
        }

        public static int Get_GCD(int a, int b)
        {
            if (a % b == 0)
            {
                return b;
            }
            else
            {
                int tmp = a;
                a = b;
                b = tmp % b;
                int remainder = Get_GCD(a, b);
                return remainder;
            }
        }
    }
}