namespace Homeworkday5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //1.提示输入的 是price还是stock 排序类型
            // 提示输入的是 ASC 还是DSC     排序顺序(ASC升序,DSC降序)
            // 根据输入完成数据排序

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


            //    Console.WriteLine("请输入价格或库存(price or stock):");
            //    string opt1 = Console.ReadLine();
            //    Console.WriteLine("请输入升序或降序(ASC or DSC or asc or dsc):");
            //    string opt2 = Console.ReadLine();

            //    if (opt1 == "价格" || opt1 == "price")
            //    {
            //        if (opt2 == "升序" || opt2 == "ASC" || opt2 == "asc")
            //        {
            //            for (int j = 0; j < goodsList.Count - 1; j++)
            //            {
            //                for (int i = 0; i < goodsList.Count - 1 - j; i++)
            //                {
            //                    if (goodsList[i]["price"] > goodsList[i + 1]["price"])
            //                    {
            //                        dynamic temp = goodsList[i];
            //                        goodsList[i] = goodsList[i + 1];
            //                        goodsList[i + 1] = temp;
            //                    }
            //                }
            //            }
            //            foreach (dynamic item in goodsList) Console.WriteLine($"{item["name"]}--{item["price"]}");

            //        }
            //        else if (opt2 == "降序" || opt2 == "DSC" || opt2 == "dsc")
            //        {
            //            for (int j = 0; j < goodsList.Count - 1; j++)
            //            {
            //                for (int i = 0; i < goodsList.Count - 1 - j; i++)
            //                {
            //                    if (goodsList[i]["price"] < goodsList[i + 1]["price"])
            //                    {
            //                        dynamic temp = goodsList[i];
            //                        goodsList[i] = goodsList[i + 1];
            //                        goodsList[i + 1] = temp;
            //                    }
            //                }
            //            }
            //            foreach (dynamic item in goodsList) Console.WriteLine($"{item["name"]}--{item["price"]}");



            //        }
            //        else
            //        {
            //            Console.WriteLine("价格/库存输入有误，请重新输入");
            //        }

            //    }
            //    else if (opt1 == "库存" || opt1 == "stock")
            //    {
            //        if (opt2 == "升序" || opt2 == "ASC" || opt2 == "asc")
            //        {
            //            for (int j = 0; j < goodsList.Count - 1; j++)
            //            {
            //                for (int i = 0; i < goodsList.Count - 1 - j; i++)
            //                {
            //                    if (goodsList[i]["stock"] > goodsList[i + 1]["stock"])
            //                    {
            //                        dynamic temp = goodsList[i];
            //                        goodsList[i] = goodsList[i + 1];
            //                        goodsList[i + 1] = temp;
            //                    }
            //                }
            //            }
            //            foreach (dynamic item in goodsList) Console.WriteLine($"{item["name"]}--{item["stock"]}");

            //        }
            //        else if (opt2 == "降序" || opt2 == "DSC" || opt2 == "dsc")
            //        {
            //            for (int j = 0; j < goodsList.Count - 1; j++)
            //            {
            //                for (int i = 0; i < goodsList.Count - 1 - j; i++)
            //                {
            //                    if (goodsList[i]["stock"] < goodsList[i + 1]["stock"])
            //                    {
            //                        dynamic temp = goodsList[i];
            //                        goodsList[i] = goodsList[i + 1];
            //                        goodsList[i + 1] = temp;
            //                    }
            //                }
            //            }
            //            foreach (dynamic item in goodsList) Console.WriteLine($"{item["name"]}--{item["stock"]}");
            //        }
            //        else
            //            Console.WriteLine("升降序输入有误，请重新输入");
            //        }


            //2.// 数据使用案例中的数据​// 通过歌曲查找歌手
            List<Dictionary<string, dynamic>> singerList = new List<Dictionary<string, dynamic>>
            {
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1001},
                    {"singerName", "周杰伦"},
                    {"genre", "流行"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1002},
                    {"singerName", "林俊杰"},
                    {"genre", "华语流行"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1003},
                    {"singerName", "邓紫棋"},
                    {"genre", "流行、摇滚"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1004},
                    {"singerName", "薛之谦"},
                    {"genre", "抒情流行"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1005},
                    {"singerName", "毛不易"},
                    {"genre", "民谣流行"}
                }
            };

            List<Dictionary<string, dynamic>> songList = new List<Dictionary<string, dynamic>>
            {
                new Dictionary<string, dynamic>
                {
                    {"songId", 10001},
                    {"singerId", 1001},
                    {"songName", "青花瓷"},
                    {"duration", 239}
                },
                new Dictionary<string, dynamic>
                {
                    {"songId", 10002},
                    {"singerId", 1001},
                    {"songName", "发如雪"},
                    {"duration", 253}
                },
                new Dictionary<string, dynamic>
                {
                    {"songId", 10003},
                    {"singerId", 1001},
                    {"songName", "东风破"},
                    {"duration", 215}
                },
                new Dictionary<string, dynamic>
                {
                    {"songId", 1004},
                    {"singerId", 3002},
                    {"songName", "不为谁而作的歌"},
                    {"duration", 296}
                },
                new Dictionary<string, dynamic>
                {
                    {"songId", 1005},
                    {"singerId", 1002},
                    {"songName", "背对背拥抱"},
                    {"duration", 262}
                }
            };

            //************************************************************************************//
            //// 用户输入歌手姓名：周杰伦/林俊杰 ==> 通过这个姓名将这个人唱的所有歌曲都找出来
            //Console.WriteLine("请输入歌手姓名：");
            //string singer = Console.ReadLine(); // 周杰伦
            //                                    // 先根据歌手名字 找到对应的 字典
            //int singerId = 0; // 歌手ID

            //// 遍历歌手集合  根据歌手名字 获取歌手ID
            //foreach (Dictionary<string, dynamic> item in singerList)
            //{
            //    // item 就是循环中 歌手列表的 数据字典
            //    if (item["singerName"] == singer) singerId = item["singerId"];
            //}

            //// 遍历歌曲集合  根据拿到的歌手id 去判断获取对应的歌曲字典并 存储到新list中
            //var singerSongs = new List<Dictionary<string, dynamic>>();
            //foreach (Dictionary<string, dynamic> item in songList)
            //{
            //    if (item["singerId"] == singerId) singerSongs.Add(item);
            //}

            //// 遍历歌手的歌曲
            //foreach (dynamic item in singerSongs)
            //{
            //    Console.WriteLine(item["songName"]);
            //}

            //***************************************************************************//

            // 通过歌曲查找歌手

            Console.WriteLine("输入歌曲名称：");
            string song = Console.ReadLine();

            int singerId = 0;

            // 遍历歌曲集合  根据歌曲名字 获取歌手ID
            var singerSongs = new List<Dictionary<string, dynamic>>();
            foreach (Dictionary<string, dynamic> item in songList)
            {

                // item 就是循环中 歌列表的 数据字典
                if (item["songName"] == song) singerId = item["singerId"];
            }


            if (singerId == 0)
            {
                Console.WriteLine("未找到对应的歌手");
            } else {
                // 遍历歌手集合  根据拿到的歌手id 去判断获取对应的歌手字典并 存储到新list中
                foreach (Dictionary<string, dynamic> item in singerList)
                {
                    if (item["singerId"] == singerId) singerSongs.Add(item);
                }
                // 遍历歌手的歌曲
                foreach (dynamic item in singerSongs)
                {
                    Console.WriteLine(item["singerName"]);
                }

            }


                


        }
    }
}
