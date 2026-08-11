using System;
using System.Diagnostics.CodeAnalysis;

namespace Homeworkday4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.计算100以内偶数的和
            //int i = 0;
            //int sum = 0;
            //while (i <= 100)
            //{
            //    sum = sum + i;
            //    i = i + 2;
            //}
            //Console.WriteLine($"100以内偶数的和{sum},此时i为{i}");


            //2.显示出1000 - 2000年中所有的闰年，并以每行四个数的形式输出

            //int count = 0;
            //for (int i = 1000; i <= 2000; i++)
            //{
            //    if ((i % 4 == 0 && i % 100 != 0) || i % 400 == 0)
            //    {
            //        Console.Write(i + " ");
            //        count++;
            //        if (count % 4 == 0)
            //            Console.WriteLine();
            //    }
            //}


            //int i = 1000;
            //int count = 0;

            //while (i <= 2000)
            //{
            //    if ((i % 4 == 0 && i % 100 != 0) || i % 400 == 0)
            //    {
            //        Console.Write(i + " ");
            //        count++;
            //        if (count % 4 == 0) Console.WriteLine();
            //        i++;
            //    }
            //    else i++;
            //}



            //3.输出一个倒三角形，如下
            //for (int j = 9; j >= 1; j--)
            //{
            //    for (int i = 1; i <= j; i++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //4.用循环计算下面的结果
            //1 - 1 / 2 + 1 / 3 - 1 / 4 + ... -1 / 100

            //double sum1 = 0;
            //double sum2 = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0) sum1 -= 1.0 / i;
            //    else sum2 += 1.0 / i;
            //}
            //Console.WriteLine($"{sum1}");
            //Console.WriteLine($"{sum2}");
            //Console.WriteLine($"{sum1 + sum2}");

            //5.求10以内所有数字的阶乘的和
            //int product = 1;
            //int sum = 0;
            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i == 0)
            //        product = 1;
            //    else
            //        product *= i;

            //    sum += product;
            //    Console.WriteLine($"{i}! = {product}, 当前和: {sum}");
            //}
            //Console.WriteLine($"10以内所有数字的阶乘的和{sum}");


            //6.篮球从5米高的地方掉下来，每次弹起的高度是原来的30 %，经过几次弹起，篮球的高度小于0.1米。
            //int count = 0;
            //for (double height = 5.0; height >= 0.1; height *= 0.3)
            //{
            //    count++;
            //}
            //Console.WriteLine($"经过{count}次弹起，篮球的高度小于0.1米");

            //7.有一个棋盘，有64个方格，在第一个方格里面放1粒芝麻重量是0.00001kg，第二个里面放2粒，第三个里面放4，棋盘上放的所有芝麻的重量
            //double weight = 0;
            //double sum = 0;
            //for (double n = 0; n <= 64; n++)
            //{
            //    if (n == 0) sum = 1;
            //    else sum += Math.Pow(2, n - 1);
            //    Console.WriteLine($"共{sum}粒芝麻");

            //    weight = sum * 0.00001;
            //    Console.WriteLine($"棋盘上放的所有芝麻的重量{weight}kg");
            //}

            //8.某人在银行有50000元存款。银行每月都要收取服务费，存款大于5000元时每个月收取总额的5 %，总额不大于5000元的时候不收服务费；假设这个人存了以后从来都不用，用循环计算银行要扣这个人的手续费能扣多少次？每次扣取后剩余多少钱？
            //int count = 0;
            //double money = 50000;
            //for (; money > 5000; money -= money * 0.05)
            //{

            //    Console.WriteLine($"第{count}次扣款");
            //    Console.WriteLine($"剩余{money}");
            //    count++;
            //}
            //Console.WriteLine($"银行要扣这个人的手续费扣{count}次,扣取最后剩余{money}");

            //int count = 0;
            //double money = 50000;
            //for (; money > 5000; )
            //{
            //    money -= money * 0.05;
            //         count++;
            //    Console.WriteLine($"第{count}次扣款");
            //    Console.WriteLine($"剩余{money}");

            //}
            //Console.WriteLine($"银行要扣这个人的手续费扣{count}次,扣取最后剩余{money}");


            //9.猴子摘桃，猴子摘了x个桃，每天吃一半，再多吃一个，第7天吃的时候剩下一个了，猴子摘了多少桃子？
            //int x = 1;
            //for (int i = 1; i < 7; i++)
            //{
            //    x = (x + 1) * 2;
            //}
            //Console.WriteLine($"猴子摘了{x}个桃子");

            //10.有个皮球，每次落地弹起都是高度的一半，如果从10米高的地方丢下，第十次弹起时，皮球总过经历了多少距离。
            //double height = 10;
            //double sum = 10;
            //for (int i = 1; i <=10; i++)
            //{
            //    //sum += height;
            //    height = height*0.5;
            //    sum += height*2;
            //    Console.WriteLine($"第{i}次,皮球总过经历了{height}米,皮球总过经历了{sum}米");
            //}


            //double height = 10;
            //double sum = 10;
            //for (int i = 1; i <= 10; i++)
            //{
            //    height = height * 0.5;
            //    if (i < 10) sum += 2 * height;
            //    else sum += height;

            //    Console.WriteLine($"第{i}次,皮球弹起了{height}米，皮球总过经历了{sum}米");
            //}

            //double height = 10;
            //double sum = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    sum += height * 1.5;
            //    height = 0.5 * height;
            //    Console.WriteLine($"第{i}次,皮球弹起了{height}米，皮球总过经历了{sum}米");
            //}
            //
        }

    }
}

