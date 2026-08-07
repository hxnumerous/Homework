namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum = sum + i;
            //    i++;
            //}
            //Console.WriteLine($"和为{sum}");

            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum = sum + i;
            //    i = i + 2;
            //}
            //Console.WriteLine($"和为{sum}");


            //do while循环结构
            //输出1 - 5
            //int i = 1;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //while (i<=5);



            //for循环结构
            //输出5句“我爱你”
            //for (int i = 1; i <=5 ; i++)
            //{
            //    Console.WriteLine("我爱你");
            //}


            //变化规律
            //倒着输出1 - 10
            //for (int i = 10; i >=1; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //输出1 - 10之间的偶数
            //for (int i = 10; i >= 1; i--)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //while的例子
            //入职薪水10K，每年涨幅5 %，50年后工资多少？
            //double money = 10;
            //int year = 1;
            //double sum = 0;
            //while (year <= 50)
            //{
            //    money = money +money  * 0.05 ;
            //    sum += money;
            //    year++;
            //}
            //Console.WriteLine($"50年后的工资{money}获得总工资{sum}");

            //遍历List
            //List<string> strList = new()
            //{
            //    "aa",
            //    "bb",
            //    "ccc",
            //    "dd",
            //    "eee"
            //};
            //for (int i = 0; i < strList.Count; i++)
            //{
            //    Console.WriteLine(strList[i]);
            //}


            //求int型List的所有数据之和
            //List<int> intList = new()
            //{
            //    3,
            //    5,
            //    7,
            //    2,
            //    9
            //};
            //int sum =0;
            //for (int i = 0; i < intList.Count; i++)
            //{
            //    sum += intList[i];

            //}
            //Console.WriteLine(sum);

            // 判断一个数是否是素数 (素数，就是除了1和自己本身，不能被别的数整除)
            // 素数，就是除了1和自己本身，不能被别的数整除


            //continue语句
            //Console.WriteLine("请输入一个整数：");
            //int m = int.Parse(Console.ReadLine());
            //int count = 0;
            //for (int i = 1; i <= m; i++)
            //{
            //    if (i == 1 || i == m) continue;
            //    if (m % i == 0) count++;
            //}
            //if (count > 1)
            //{
            //    Console.WriteLine($"{m}不是素数");
            //    count++;
            //}
            //else Console.WriteLine($"{m}是素数");


            //int m = 11; // 判断m是否是素数
            //string s = "黑色"; // 开关
            //                 // 循环1~9的每个数字, 并判断是否可以将m整除, 如果可以 则将s 改为"白色"
            //for (int i = 1; i <= m; i++)
            //{
            //    // 如果i是 1 或者m本身 则跳过循环
            //    if (i == 1 || i == m)
            //    {
            //        continue;
            //    }
            //    // 判断i能否将m整除
            //    if (m % i == 0)
            //    {
            //        s = "白色";
            //    }
            //}
            //// 循环结束后 ==> 判断s的值, 如果是 "黑色" 说明m是素数
            //// 如果s 是 白色 说明m不是素数
            //if (s == "黑色")
            //{
            //    Console.WriteLine($"{m}是素数");
            //}

            //break语句
            //Console.WriteLine("请输入一个整数：");
            //int m = int.Parse(Console.ReadLine());
            //int count = 0;
            //for (int i = 1; i <= m; i++)
            //{
            //    if (m % i == 0) count++;

            //    if (i == m) break;
            //}
            //if (count > 2)
            //{
            //    Console.WriteLine($"{m}不是素数");
            //    count++;
            //}
            //else Console.WriteLine($"{m}是素数");


            //输出九九乘法表
            //for (int j = 1; j <= 9; j++)
            //{
            //    Console.Write(j+" ");
            //    for (int i = 1; i < j; i++)
            //    {
            //        Console.Write($"{i}*{j}={i*j}\t");
            //    }
            //    Console.WriteLine();
            //}

            //foreach 遍历数组
            int[] intArr = { 10, 20, 30, 40 };
            foreach (int item in intArr)
            {
                Console.WriteLine(item);
            }



        }
    }
}
