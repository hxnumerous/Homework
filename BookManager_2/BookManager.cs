using System.Text.Json;

namespace Homeworkday12
{
    internal class BookManager
    {
        // 属性：
        // 数据文件路径
        public string path { get; }
        // JSON序列化配置项
        public JsonSerializerOptions JsonOpts { get; }

        // 新增数据：强制要求 ==> 将list写入文件中
        public string AddBook(Dictionary<string, dynamic> bookDic )
        {

            // 判断图书是否已存在===>根据图书名判断(一个书名只有一本)

            // 新增的逻辑处理
            // 判断path路径是存在===> 不存在, 组装书籍list,序列化后 写入文件
            // 如果存在 =====> 先读取文件内容
            // 反序列化为list ====> 添加bookDic到list中
            // 序列化list ====> 写入文件
            List<Dictionary<string, dynamic>> bookList = new() { };
            if (File.Exists(path))
            {
                // 读取文件===>反序列化
                var json = File.ReadAllText(path);
                // 反序列化
                bookList = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);

                // 判断图书是否已存在===>根据图书名判断(一个书名只有一本)
                string bookName = bookDic["name"].ToString();
                bool isAdd = bookList.Exists(item => item["name"].ToString() == bookName); // **
                if (isAdd) return "图书已经存在!!!";
            }
                bookList.Add(bookDic);
                //序列化
                string jsonStr = JsonSerializer.Serialize(bookList, JsonOpts);
                // 写入文件
                File.WriteAllText(path, jsonStr);

            return "新增图书成功!!!";
        }


        // 编辑数据
        public string EditBook(string bookName, Dictionary<string, dynamic> newBookData)
        {
            // 编辑的逻辑处理
            List<Dictionary<string, dynamic>> bookList = new() { };
            Dictionary<string, dynamic> editdic = new();
            if (File.Exists(path))
            {
                try
                {
                    // 读取文件===>反序列化
                    var json = File.ReadAllText(path);
                    // 反序列化
                    bookList = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
                    if (!bookList.Exists(item => item["name"].ToString() == bookName))
                    {
                        return "没有找到对应的图书数据，请先添加";
                    }
                    else
                    {
                        Dictionary<string, dynamic> resdic = bookList.Find(item => item["name"].ToString() == bookName);
                        resdic["name"] = newBookData["name"];
                        resdic["author"] = newBookData["author"];
                        resdic["isBorrow"] = bool.Parse(newBookData["isBorrow"].ToString());
                        resdic["mark"] = newBookData["mark"];
                        resdic["price"] = double.Parse(newBookData["price"].ToString());
                        resdic["id"] = newBookData["id"];

                        //序列化
                        string jsonStr = JsonSerializer.Serialize(bookList, JsonOpts);
                        // 写入文件
                        File.WriteAllText(path, jsonStr);
                        return "编辑成功";
                    }
                }
                catch (Exception ex)
                {
                    return $"编辑失败: {ex.Message}";

                }
            }
            else
            {
                return"当前没有图书数据!!!";
            }
            

        }
        // 删除数据
        public List<Dictionary<string, dynamic>> RemoveBook(string bookName)
        {
            // 删除的逻辑处理
            List<Dictionary<string, dynamic>> bookList = new() { };
            Dictionary<string, dynamic> bookDic = new ();
            if (File.Exists(path))
            {
                try
                {
                    // 读取文件===>反序列化
                    var json = File.ReadAllText(path);
                    // 反序列化
                    bookList = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);

                    if(!bookList.Exists(item => item["name"].ToString() == bookName))
                    {
                        Console.WriteLine("没有找到对应的图书数据，请先添加");
                        return bookList;
                    }
                    bookDic = bookList.Find(item => item["name"].ToString() == bookName);
                    bookList.Remove(bookDic);
                    //序列化
                    string jsonStr = JsonSerializer.Serialize(bookList, JsonOpts);
                    // 写入文件
                    File.WriteAllText(path, jsonStr);
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"读取文件异常+{ex}");
                }
            }
            else
            {
                Console.WriteLine("当前没有图书数据!!!");

            }
            return bookList;
        }
        // 查询所有数据
        public List<Dictionary<string, dynamic>> SearchBook() // 返回值根据情况修改
        {
            // 查询的逻辑处理
            List<Dictionary<string, dynamic>> bookList = new() { };
            if (File.Exists(path))
            {
                try {
                    // 读取文件===>反序列化
                    var json = File.ReadAllText(path);
                    // 反序列化
                    bookList = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
                    
                    
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"读取文件异常+{ex}");
                }
            }
            else
            {
                Console.WriteLine("当前没有图书数据!!!");
            }
                return bookList;
        }
        // 根据图书名称查询当前图书数据：强制要求
        public Dictionary<string, dynamic> SearchBook(string bookName) // 返回值根据情况修改
        {
            // 查询当前图书的逻辑处理
            List<Dictionary<string, dynamic>> bookList = new() { };
            Dictionary<string, dynamic> bookDic =new Dictionary<string, dynamic>();
           
            if (File.Exists(path))
            {
                try
                {
                    // 读取文件===>反序列化
                    var json = File.ReadAllText(path);
                    // 反序列化
                    bookList = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
                    Dictionary<string, dynamic> resDic = bookList.Find(item => item["name"].ToString() == bookName);
                    if (bookDic == null) return bookDic;
                    return resDic;

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"读取文件异常+{ex}");
                }
            }
            else
            {
                Console.WriteLine("当前没有图书数据!!!");
                
            }
            return bookDic; 
        }
        // 自定义实例构造函数
        public BookManager(string bookPath, JsonSerializerOptions Opts)
        {
            // 实例化初始化属性
            path = bookPath;
            JsonOpts = Opts;
        }



    }
}
