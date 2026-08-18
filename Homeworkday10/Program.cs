using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.Json;
using System.Text.RegularExpressions;
namespace Homeworkday10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 作业1
            //    //作业: 使用读写文件配合命令行窗口 模拟实现注册功能要求输入用户名和密码,完成注册; (注册的用户信息记录在user.txt文件中, 一行一个用户信息 数据之间通过 === 分隔)
            //    Func<string, int> isFile = path =>
            //    {
            //        if (File.Exists(path)) return 1;
            //        return 0;
            //    };


            //    Func<string,string> regist = path =>
            //    {
            //        if (isFile(path) != 1)
            //        {
            //            File.WriteAllText(path, "");
            //        }

            //        Console.WriteLine("请输入用户名：");
            //        string Username = Console.ReadLine();

            //        if (string.IsNullOrWhiteSpace(Username))
            //        {
            //            return "注册失败：用户名不能为空";
            //        }

            //        Console.WriteLine("请输入密码：");
            //        string Password = Console.ReadLine();

            //        if (string.IsNullOrWhiteSpace(Password))
            //        {
            //            return "注册失败：密码不能为空";
            //        }

            //        if (File.Exists(path))
            //        {
            //            var lines = File.ReadAllLines(path);
            //            foreach (var line in lines)
            //            {
            //                if (string.IsNullOrWhiteSpace(line)) continue;
            //                var parts = line.Split(new[] { "===" }, StringSplitOptions.None);
            //                if (parts.Length > 0 && parts[0] == Username)
            //                {
            //                    return "注册失败：用户名已存在";
            //                }
            //            }
            //        }
            //        File.AppendAllText(path, $"{Username}==={Password}\n");
            //        return "注册成功！";
            //    };

            //    var path = "./user.txt";
            //    string result = regist(path);
            //    Console.WriteLine(result);
            //}
            #endregion


            //作业2扩展练习:  使用读写文件配合命令行窗口  模拟实现注册登录功能
            //进入就是菜单栏界面, 1注册,2登录,0退出
            //输入1 进入注册, 要求输入用户名,密码, 用户输入用户名和密码 则实现注册功能, 要求校验用户名和密码
            //输入2 进入登录, 要求输入用户名, 密码, 输入后完成登录校验功能; 登录成功提示 登录成功
            //输入0 退出程序,

            //-用户注册成功的用户信息 以文件的形式存储在user.json中(要求以json形式存储)
            // - [{ username: "",password: "",datetime: "时间戳"}]
            // -用户操作日志user.log: 用户每次操作都要有日志记录, 记录操作,用户名,操作方式,时间,如果有异常的,记录异常

            string num = ""; // 输入的指令
            string userReg = @"^[a-zA-Z][a-zA-Z0-9]{3,14}$";
            string pwdReg = @"^\S{4,12}$";
            string path = "./user.json";
            //序列化
            var JsonOpt = new JsonSerializerOptions
            {
                WriteIndented = true,
                AllowTrailingCommas = true,
            };

            // 定义的函数
            // 用户注册函数
            Func<string, string, string> register = (userName, pwd) =>
            {
                // 正则校验用户名和密码
                if (!Regex.IsMatch(userName, userReg) || !Regex.IsMatch(pwd, pwdReg)) return "用户名或密码格式错误!";

                //新建列表来存储
                List<Dictionary<string, dynamic>> userList = new();
                //组装用户信息字典
                Dictionary<string, dynamic> userdic = new Dictionary<string, dynamic>()
                {
                    ["username"] = userName,
                    ["password"] = pwd,
                    ["Date"] = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds(),


                };
                // 判断文件是否存在
                if (File.Exists(path))
                {
                    // 判断文件是否存在====>存在读取文件内容
                    //  反序列化转为List列表 ===> 组装用户信息字典
                    //  判断用户名是否已经注册===>如果注册过则返回信息
                    //  未注册===>将用户字典添加到List列表中
                    //  序列化List列表  =====> 写会回(覆盖)
                    var jsonStr = File.ReadAllText(path);
                    userList = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(jsonStr);
                    // 判断用户名是否已经注册
                    bool isRegister = userList.Exists(item => item["username"].ToString() == userName); // **
                    if (isRegister) return "用户已经存在!!!";
                }
                    // 添加到list
                    userList.Add(userDic);
                    var newJsonStr = JsonSerializer.Serialize(userList, JsonOpt);
                    // 写入文件
                    File.WriteAllText(path, newJsonStr);

                };

            // 用户登录函数
            Func<string, string, string> login = (userName, pwd) =>
            {
                // 正则校验用户名和密码
                // 正则校验用户名和密码
                if (!Regex.IsMatch(userName, userReg) || !Regex.IsMatch(pwd, pwdReg)) return "用户名或密码格式错误!";

                // 判断文件是否存在===>不存在, 请先注册
                // 判断文件是否存在
                if (!File.Exists(path)) return "请先注册!!!";
                //  读文件 ====> 反序列化 list
                var jsonStr = File.ReadAllText(path);
                var userList = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(jsonStr);
                // 使用输入的用户名 去list中查找(用户名和密码查找)
                var resUser = userList.Find(item => item["username"].ToString() == userName && item["password"].ToString() == pwd);
                // 找不到====>用户名或密码错误
                if (resUser == null) return "用户名或密码错误";
                // 密码一致===>登录成功
                return "登录成功";
            };

            while (num != "0")
            {
                // 提示信息
                Console.WriteLine("=====欢迎来到用户管理=====");
                Console.WriteLine("1: 用户注册");
                Console.WriteLine("2: 用户登录");
                Console.WriteLine("0: 退出");
                num = Console.ReadLine();

                string username = "youke";
                string result = "";

                switch (num)
                {
                    case "1":
                        Console.WriteLine("--用户注册--");
                        Console.WriteLine("请输入用户名(4~15)");
                        username = Console.ReadLine();
                        Console.WriteLine("请输入密码(4~12)");
                        var password = Console.ReadLine();
                        result = register(username, password);
                        Console.WriteLine(result);
                        break;
                    case "2":
                        Console.WriteLine("--用户登录--");
                        Console.WriteLine("请输入用户名(4~15)");
                        username = Console.ReadLine();
                        Console.WriteLine("请输入密码(4~12)");
                        var loginPpassword = Console.ReadLine();
                        result = login(username, loginPpassword);
                        Console.WriteLine(result);
                        break;
                    case "0":
                        Console.WriteLine("--退出--");
                        break;
                    default:
                        num = "3";
                        Console.WriteLine("输入有误");
                        break;
                }
                // 写日志: 用户名 操作类型 时间 操作结果
                string optStr = $"{username}---{optArr[int.Parse(num)]}---{DateTime.Now}---{result}\n";
                File.AppendAllText("./user.log", optStr);
            }



            #region //ziji
            //Func<string, int> isFile = path =>
            //{
            //    if (File.Exists(path)) return 1;
            //    return 0;
            //};

            //Func<string, string> regis = path =>
            //{
            //    if (isFile(path) != 1)
            //    {
            //        File.WriteAllText(path, "");
            //    }

            //    Console.WriteLine("请输入用户名：");
            //    string Username = Console.ReadLine();
            //    if (string.IsNullOrWhiteSpace(Username))
            //    {
            //        return "注册失败：用户名不能为空";
            //    }

            //    Console.WriteLine("请输入密码：");
            //    string Password = Console.ReadLine();

            //    if (string.IsNullOrWhiteSpace(Password))
            //    {
            //        return "注册失败：密码不能为空";
            //    }


            //    return "注册成功";
            //};


            //Func<string, string> login = path =>
            //{


            //    Console.WriteLine("请输入用户名：");
            //    string Username = Console.ReadLine();
            //    if (string.IsNullOrWhiteSpace(Username))
            //    {
            //        return "注册失败：用户名不能为空";
            //    }
            //    if ()
            //    {

            //    }

            //    Console.WriteLine("请输入密码：");
            //    string Password = Console.ReadLine();

            //    if (string.IsNullOrWhiteSpace(Password))
            //    {
            //        return "注册失败：密码不能为空";
            //    }


            //};
            //Func<string, string> system = path =>
            //{




            //    return "注册成功！";
            //};
            #endregion
        }
    }
}