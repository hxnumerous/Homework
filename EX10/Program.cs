using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EX10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //书写函数 实现写入日志操作, 日志内容: 输入内容 + 日期
            // 日志文件路径:  ./content.log

            //Action writelog = () =>
            //{
            //    Console.WriteLine("请输入内容");
            //    string res = Console.ReadLine();
            //    Console.WriteLine(res);
            //    var date = DateTime.Now;
            //    //Console.WriteLine(date.ToString("D"));
            //    var path1 = @"./content.log";
            //    File.WriteAllText(path1, res + "\n" + date.ToString("D") + "\n");
            //};


            //writelog();

            //Action Appendlog = () =>
            //{
            //    var date = DateTime.Now;
            //    //Console.WriteLine(date.ToString("D"));
            //    var path1 = @"./content.log";
            //    File.AppendAllText(path1, date.ToString("T") + "\n");
            //};

            //Appendlog();



            // var date = DateTime.Now;
            // //Console.WriteLine(date.ToString("D"));
            // var path1 = @"./content.log";
            // bool res = File.Exists(path1);
            // Console.WriteLine(res);



            //Action Copylog = () =>
            //{
            //    var date = DateTime.Now;
            //    //Console.WriteLine(date.ToString("D"));
            //    var path1 = @"./content.log";
            //    var newpath = @"./Copy_content.log";

            //    File.Copy(path1, newpath);
            //};

            //Copylog();

            //Action Deletelog = () =>
            //{
            //    var path2 = @"./Copy_content.log";
            //    File.Delete(path2);
            //};

            //Deletelog();

            //Action Movelog = () =>
            //{

            //    var path1 = @"./Copy_content.log";
            //    var path2 = @"./move/Copy_content.log";
            //    File.Move(path1,path2);
            //};

            //Movelog();



            // 定义一个函数, 一个参数(接收路径), 返回值0 表示啥也不是,1是文件,2是文件夹
            Func<string, int> isFileOrDir = path =>
            {
                if (File.Exists(path)) return 1;
                if (Directory.Exists(path)) return 2;
                return 0;

            };

            //string[] resarr = ["啥也不是", "是文件", "是文件夹"];
            //var path1 = "./";
            //var path2 = "./content.log";
            //int res = isFileOrDir(path2);
            //Console.WriteLine(resarr[res]);


            //案例：获取目录下所有目录和文件（一级）

            //Func<string, List<string>> getfileanddir = path =>
            //{
            //    List<string> reslist = [];
            //    if (isFileOrDir(path) != 2) throw new Exception("啥也不是");

            //    //创建一个数组用来接受目录和文件
            //    string[] file = Directory.GetFiles(path);
            //    //添加到list集合
            //    reslist.AddRange(file);

            //    // 获取所有的目录
            //    string[] dirs = Directory.GetDirectories(path);
            //    reslist.AddRange(dirs);

            //    return reslist;
            //};

            //var res = getfileanddir("./");
            //foreach (var item in res) Console.WriteLine(item);







        }
    }
}
