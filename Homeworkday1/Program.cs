namespace Homeworkday1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.计算任意两个输入数字的和
            Console.WriteLine("请输入第一个数字：");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个数字：");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"两个数字的和为：{a + b}");

            //2.小明要到美国旅游，可是那里的温度是以华氏度为单位记录的。他需要一个程序将华氏温度（80度）转换为摄氏度，并以华氏度和摄氏度为单位分别显示该温度（提示：摄氏度与芈氏度的转换公式为：摄氏度 = 5 / 9.0 * (华氏度 - 32)保留3位小数）
            Console.WriteLine("请输入华氏摄氏度：");
            double Hs = double.Parse(Console.ReadLine());
            Console.WriteLine($"华氏摄氏度为：{Hs}");
            double S;
            S = 5 / 9.0 * (Hs - 32);
            Console.WriteLine($"摄氏度为:{S:F3}");

            //3.通过数学运算交换两个整型变量的值
            Console.WriteLine("请输入第一个数字：");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个数字：");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"交换前: n1={n1}, n2={n2}");

            int c = n1 + n2;
            n1 = c - n1;
            n2 = c - n2;
            Console.WriteLine($"交换后: n1={n1}, n2={n2}");


            //为抵抗洪水，战士连续作战89小时，编程计算共多少天零多少小时？
            int H1 = 89;
            int H2 = H1 / 24;
            int H3 = H1 - (H2 * 24);
            Console.WriteLine($"共{H2}天{H3}时");
        }
    }
}
