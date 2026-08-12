using System.Globalization;
using System.Text.RegularExpressions;

namespace EX07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";

            ////通过下标获取到情报内容：
            //string salt = "7-16-30-38-49-52-63-70";
            //string result = ""; // 最终获取到的情报

            //// 先将salt 转为数组
            //string[] nums = salt.Split("-");

            //// 遍历nums获取每个数字(字符串), 作为text的索引 
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    //nums[i] // 转换为整数 才能作为下标使用
            //    int index = int.Parse(nums[i]);
            //    result += text[index];
            //}

            //Console.WriteLine(result); // 午夜渡口交换情报

            /*********************************************************************/

            //通过情报内容获取到下标：
            //string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            //string salt = "午夜渡口交换情报";
            //// 创建一个list 用于未来的密文索引存储
            //List<int> list = [];
            ////遍历salt
            //for (int i = 0; i < salt.Length; i++)
            //{
            //    //  根据 salt[i] 去text中查找对应的下标
            //    int index = text.IndexOf(salt[i]);
            //    //将获取的下标添加到list集合中
            //    list.Add(index);
            //}
            ////通过join方法添加分割到list中
            //string res =string.Join("-", list);
            //Console.WriteLine(res);

            /*********************************************************************/
            //为了更安全，生成密文的时候可以调整下标：（上一个字符）：
            //string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            //string salt = "午夜渡口交换情报";
            //// 创建一个list 用于未来的密文索引存储
            //List<int> list = [];
            ////遍历salt
            //for (int i = 0; i < salt.Length; i++)
            //{
            //    //  根据 salt[i] 去text中查找对应的下标
            //    int index = text.IndexOf(salt[i]);
            //    //将获取的下标添加到list集合中
            //    list.Add(index-1);
            //}
            ////通过join方法添加分割到list中
            //string res = string.Join("-", list);
            //Console.WriteLine(res);// "6-15-29-37-48-51-62-69"

            /*********************************************************************/
            //通过密文获获取情报的时候，需要在原本的下标基础上 + 1：
            //string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            //// "6-15-29-37-48-51-62-69"
            ////通过下标获取到情报内容：
            //string salt = "6-15-29-37-48-51-62-69";
            //string result = ""; // 最终获取到的情报

            //// 先将salt 转为数组
            //string[] nums = salt.Split("-");

            //// 遍历nums获取每个数字(字符串), 作为text的索引 
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    //nums[i] // 转换为整数 才能作为下标使用
            //    int index = int.Parse(nums[i])+1;
            //    result += text[index];
            //}

            //Console.WriteLine(result); // 午夜渡口交换情报

            /*********************************************************************/
            //还可以在生成密文的时候，奇数就 - 1，偶数就 + 1：
            //string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            //string salt = "午夜渡口交换情报";
            //// 创建一个list 用于未来的密文索引存储
            //List<int> list = [];
            ////遍历salt
            //for (int i = 0; i < salt.Length; i++)
            //{
            //    //  根据 salt[i] 去text中查找对应的下标
            //    int index = text.IndexOf(salt[i]);
            //    //将获取的下标添加到list集合中
            //    index +=  index % 2 == 0 ?1:-1;
            //    list.Add(index);
            //}
            ////通过join方法添加分割到list中
            //string res = string.Join("-", list);
            //Console.WriteLine(res);// "6-17-31-39-48-53-62-71"

            /*********************************************************************/
            //此时找到情报的时候，也要判断下标是奇数还是偶数，奇数就 - 1，偶数就 + 1：
            //string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            //// "6-17-31-39-48-53-62-71"
            ////通过下标获取到情报内容：
            //string salt = "6-17-31-39-48-53-62-71";
            //string result = ""; // 最终获取到的情报

            //// 先将salt 转为数组
            //string[] nums = salt.Split("-");

            //// 遍历nums获取每个数字(字符串), 作为text的索引 
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    //nums[i] // 转换为整数 才能作为下标使用
            //    int index = int.Parse(nums[i]);
            //     index += index%2==0?1:-1 ;
            //    result += text[index];
            //}

            //Console.WriteLine(result); // 午夜渡口交换情报

            /*********************************************************************/
            ////数字转汉字
            ////Console.WriteLine("请输入您要转换的数");
            ////int money = int.Parse(Console.ReadLine());
            //int money = 123456;
            //string str = money.ToString();
            //// 0    1    2   3   4  。。。
            //// 零   壹   贰  叁  肆
            //// 对应关系：数字当作下标，从下面的集合中用下标获取汉字
            //// 创建汉字数组
            //string[] arr = ["零", "壹", "贰", "叁", "肆", "伍", "陆", "柒", "捌", "玖"];
            //// 创建单位数组
            //string[] units = ["", "拾", "佰", "仟", "萬", "拾", "佰", "仟", "亿"];
            //string result = "";

            ////为了方便对单位的插入所以将str字符串倒过来遍历
            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    //将字符串转为整形
            //    //str[i] // 作为arr的下标使用就必须是整数
            //    int ind = int.Parse(str[i].ToString());
            //    //获取下标
            //    /*
            //        举例说明: 567  长度是3
            //        i       index       ===> i + index = 长度-1
            //        2         0    
            //        1         1
            //        0         2
            //     */
            //    int index = str.Length - 1 - i;
            //    //此时，特殊情况1.不为0    2.为零的时候，单位万，必须有

            //    /**************************************/
            //    //第一种思路
            //    //if (ind != 0 || units[index]== "萬")
            //    //{
            //    //    //将数学汉字+单位进行拼接
            //    //    result = arr[ind] + units[index] + result;
            //    //}
            //    ////否则单位不保留
            //    //else
            //    //{
            //    //    result = arr[ind] + result;
            //    //}

            //    //第二种思路
            //    if (ind != 0)
            //    {
            //        //将数学汉字+单位进行拼接
            //        result = arr[ind] + units[index] + result;
            //    }
            //    else
            //    {
            //        // 数字是0 但是卡在萬单位上的时候,则不能省略萬单位
            //        // str长度 减去 萬位置0的下标  一定是 5
            //        if (str.Length - 5 == i)
            //        {
            //            result = arr[ind] + units[4] + result;
            //        }
            //        else
            //        {
            //            result = arr[ind] + result;
            //        }
            //        // 判断单位是萬则单位保留
            //        if (units[index] == "萬")
            //        {
            //            result = arr[ind] + units[4] + result;
            //        }
            //        else
            //        {
            //            result = arr[ind] + result;
            //        }



            //        //正则处理   然后进行处理万前面多个零的问题
            //        result = Regex.Replace(result, @"零+", "零");

            //        //万后面连续多个零的情况
            //        result = Regex.Replace(result, @"零+", "");

            //        //// 处理结尾是0 的问题            
            //        if (result.EndsWith("零"))
            //        {
            //            result = result.Substring(0, result.Length - 1);
            //        }
            //    }
            //}


            /*********************************************************************/
            /*
             JSON格式数据
                - 一般由{},[],组成
                - json格式中的数据可以是键值: 键名必须双引号包裹
                    + 键值: 如果是数字,布尔值则可以不用双引号包裹,其他都要被双引号包裹
             */
            //List<Dictionary<string, dynamic>> singerList = new()
            //{
            //    new Dictionary<string, dynamic>
            //    {
            //        {"singerId", 1001},
            //        {"singerName", "周杰伦"},
            //        {"genre", "流行"}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"singerId", 1002},
            //        {"singerName", "林俊杰"},
            //        {"genre", "华语流行"}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"singerId", 1003},
            //        {"singerName", "邓紫棋"},
            //        {"genre", "流行、摇滚"}
            //    }
            //};

            //// 配置序列化
            //var options = new JsonSerializerOptions
            //{    
            //    WriteIndented= true,// JSON序列化时候美化
            //    AllowTrailingCommas = true, // JSON反序列化时候允许 最后出现逗号
            //};

            //string json = JsonSerializer.Serialize(singerList, options);
            ////Console.WriteLine(json);

            //// json反序列化 ===> 将json字符串转换为原始类型数据
            //var res = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            ////Console.WriteLine(res);
            ////foreach (var item in res) Console.WriteLine($"{item["singerName"]}");


            //// 反序列化的应用：
            //// 将unicode编码汉字转成中文汉字
            //string source = "\\u6C11\\u8C23\\u6D41\\u884C";
            //string s = $"\"{source}\"";  // "{abcd}"
            //var r1 = JsonSerializer.Deserialize<string>(s);
            //Console.WriteLine(r1);  // "民谣流行"

            /*********************************************/
            //多维数组
            //// 二维数组
            //// 表格数据 ==> 3行2列
            //int[,] tables = new int[3, 2]
            //{
            //    {1,10 },
            //    {2,20 },
            //    {3,30 },
            //};

            //// 访问
            ////Console.WriteLine(tables[0,1]); // 10
            //// 获取行列的数量
            //int rowCount = tables.GetLength(0); // 3
            //int colCount = tables.GetLength(1); // 2
            ////Console.WriteLine(rowCount);
            ////Console.WriteLine(colCount);

            //// 遍历二维数组
            //for (int i = 0; i < rowCount; i++)
            //{
            //    for (int j = 0; j < colCount; j++)
            //    {
            //        Console.Write(tables[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            ///*
            //    1       10
            //    2       20
            //    3       30
            // */

            //// 五子棋棋盘
            //int[,] chessBoard = new int[15, 15];
            //// 0 空位 1 黑子 2 白子
            //chessBoard[7, 7] = 1;


            // 交错数组
            // 一班 5 个人、二班 3 个人、三班 7 个人
            //int[][] classes = new int[3][];

            //// 添加班级分数
            //classes[0] = [60, 70, 80, 90, 100];
            //classes[1] = [80, 90, 100];
            //classes[2] = [60, 70, 80, 90, 100, 50, 99];

            ////Console.WriteLine(classes[1][2]);// 100
            //Console.WriteLine(classes.Length); // 3
            //for (int i = 0; i < classes.Length; i++)
            //{
            //    foreach (int score in classes[i])
            //    {
            //        Console.Write(score + " ");
            //    }
            //    Console.WriteLine();                
            //}
            ///*
            //    60 70 80 90 100
            //    80 90 100
            //    60 70 80 90 100 50 99             
            // */


            ////用户 A：20 条消息 用户 B：6 条消息 用户 C：42 条消息。
            //int[][] userChatMsg = new int[3][];

            //// 用户的消息
            //userChatMsg[0] = new int[20];
            //userChatMsg[1] = new int[6];
            //userChatMsg[2] = new int[42];

            ////userChatMsg[0] = new int[5];










        }
    }
}
