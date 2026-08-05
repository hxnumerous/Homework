namespace _03EX
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1.小明择偶标准：要么资产在300w以上，要么颜值大于9.5。输入小红的资产和颜值
            //Console.WriteLine("请输入资产(w)：");
            //int money = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入颜值：");
            //double beauty = double.Parse(Console.ReadLine());
            //bool res = money > 300 || beauty > 9.5;
            //Console.WriteLine(res);

            //2.小红想做车模，车模条件年龄16~22
            //Console.WriteLine("请输入您的年龄：");
            //int age = int.Parse(Console.ReadLine());
            ////bool res = age >= 16 && age <= 22;
            //bool res = !( age < 16 || age >22);
            //Console.WriteLine(res);


            //3.根据输入的成绩判断是不及格(小于60),及格(大于60小于80), 良好(大于80小于90),优秀(大于90小于100)
            //Console.WriteLine("请输入您的成绩：");
            //int score = int.Parse(Console.ReadLine());
            //if(score < 60)
            //{
            //    Console.WriteLine($"成绩+{score}  -不及格");
            //}
            //else if(score < 80)
            //{
            //    Console.WriteLine($"成绩:{score}  -及格");
            //}
            //else if (score < 90)
            //{
            //    Console.WriteLine($"成绩:{score}  -良好");
            //}
            //else if (score <= 100)
            //{
            //    Console.WriteLine($"成绩:{score}  -优秀");
            //}


            //4.输入年份，判断是否是闰年(普通闰年：能被4整除但不能被100整除/世纪闰年：可以被400整除)
            //Console.WriteLine("请输入要查询的年份：");
            //int year = int.Parse(Console.ReadLine());
            //if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            //{
            //    Console.WriteLine($"{year}是闰年");
            //}
            //else
            //{
            //    Console.WriteLine($"{year}是平年");
            //}


            //5.输出星期几
            //Console.WriteLine("请输入数字1~7：");
            //int n = int.Parse(Console.ReadLine());
            //switch (n)
            //{
            //    case 1:
            //        Console.WriteLine("星期一");
            //        break;
            //    case 2:
            //        Console.WriteLine("星期二");
            //        break;
            //    case 3:
            //        Console.WriteLine("星期三");
            //        break;
            //    case 4:
            //        Console.WriteLine("星期四");
            //        break;
            //    case 5:
            //        Console.WriteLine("星期五");
            //        break;
            //    case 6:
            //        Console.WriteLine("星期六");
            //        break;
            //    case 7:
            //        Console.WriteLine("星期天");
            //        break;
            //    default:
            //        Console.WriteLine("请从新输入数字");
            //        break;
            //}


            //6. 输入分数 1~100
            // 判断等级输出
            // 分数90~100  输出A  ===> 分数的十位9 / 10
            // 分数80~90   输出B  ===> 分数的十位8
            // 分数70~80   输出C  ===> 分数的十位7
            // 分数60~70   输出D  ===> 分数的十位6
            // 分数1~60    输出F  ===> 分数的十位0/1/2/3/4/5
            //Console.WriteLine("请输入您的分数：");
            //int score = int.Parse(Console.ReadLine());
            //if (score < 0 || score > 100)
            //{
            //    Console.WriteLine("请从新输入分数");
            //}
            //else
            //{
            //    switch (score / 10)
            //    {
            //        case 0:
            //            Console.WriteLine($"分数{score}是F等级");
            //            break;
            //        case 1:
            //            Console.WriteLine($"分数{score}是F等级");
            //            break;
            //        case 2:
            //            Console.WriteLine($"分数{score}是F等级");
            //            break;
            //        case 3:
            //            Console.WriteLine($"分数{score}是F等级");
            //            break;
            //        case 4:
            //            Console.WriteLine($"分数{score}是F等级");
            //            break;
            //        case 5:
            //            Console.WriteLine($"分数{score}是F等级");
            //            break;
            //        case 6:
            //            Console.WriteLine($"分数{score}是D等级");
            //            break;
            //        case 7:
            //            Console.WriteLine($"分数{score}是C等级");
            //            break;
            //        case 8:
            //            Console.WriteLine($"分数{score}是B等级");
            //            break;
            //        case 9:
            //            Console.WriteLine($"分数{score}是A等级");
            //            break;
            //        case 10:
            //            Console.WriteLine($"分数{score}是A等级");
            //            break;
            //    }
            //}


            // 7.输出星期几  6-7输出周末  穿透写法
            //Console.WriteLine("请输入数字1~7：");
            //int n = int.Parse(Console.ReadLine());
            //switch (n)
            //{
            //    case 1: Console.WriteLine("星期一");break;
            //    case 2:Console.WriteLine("星期二");break;
            //    case 3:Console.WriteLine("星期三");break;
            //    case 4:Console.WriteLine("星期四");break;
            //    case 5:Console.WriteLine("星期五");break;
            //    case 6:
            //    case 7:Console.WriteLine("周末");break;
            //    default:Console.WriteLine("请从新输入数字");break;
            //}

            //8.成绩等级输出 switch 简写
            //Console.WriteLine("请输入您的分数：");
            //int score = int.Parse(Console.ReadLine());
            //if (score < 0 || score > 100) Console.WriteLine("请从新输入分数");
            //else
            //{
            //    String res = score switch
            //    {
            //        >= 90 => "A",
            //        >= 80 => "B",
            //        >= 70 => "C",
            //        >= 60 => "D",
            //        >= 0 => "E",
            //    };
            //    Console.WriteLine($"{score}--{res}--");
            //}


            //9.三元表达式: 判断 成年了/ 未成年
            //Console.WriteLine("请输入您的年龄：");
            //int age =int.Parse(Console.ReadLine());
            //string res1 = age >= 18 ?"成年了":"未成年";
            //    Console.WriteLine(res1);
            //}

            //10.三元表达式: 判断 闰年(能被4整除但不能被100整除, 能被400整除) 平年
            //Console.WriteLine("请输入要查询的年份：");
            //int year = int.Parse(Console.ReadLine());
            //string res2 = year % 4 == 0 && year % 100 != 0 || year % 400 == 0 ? "是闰年" : "是平年";
            //Console.WriteLine($"{year}{res2}");

            //11.奇数偶数判断
            //Console.WriteLine("请输入数字：");
            //int num = int.Parse(Console.ReadLine());
            //String res3 = num % 2 == 0 ? "偶数" : "奇数";
            //Console.WriteLine($"{num}是{res3}");

            //12.是否在线 1/2
            //int n = 1;
            //Console.WriteLine(n == 1 ? "在线":"离线");



            //13.文件大小单位不同（1024以下kb / 以上MB）
            //Console.WriteLine("输入文件大小：");
            //int m = int.Parse( Console.ReadLine());
            //string res4 = m > 1024 ? (m/1024)+"M"+m % 1024 +"kb" : m+"kb";
            //Console.WriteLine($"文件大小{res4}");

            //14.数学运算计算器：让用户输入两个数字，再输入一个运算符(+-* /)，判断输入的运算符是什么，对两个数字进行对应的数学运算，将结果输出
            //Console.WriteLine("请输入第一个数字");
            //int n1 =int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入第二个数字");
            //int n2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入运算符号 + - * / %");
            //String opt = Console.ReadLine();

            //switch (opt)
            //{
            //    case "+": Console.WriteLine($"n1{opt}n2 = {n1 + n2}"); break;
            //    case "-": Console.WriteLine($"n1{opt}n2 = {n1 - n2}"); break;
            //    case "*": Console.WriteLine($"n1{opt}n2 = {n1 * n2}"); break;
            //    case "/": 
            //        if(n2 == 0) Console.WriteLine("除数不能为0");
            //        else Console.WriteLine($"n1{opt}n2 = {n1 / n2}"); break;
            //    case "%": Console.WriteLine($"n1{opt}n2 = {n1 % n2}"); break;
            //    default: Console.WriteLine("运算符有误");break;
            //}



            //15.不同血型不同性格：输入血型，当血型为A时，输出"细心稳重"；当血型为B时，输出"乐观自由"；当血型为AB时，输出"思维多变"；当血型为O时，输出"热情外向"
            //Console.WriteLine("请输入您的血型：");
            //string blood =  Console.ReadLine();
            //String res5 = blood switch
            //{
            //    "A" => "细心稳重",
            //    "B" => "乐观自由",
            //    "AB" => "思维多变",
            //    "O" => "热情外向",
            //};
            //Console.WriteLine($"{blood}为{res5}");
        }
    }
}