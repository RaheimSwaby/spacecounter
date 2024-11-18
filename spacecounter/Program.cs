namespace spacecounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter a sentence");
            string sentence = Console.ReadLine();
            
            char spaceChar = ' ';
            
            int spaceCount =0;
            foreach (char c in sentence)
            {
                if (spaceChar == c)
                spaceCount++;
                
            }
            Console.WriteLine($"there are {spaceCount} space(s) in your sentence \n{sentence}");
            

            
        }
    }
}
