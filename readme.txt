一開始我先打出印出輸入單字和宣告一個陣列，然後做for迴圈來輸入
，但是因為單字數量不確定，我以我改成先輸入單字數量來決定輸入次數
，再來是次數限制，因為只用if來做的話不能重複問，所以我上網找其他方法
，最後用do whilex來檢查，之後的輸入小寫字母，也是用do while來做
，再來是找出含有字元的單字我先創了一個副程式，再用for迴圈來數含有的字元
，有找到字元的回傳值，沒有的回傳null，最後再主程式呼叫，在印出值，但是
執行結果無法正常印出來，所以我又去上網查，知道了要先初始化結果陣列再用
Array.Copy來將找到的值複製到結果陣列和Join 的用法。







namespace _1111410001_歐修孚_031_找出含有字元的單字
{
    internal class Program
    {
        static int?[] FindChar(string[] word, char x)
        {
            int?[] indices = new int?[word.Length];
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i].Contains(x))
                    indices[count++] = i;
            }
            if (count == 0)
            {
                return new int?[] { null };
            }
            int?[] result = new int?[count];
            Array.Copy(indices, result, count);
            return result;
        }
        static void Main(string[] args)
        {
            int length;
            char x;
            do
            {
                Console.Write("請輸入你要打的單字數量：");
                length = int.Parse(Console.ReadLine());
                if (length <= 0 || length > 50)
                {
                    Console.WriteLine("超出範圍！");
                }
            } while (length <= 0 || length > 50);

            string[] words = new string[length];
            for (int i = 0; i < length; i++)
            {
                do
                {
                    Console.Write($"請輸入第 {i + 1} 個字串：");
                    words[i] = Console.ReadLine();
                    if (words[i].Length <= 0 || words[i].Length > 50)
                    {
                        Console.WriteLine("超出範圍，請重新輸入！");
                    }
                } while (words[i].Length <= 0 || words[i].Length > 50);
            }
            do
            {
                Console.Write("請輸入一個小寫英文字母：");
                x = char.Parse(Console.ReadLine());
                if (!char.IsLower(x)) 
                {
                    Console.WriteLine("請輸入小寫英文字母！");
                }
            } while (!char.IsLower(x)); 

            int?[] result = FindChar(words, x);
            if (result[0] is null)
            {
                Console.WriteLine("輸出：[ null ]");
            }
            else
                Console.WriteLine($"輸出：[ {string.Join(",", result)} ]");

        }
    }
}