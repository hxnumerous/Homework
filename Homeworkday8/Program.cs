using System;

namespace Homework08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var 函数名 = () => { };// 这种定义方式属于自动推导 函数的类型

            //返回值类型 函数名() { }  // 具名函数

            //// 定义没有返回值的函数的类型
            //Action<参数类型> 函数名 = () => { };

            //// 定义带返回值的函数的类型
            //Func < 参数类型, ..., 返回值类型 > 函数名 = delegate () { };
            //Func < 参数类型, ..., 返回值类型 > 函数名 = () => { };



            //1.装修房间：参数1，圆的半径，计算圆的面积，每平方米收费200元，返回装修总价。计算这个半径的圆装修一半需要多少钱？
            //Console.WriteLine("请输入圆的半径r");
            //int r=int.Parse(Console.ReadLine());
            //double money;
            //double area  () 
            //{
            //    double s = Math.PI*Math.Pow(2, r);
            //    return s;
            //}

            //money =area() * 0.5 * 200;
            //Console.WriteLine(money);



            //2.计算字符在字符串中出现的次数：参数1字符串，参数2某个字符，函数统计次数，并返回。
            //string str = "qwerysssssqqqqwwweee";

            //int count = 0;
            //Func<string,char, int> countnum = (str , str1) =>
            //{
            //    for (int i = 0; i < str.Length; i++)
            //    {
            //        if (str1 == str[i])
            //        {
            //            count++;
            //        }
            //    }
            //    return count;

            //};
            //int res =countnum(str,'s');
            //Console.WriteLine(res);

            //3.计算一个整型数组中，最小值第一次出现的下标。
            //int[] arr = [10, 20, 5, 30, 50, 6, 7];

            //Func<int[],int> Minnum = (arr1) =>
            //{
            //    int index = 0;
            //    for (int i = 0; i < arr1.Length; i++)
            //    {
            //        if (arr1[i] < arr1[index])
            //        {
            //            index = i;
            //        }
            //    }
            //    return index;
            //};
            //int res = Minnum(arr);
            //Console.WriteLine($"最小值 {arr[res]} 第一次出现在下标 {res}");

            //4.判断一个字符串是否为回文，返回布尔值类型。
            //string str = "abcdcba";
            //Func<string, bool> func = (str) =>
            //{
            //// 将字符串转为字符数组
            //char[] charArray = str.ToCharArray();
            //// 反转字符数组
            //Array.Reverse(charArray);
            //// 将反转后的字符数组转回字符串
            //string reversedStr = new string(charArray);

            //return str == reversedStr;

            //};
            //var result = func(str);
            //Console.WriteLine(result);


            //string str = "abcdcba";
            //Func<string, bool> func = (str) =>
            //{
            //    // 将字符串转为字符数组
            //    char[] charArray = str.ToCharArray();
            //    // 反转字符数组
            //    Array.Reverse(charArray);
            //    // 将反转后的字符数组转回字符串
            //    string reversedStr = new string(charArray);

            //    for (int i = 0; i < str.Length/2; i++)
            //    {
            //        if (str[i]!=reversedStr[i])
            //            return false;
            //    }
            //    return true;
            //};
            //var result = func(str);
            //Console.WriteLine(result);



            //5.用函数封装一个猜数字的小游戏，函数中生成一个随机整数（0 - 100）作为目标数字，不停的让用户输入数字，距离目标数字偏大，就提示用户偏大，距离目标数字偏小就输出偏小，用户有5次输入的机会，5次没有猜对，输出GAME OVER，猜对了就输出WIN！
           // Console.WriteLine("请输入一个数字(0-100)");
           // int m = Random.Shared.Next(101);
           // int count = 0;
           //// Console.WriteLine(m);
           // void redomnum(int guessnum)
           // {
           //     for (int i = 1; i <= 5; i++)
           //     {
           //         Console.Write($"第{i}次输入: ");

           //         int n = int.Parse(Console.ReadLine());

           //         if (guessnum == n)
           //         {
           //             Console.WriteLine("输出WIN");
           //             break;
           //         }
           //         else if (n > guessnum)
           //         {
           //             Console.WriteLine("距离目标数字偏大");
           //         }
           //         else if (n < guessnum)
           //         {
           //             Console.WriteLine("距离目标数字偏小");
           //         }
           //         count++;
           //         if (count == 5)
           //         {
           //             Console.WriteLine($"GAME OVER,答案为{m}");
           //             break;
           //         }
           //     }
           // }
           // redomnum(m);


        }
    }
}
