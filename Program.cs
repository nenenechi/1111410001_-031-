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
