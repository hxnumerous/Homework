using System.Linq;
using System.Text.Json;

namespace Homeworkday12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 实例化图书对象
            BookManager BM = new BookManager("./book.json", new JsonSerializerOptions
            {
                WriteIndented = true, // 美化格式内容
                AllowTrailingCommas = true,
            });


            string num = "";
            while (num != "0")
            {
                // 提示信息
                Console.WriteLine("======欢迎来到图书管理系统======");
                Console.WriteLine("1: 新增图书");
                Console.WriteLine("2: 删除图书");
                Console.WriteLine("3: 编辑图书");
                Console.WriteLine("4: 查询所有图书");
                Console.WriteLine("5: 查询单个图书");
                Console.WriteLine("0: 退出");
                num = Console.ReadLine();

                switch (num)
                {
                    case "1":
                        Console.WriteLine("----新增图书----");
                        Console.WriteLine("请输入书名");
                        string bookName = Console.ReadLine();
                        Console.WriteLine("请输入作者");
                        string author = Console.ReadLine();
                        Console.WriteLine("请输入标签");
                        string mark = Console.ReadLine();
                        Console.WriteLine("请输入价格");
                        double price = double.Parse(Console.ReadLine());
                        // 组装 书籍 字典
                        Dictionary<string, dynamic> bookDic = new()
                        {
                            ["name"] = bookName,
                            ["author"] = author,
                            ["isBorrow"] = false,
                            ["id"] = new Random().NextDouble(),
                            ["mark"] = mark,
                            ["price"] = price
                        };
                        // 调用实例方法  实现 添加书籍
                        string res = BM.AddBook(bookDic);
                        Console.WriteLine(res);
                        break;
                    case "2":
                        Console.WriteLine("----删除图书----");
                        Console.WriteLine("请输入书名：");
                        string bookName1 = Console.ReadLine();
                        var reslist =BM.RemoveBook(bookName1);
                        if (reslist.Count == 0) Console.WriteLine("没找到对应的数据，请先添加");
                        else Console.WriteLine("删除成功");
                        break;
                    case "3":
                        Console.WriteLine("----编辑图书----");
                        Console.WriteLine("请输入书名:");
                        string bookName2 = Console.ReadLine();
                        //创建一个新的字典来存储编辑后的数据
                        Dictionary<string, dynamic> newData = new Dictionary<string, dynamic>();
                        Console.WriteLine("请输入新书名:");
                        string newName = Console.ReadLine();
                        newData["name"] = newName;
                        Console.WriteLine("请输入新作者:");
                        string newAuthor = Console.ReadLine();
                        newData["author"] = newAuthor;
                        Console.WriteLine("请输入新借阅状态:");
                        string newIsBorrow = Console.ReadLine();
                        newData["isBorrow"] = bool.Parse(newIsBorrow);
                        Console.WriteLine("请输入新标签:");
                        string newMark = Console.ReadLine();
                        newData["mark"] = newMark;
                        Console.WriteLine("请输入新价格:");
                        string newPrice = Console.ReadLine();
                        newData["price"] = double.Parse(newPrice);
                        Console.WriteLine("请输入新ID:");
                        double newId = double.Parse(Console.ReadLine());
                        newData["id"] = newId;
                        string result = BM.EditBook(bookName2, newData);
                        Console.WriteLine(result);
                        break;
                    case "4":
                        Console.WriteLine("----查询所有图书----");
                        List<Dictionary<string, dynamic>> allBooks = BM.SearchBook();
                        if (allBooks.Count == 0)
                        {
                            Console.WriteLine("当前没有图书");
                            break;
                        }else
                        {
                            Console.WriteLine($"当前共有{allBooks.Count}本图书");
                        }

                        foreach (var item in allBooks)
                            {
                                Console.WriteLine($"书名: {item["name"]}");
                                Console.WriteLine($"作者: {item["author"]}");
                                Console.WriteLine($"借阅状态: {(item["isBorrow"])}");
                                Console.WriteLine($"ID: {item["id"]}");
                                Console.WriteLine($"标签: {item["mark"]}");
                                Console.WriteLine($"价格: {item["price"]}");
                                Console.WriteLine("----------------------------------------");
                            }
                        break;
                    case "5":
                        Console.WriteLine("----查询单个图书----");
                        Console.WriteLine("请输入书名：");
                        string bookName3 = Console.ReadLine();
                        Dictionary<string,dynamic> bookdic=BM.SearchBook(bookName3);
                        if (bookdic.Count == 0)
                        {
                            Console.WriteLine("没找到对应的数据，请先添加");
                        }
                        else
                        {
                            Console.WriteLine($"书名：{bookdic["name"]}");
                            Console.WriteLine($"作者: {bookdic["author"]}");
                            Console.WriteLine($"借阅状态: {(bookdic["isBorrow"])}");
                            Console.WriteLine($"ID: {bookdic["id"]}");
                            Console.WriteLine($"标签: {bookdic["mark"]}");
                            Console.WriteLine($"价格: {bookdic["price"]}");
                            Console.WriteLine("----------------------------------------");
                            
                        }
                        break;


                    case "0":
                                Console.WriteLine("--**退出**--");
                                break;
                            default:
                                Console.WriteLine("****输入有误****");
                                break;
                            }







            }
        }
    }
}
