using System.Globalization;
using System.Text.RegularExpressions;

namespace EX06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Replace：将字符串中指定的子串都替换成的新的子串
            //string str = "abacdaeafeeg";
            ////Console.WriteLine(str.Replace("a","0"));
            //Console.WriteLine(str.Replace("ee","**"));

            //// 敏感词替换为 * , 而且个数要保持一致
            //string str = "生活总会有大麻烦, 黑夜总会过去";
            //// 假设list存储敏感词
            //List<string> mgc = ["大麻", "夜总会"];
            //foreach (var mgcstr in mgc)
            //{
            //    if (mgc.Contains(mgcstr) )
            //    {
            //        string  replacement = new string('*', mgcstr.Length);
            //        str = str.Replace(mgcstr,replacement);
            //    }
            //}
            //Console.WriteLine(str);
            //// 生活总会有**烦, 黑***过去


            //string str = "生活总会有大麻烦, 黑夜总会过去";
            //// 假设list存储敏感词
            //List<string> mgc = ["大麻", "夜总会"];
            ////遍历mgc 里的数据
            //foreach (string item in mgc)
            //{
            //    //创建新的字符串，用*来代替mgc
            //    string  str1 = "";
            //    //循环敏感词个数，来判断有几个*
            //    for (int i = 0; i < item.Length; i++)
            //    {
            //         str1 += "*";
            //    }
            //    //用新创建的*字符串 来替换遍历数据中的敏感词
            //    str = str.Replace(item,str1);
            //}
            ////输出验证
            //Console.WriteLine(str);


            //string oldStr = "you love i";
            ////将字符串分割开放入数组中
            //string[] arr =oldStr.Split();
            ////将数组数据放入List集合
            //List<string> StrList = new ();
            //foreach (string str in arr) StrList.Add(str);
            //StrList.Reverse();
            ////创建一个字符串作为最后的结果
            //string resStr = "";
            ////将得到的字符串进行遍历，将首字母大写
            //foreach (var item in StrList)
            //{
            //    string firstLetter = item.Substring(0, 1).ToUpper();
            //    string otherLetters = item.Substring(1).ToLower();
            //    resStr += firstLetter + otherLetters + " ";
            //}
            //Console.WriteLine(resStr.Substring(0,resStr.Length-1));

            //string reg = @"a";
            //String str = "bac";
            //var res = Regex.Matches(str, reg);
            //Console.WriteLine(res);

            //-手机号
            //第一位为1 第二位不为0 共11位 \d任意一位数字
            //var reg1 = @"^1[1-9]\d{9}";
            //Console.WriteLine(Regex.IsMatch("12345678911", reg1));
            //- qq号
            //第一位不能为0 4-8位
            //var reg2 = @"[1-9]\d{4,8}";
            //Console.WriteLine(Regex.IsMatch("12341", reg2));
            //- qq邮箱号
            //第一位不能为0 4-8位 @qq.com
            //var reg3 = @"[1-9]\d{4,8}@qq/.com";
            //Console.WriteLine(Regex.IsMatch("12341@qq/.com", reg3));
            //- 提取一句话中的所有工资
            //第一位不为0 3位以上
            //var str = "你的工资是：10000，我的工资是：3000，小明的工资是：20000";
            //var reg4 = @"[1-9]\d{3,}";
            //var res = Regex.Matches(str, reg4);
            //foreach (var item in res) Console.WriteLine(item);

        }
    }
}
