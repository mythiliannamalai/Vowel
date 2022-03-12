    class Program
    {
        public void Calulation()
        {
            char Alphabet;
            Console.WriteLine("enter the alphabet : ");
            Alphabet = char.Parse(Console.ReadLine());
            if (Alphabet == 'a' || Alphabet == 'e' || Alphabet == 'i' || Alphabet == 'o' || Alphabet == 'u' || Alphabet == 'A' || Alphabet == 'E' || Alphabet == 'I' || Alphabet == 'O' || Alphabet == 'U')
            {
                Console.WriteLine("{0} is vowel...", Alphabet);

            }
            else
            {
                Console.WriteLine("{0} is consonant...", Alphabet);
            }

        }
    }
class Result
{
    public static void Main(string[]args)
    {
        Program vowel=new Program();
        vowel.Calulation();
    }
}