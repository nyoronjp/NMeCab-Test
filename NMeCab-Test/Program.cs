using NMeCab;
using System;

namespace NMeCab_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "SOS団には涼宮ハルヒ、キョン、長門有希、朝比奈みくる、古泉一樹の5人がいる。";

            var param = new MeCabParam();
            param.DicDir = @"./dic/ipadic";
            param.UserDic = new[] { @"../userdic/haruhi.dic" };

            var mecab = MeCabTagger.Create(param);
            var node = mecab.ParseToNode(sentence);

            while (node != null)
            {
                // if (node.CharType > 0)
                Console.WriteLine(node.Surface + "\t" + node.Feature);

                node = node.Next;
            }
        }
    }
}
