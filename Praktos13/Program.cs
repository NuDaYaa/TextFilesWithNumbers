namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string aFilePath = "C:\\Users\\ИСП-22\\a.txt";
            using (StreamWriter writer = new StreamWriter(aFilePath))
            {
                for (int i = 0; i < 150; i++)
                {
                    int number = random.Next(-1000, 1000);
                    writer.WriteLine(number);
                }
            }

            string aFilePathRead = aFilePath;
            string bFilePath = "C:\\Users\\ИСП-22\\b.txt";
            string line;
            int number;
            using (StreamReader reader = new StreamReader(aFilePathRead))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    number = int.Parse(line);
                    if (number % 2 == 0) 
                    {
                        using (StreamWriter writer = new StreamWriter(bFilePath, true))
                        {
                            writer.WriteLine(number);
                        }
                    }
                }
            }
            string cFilePath = "C:\\Users\\ИСП-22\\c.txt";
            using (StreamReader reader = new StreamReader(aFilePathRead))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    number = int.Parse(line);
                    if (number % 5 == 0) 
                    {
                        using (StreamWriter writer = new StreamWriter(cFilePath, true))
                        {
                            writer.WriteLine(number);
                        }
                    }
                }
            }
        }
    }
}