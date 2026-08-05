using System;

namespace Homeworkday3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.账号密码验证（练习分支嵌套）：账号规定是"admin"，密码规定是"123456"。让用户输入账号和密码，判断账号和密码是否正确，账号和密码都正确就输出登入成功；账号不对，就输出账号不存在；密码不对，就输出密码错误。
            //Console.WriteLine("请输入账号：");
            //string username = Console.ReadLine();
            //Console.WriteLine("请输入密码：");
            //string password = Console.ReadLine();
            ////        Console.WriteLine("密码错误");
            //String res = username == "admin" ? (password == "123456" ? "登陆成功" : "密码错误") : "账号不存在";
            //Console.WriteLine($"{res}");

            //if(username == "admin")
            //{
            //    if (password == "123456")
            //    {
            //        Console.WriteLine("登陆成功");
            //    }
            //    else
            //    {
            //        Console.WriteLine("密码错误");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("账号不存在");
            //}

            //2.选择菜单（add / edit / del）执行操作（练习多分支和switch）：提示用户选择菜单（add / edit / del），判断输入的是add，就输出新增成功；输入的是edit，就输出编辑成功；输入的是del，就输出删除成功。
            //Console.WriteLine(" add / edit / del ");
            //Console.WriteLine("请输出选择:");
            //string opt = Console.ReadLine();
            //String res1 = opt switch
            //{
            //    "add" => "新增成功",
            //    "edit" => "编辑成功",
            //    "del" => "删除成功",
            //    _ => "输入选项有误",
            //};
            //Console.WriteLine($"{res1}");

            //3.会员打折满1000打9折，普通用户满2000打9.5折（练习多分支和分支嵌套）：让用户输入自己的类型（VIP / USER）和消费金额，如果是VIP，判断消费金额是否达到1000，如果达到了，就输出他应该支付的金额，如果没有达到，也输出他应该支付的金额；如果是USER，判断消费金额是否达到2000，如果达到了和没有达到，都输出他应该支付的金额。
            //    Console.WriteLine(" 请输入您的类型（VIP / USER）： ");
            //    String opt1 =Console.ReadLine();
            //    Console.WriteLine("请输入您的消费金额：");
            //    int money = int.Parse(Console.ReadLine());
            //    if (opt1 == "VIP")
            //    {
            //        if (money >= 1000) Console.WriteLine($"您消费了:{money * 0.9}");
            //        else if(money >= 0) Console.WriteLine($"您消费了:{money}");
            //        else Console.WriteLine("你输入的金额有误");
            //    }
            //    else if( opt1 == "USER")
            //    {
            //        if (money >= 2000) Console.WriteLine($"您消费了:{money * 0.95}");
            //        else if (money >= 0) Console.WriteLine($"您消费了:{money}");
            //        else Console.WriteLine("你输入的金额有误");
            //    }
            //    else Console.WriteLine("用户选择错误请重新输入");

            //4.通过月份判断季节（练习switch的穿透写法）：用户输入月份，判断月份如果是3、4、5月份，就输出这是春季；如果是6、7、8月份，就输出这是夏季；如果是9、10、11月份，就输出这是秋季，如果是12、1、2月份，就输出这是冬季。
            //Console.WriteLine("请输入月份(1~12):");
            //int month = int.Parse(Console.ReadLine());
            //switch (month)
            //{
            //    case 3: 
            //    case 4:
            //    case 5: Console.WriteLine("春季"); break;
            //    case 6:
            //    case 7:
            //    case 8: Console.WriteLine("夏季"); break;
            //    case 9:
            //    case 10:
            //    case 11: Console.WriteLine("秋季"); break;
            //    case 1:
            //    case 2:
            //    case 12: Console.WriteLine("冬季"); break;
            //    default: Console.WriteLine("月份输入错误");break;
            //}

            //5.快递运费（练习多分支）：输入快递重量，单位是Kg，如果重量小于1Kg，输出快递费10元；如果重量在1Kg~5Kg之间，就输出快递费20元；如果重量超过5Kg，就输出快递费50元。
            //Console.WriteLine("请输入所寄快递重量(Kg):");
            //int weight = int.Parse(Console.ReadLine());
            //if (weight <= 1 && weight > 0) Console.WriteLine("快递费10元");
            //else if (weight > 1 && weight <= 5) Console.WriteLine("快递费20元");
            //else if (weight > 5 ) Console.WriteLine("快递费50元");
            //else Console.WriteLine("输入的重量有误，请重新输入");

            //6.会员等级优惠（练习多分支和switch）：输入会员等级，等级是3~5的整数，判断等级如果是5，输出终身免运费；等级是4，输出每月可领优惠券；等级是3，输出购物打9折，否则没有福利。
            //Console.WriteLine("请输入会员等级(3~5):");
            //int grade = int.Parse(Console.ReadLine());
            //String res2 = grade switch
            //{
            //    3 => "购物打9折",
            //    4 => "每月可领优惠券",
            //    5 => "终身免运费",
            //    _ => "没有福利"
            //};
            //Console.WriteLine($"{res2}");

            //7.自动售货机选商品（练习多分支和switch）：输入商品编号整数，1就输出已购买可乐；2输出已购买雪碧；3输出已购买矿泉水；否则输出无此商品。
            //Console.WriteLine("请输入商品编号:");
            //int num = int.Parse(Console.ReadLine());
            //String res3 = num switch
            //{
            //    1 => "已购买可乐",
            //    2 => "已购买雪碧",
            //    3 => "已购买矿泉水",
            //    _ => "无此商品"
            //};
            //Console.WriteLine($"{res3}");

            //8.速度分级（练习多分支）：输入当前速度，如果在0~30，输出低速通过；30~60输出中速通过；60~100输出高速通过；100~120输出超速通过。
            //Console.WriteLine("请输入当前速度:");
            //int speed = int.Parse(Console.ReadLine());
            //String res4 = speed switch
            //{
            //    <30 => "低速通过",
            //    <60 => "中速通过",
            //    <100 => "高速通过",
            //    <120 => "超速通过",
            //    _ => "速度输入错误"
            //};
            //Console.WriteLine($"{res4}");


        }
    }
}
