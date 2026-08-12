using System.Text.RegularExpressions;

namespace Homeworkday6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.提取一句话中所有的中文姓名
            //string str = "hello, I am 刘德华,your name is 黎明?";
            //var reg1 = @"[\u4e00-\u9fa5]{2,}";
            //var res =Regex.Matches(str, reg1);
            //foreach (var item in res) Console.WriteLine(item);

            //2.替换所有多余空格
            //string str1 = "abc  dd  ee  ff  gg  HH  h j k";
            //var reg2 = @"\s+";
            //string res1 = Regex.Replace(str1,reg2," ");
            //Console.WriteLine(res1);


            
            //string[] resArr = str1.Split();
            //string res1 = str1.Replace("  ", " ");
            //Console.WriteLine(res1);

            //3.身份证号码

            //// 书写正则, 找到字符串中的身份证号及 出生年,月,日
            //string str2 = "我的身份证号是: 360731200111052112,你的身份证是: 42108320041119211X";
            ////共18位 第一位不为0 最后一位为0-9 + X
            //var reg3 = @"[1-9]\d{16}[\d | X | x]";
            //var res2 = Regex.Matches(str2, reg3);
            //foreach (Match item in res2)
            //{
            //    Console.WriteLine(item);
            //    string year = item.Value.Substring(6, 4);
            //    string month = item.Value.Substring(10, 2);
            //    string day = item.Value.Substring(12, 2);
            //    Console.WriteLine($"{year}年{month}月{day}日");
            //}

            //4.密码强度检测：强中弱（字母、数字、特殊符号）
            // 请输入密码（字母、数字、特殊符号）

            //密码中可以有数字,字母,特殊符号;长度要求8~15 
            //如果只有一种则 强度为弱
            //如果只有两种则 强度为中
            //如果两种都有则 强度为强

            //验证密码长度是否符合,并输出密码强度

            //Console.WriteLine("请输入您的密码(8-15)：");
            //string password =Console.ReadLine();
            //var reg1 = @"[0-9]";    //  @"\d+"
            //var reg2 = @"[A-Za-z]"; //@"[A-Za-z]+"
            //var reg3 = @"[^0-9A-Za-z]";

            //bool a = Regex.IsMatch(password, reg1);
            //bool b = Regex.IsMatch(password, reg2);
            //bool c = Regex.IsMatch(password, reg3);

            //if (string.IsNullOrEmpty(password) || password.Length < 8 || password.Length > 15)
            //{
            //    Console.WriteLine("输入密码有误");

            //}
            //else
            //{
            //    if (a && b && c)
            //    {
            //        Console.WriteLine("密码强度强");
            //    }
            //    else if ((a && b) || (a && c) || (b && c))
            //    {
            //        Console.WriteLine("密码强度中等");
            //    }
            //    else if (a || b || c)
            //    {
            //        Console.WriteLine("密码强度较弱");
            //    }
            //    else
            //    {
            //        Console.WriteLine("密码有误");
            //    }
            //}

















        }
    }

}
   
