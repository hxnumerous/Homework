using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace EX05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Dictionary<string, dynamic> dic = new()
            //{
            //    ["name"] = "张三",
            //    ["age"] = 12
            //};
            ////Add增加键值对
            //dic.Add("height", 180);
            //Console.WriteLine(dic["height"]);

            //ContainsKey / ContainsValue
            //Console.WriteLine(dic.ContainsKey("name"));

            //Console.WriteLine(dic.ContainsValue("张三"));

            //Remove通过指定的键将键值对从字典中删除
            //dic.Remove("height");
            //foreach (dynamic item in dic)
            //{
            //    Console.WriteLine(item);
            //}


            //Clear清空字典中的键值对
            //dic.Clear();
            //foreach (dynamic item in dic)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(dic.Count);

            //Keys获取字典中所有键的集合
            //新建数组进行获取键
            //dynamic dickeys = dic.Keys;
            //foreach (var keys in dickeys)
            //{
            //    Console.WriteLine(keys);
            //}

            //Values获取字典中所有值的集合
            //dynamic dicvalues =dic.Values;
            //foreach (var values in dicvalues)
            //{
            //    Console.WriteLine(values);
            //}

            //TryAdd ==> 不存在才添加，存在了就添加失败，但不报错
            //Console.WriteLine(dic.TryAdd("name","abcd"));
            //Console.WriteLine(dic.TryAdd("weight", 140));
            //foreach (var item in dic)
            //{
            //    Console.WriteLine(item);
            //}


            // 遍历字典
            // 方式1：遍历 KeyValuePair
            //foreach (var item in dic)
            //{
            //    //Console.WriteLine(item);
            //    //key
            //    Console.WriteLine(item.Key);
            //    //values
            //    Console.WriteLine(item.Value);
            //}




            // 方式2：遍历所有键
            //foreach (dynamic item in dic.key)
            //{
            //    Console.WriteLine(item);
            //}



            // 方式3：遍历所有值
            //foreach (dynamic item in dic.Values)
            //{
            //    Console.WriteLine(item);
            //}



            //List中的数据是可以重复的，去重就是将重复的数据删掉，让List中保留唯一的数据。
            //List<int> ints = [1, 3, 3, 4, 5, 6, 7, 7, 8, 6, 4, 2, 3];


            //思路1：遍历每个元素，让这个元素跟他后面的每一个元素都做比较，相等就删掉
            //for (int i = 0; i < ints.Count; i++)
            //{
            //    //ints[i]    从i+1开始，用第一个元素和后面的比较    
            //    for (int j = i+ 1; j < ints.Count; j++)
            //    {
            //        if (ints[i] == ints[j])
            //        {
            //            ints.RemoveAt(j);
            //            j--;//删除一个后发生塌陷，j-1，返回去继续比较
            //        }
            //    }
            //}
            ////验证去重
            //foreach (dynamic item in ints) Console.WriteLine(item);

            //List<int> ints = [1, 3, 3, 4, 5, 6, 7, 7, 8, 6, 4, 2, 3];
            //思路2：找元素最后一次出现的下标，跟第一次出现的下标是否相等，相等就表示元素没有重复，不相等就表示有重复，要删除掉最后一个重复元素。
            //for (int i = 0; i < ints.Count; i++)
            //{
            //   int temp = ints.LastIndexOf(ints[i]);
            //   if (ints.LastIndexOf(ints[i]) != i)
            //    {
            //        ints.RemoveAt(temp);
            //    }
            //    else
            //    {
            //        break;// 如果找到的就是本身 说明重复的就删完
            //    }

            //}
            ////验证去重
            //foreach (dynamic item in ints) Console.WriteLine(item);

            //List<int> ints = [1, 3, 3, 4, 5, 6, 7, 7, 8, 6, 4, 2, 3];
            //思路3：利用字典中的键是唯一的，将List中每个数据都作为字典的键，最终在字典中的键都是唯一的，将所有键放在一个新的List中
            //Dictionary<int, dynamic> dic2 = new();
            //foreach (dynamic key in ints)
            //{
            //    // 遍历ints 将 其中的数据 作为 dic2的键名, 键值无所谓
            //    dic2[key] = "123";

            //}
            //// 取出字典中的键 转为List
            //List<int> templist = dic2.Keys.ToList();
            ////验证去重
            //foreach (dynamic item in ints) Console.WriteLine(item);

            //List<int> ints = [1, 3, 3, 4, 5, 6, 7, 7, 8, 6, 4, 2, 3];
            //思路4：创建一个新的List，遍历原本的List，原本List中的每一个元素，放在新的List中进行判断是否存在，如果不存在就添加到新的List中，如果存在就不添加
            //List<int> newInts = [];
            //// 遍历原本的List
            //foreach (int item in ints)
            //{
            //    // 判断 item在 newInsts中是否存在
            //    if (!newInts.Contains(item))
            //    {
            //        newInts.Add(item);
            //    }
            //}
            //// 验证去重效果
            //foreach (int n in newInts) Console.WriteLine(n);


            //冒泡排序
            //List<int> ints = [5, 3, 4, 6, 7, 8, 9, 1, 2];
            //for (int j = 0; j < ints.Count-1; j++)
            //{
            //    for (int  i = 0; i < ints.Count-1-j; i++)
            //    {
            //        if(ints[i] > ints[i + 1])
            //        {
            //            int temp = ints[i];
            //            ints[i] = ints[i + 1];
            //            ints[i + 1] = temp;
            //        }
            //    }

            //}
            //foreach (int n in ints) Console.WriteLine(n);


        List<Dictionary<string, dynamic>> goodsList = new List<Dictionary<string, dynamic>>
        {
            new Dictionary<string, dynamic>
            {
                {"name", "机械键盘"},
                {"price", 299.99},
                {"code", "G001"},
                {"stock", 120}
            },
            new Dictionary<string, dynamic>
            {
                {"name", "无线鼠标"},
                {"price", 89.50},
                {"code", "G002"},
                {"stock", 356}
            },
            new Dictionary<string, dynamic>
            {
                {"name", "27寸显示器"},
                {"price", 1299.00},
                {"code", "G003"},
                {"stock", 48}
            },
            new Dictionary<string, dynamic>
            {
                {"name", "电竞耳机"},
                {"price", 199.00},
                {"code", "G004"},
                {"stock", 85}
            },
            new Dictionary<string, dynamic>
            {
                {"name", "电脑支架"},
                {"price", 69.90},
                {"code", "G005"},
                {"stock", 210}
            }
        };
            // 按照价格做排序

            //Console.WriteLine("请输入价格或库存(price or stock):");
            //string opt1 = Console.ReadLine();
            //Console.WriteLine("请输入升序或降序(ASC or DSC or asc or dsc):");
            //string opt2 = Console.ReadLine();

            //if (opt1 == "价格" || opt1 == "price")
            //{
            //    if (opt2 == "升序" || opt2 == "ASC" || opt2 == "asc")
            //    {
            //        for (int j = 0; j < goodsList.Count -1; j++)
            //        {
            //            for(int i =0;i < goodsList.Count -1 -j ;i++ )
            //            {
            //                if (goodsList[i]["price"] > goodsList[i + 1]["price"] )
            //                {
            //                    dynamic temp = goodsList[i];
            //                    goodsList[i] = goodsList[i + 1];
            //                    goodsList[i + 1] = temp;
            //                }
            //            }
            //        }
            //        foreach (dynamic item in goodsList) Console.WriteLine($"{item["name"]}--{item["price"]}");

            //    }
            //    else if(opt2 == "降序" || opt2 == "DSC" || opt2 == "dsc")
            //    {
            //        for (int j = 0; j < goodsList.Count - 1; j++)
            //        {
            //            for (int i = 0; i < goodsList.Count - 1 - j; i++)
            //            {
            //                if (goodsList[i]["price"] < goodsList[i + 1]["price"])
            //                {
            //                    dynamic temp = goodsList[i];
            //                    goodsList[i] = goodsList[i + 1];
            //                    goodsList[i + 1] = temp;
            //                }
            //            }
            //        }
            //        foreach (dynamic item in goodsList) Console.WriteLine($"{item["name"]}--{item["price"]}");



            //    }
            //    else
            //    {
            //        Console.WriteLine("价格/库存输入有误，请重新输入");
            //    }

            //}else if (opt1 == "库存" || opt1 == "stock")
            //{
            //    if (opt2 == "升序" || opt2 == "ASC" || opt2 == "asc")
            //    {
            //        for (int j = 0; j < goodsList.Count - 1; j++)
            //        {
            //            for (int i = 0; i < goodsList.Count - 1 - j; i++)
            //            {
            //                if (goodsList[i]["stock"] > goodsList[i + 1]["stock"])
            //                {
            //                    dynamic temp = goodsList[i];
            //                    goodsList[i] = goodsList[i + 1];
            //                    goodsList[i + 1] = temp;
            //                }
            //            }
            //        }
            //        foreach (dynamic item in goodsList) Console.WriteLine($"{item["name"]}--{item["stock"]}");

            //    }
            //    else if (opt2 == "降序" || opt2 == "DSC" || opt2 == "dsc")
            //    {
            //        for (int j = 0; j < goodsList.Count - 1; j++)
            //        {
            //            for (int i = 0; i < goodsList.Count - 1 - j; i++)
            //            {
            //                if (goodsList[i]["stock"] < goodsList[i + 1]["stock"])
            //                {
            //                    dynamic temp = goodsList[i];
            //                    goodsList[i] = goodsList[i + 1];
            //                    goodsList[i + 1] = temp;
            //                }
            //            }
            //        }
            //        foreach (dynamic item in goodsList) Console.WriteLine($"{item["name"]}--{item["stock"]}");
            //    }else
            //        Console.WriteLine("升降序输入有误，请重新输入");
            //}







        }
    }
}
