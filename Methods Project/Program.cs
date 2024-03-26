namespace Methods_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] siyahi = { "mahir", "samir", "kenan", "fuat" };
            bool dur = true;
            while (dur)
            {
                Menu();

                string num = Console.ReadLine();
                if (num == "1")
                {
                    FullName(siyahi);
                }
                else if (num == "2")
                {
                    AddName(siyahi);
                }
                else if (num == "3")
                {
                    CheckName(siyahi);
                }
                else if (num == "4")
                {
                    indexname(siyahi);
                }
                else if (num == "0")
                {
                    Console.WriteLine("proqram bitdi");
                    dur = false;
                }
                else
                {
                    Console.WriteLine("Yanlış seçim. Zəhmət olmasa düzgün seçim edin.");
                }
            }

        }

        static void Menu()
        {
            Console.WriteLine("1. Siyahiya bax");
            Console.WriteLine("2. Siyahiya add elave et");
            Console.WriteLine("3. Siyahida adi yoxla");
            Console.WriteLine("4. Daxil edilmis indexdeki adi goster");
            Console.WriteLine("0. Menudan cix");
        }
        static void FullName(string[] siyahi)
        {
            foreach (var item in siyahi)
            {
                Console.WriteLine(item);
            }
        }
        static void AddName(string[] siyahi)
        {
            Console.WriteLine("ad daxil edin");
            string New = Console.ReadLine();
            if (New.Length < 3 || Char.IsDigit(New[0]))
            {
                Console.WriteLine("Ad rəqəmlə başlaya bilməz və uzunluğu 2-dən böyük olmalıdır");
            }
            for (int i = 0; i < siyahi.Length; i++)
            {
                siyahi[^1] = New;
            }
            for (int i = 0; i < siyahi.Length; i++)
            {
                if (siyahi[i] == New)
                {
                    Console.WriteLine("eyni ad daxil ede bilmesiniz");
                    break;
                }

            }
            foreach (var item in siyahi)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("siyahiya elave edildi");
        }
        static void CheckName(string[] siyahi)
        {
            Console.WriteLine("ad daxil edin");
            string yeniad = Console.ReadLine();
            for (int i = 0; i < siyahi.Length; i++)
            {
                if (siyahi[i] == yeniad)
                {
                    Console.WriteLine("bu adi  siyahida var");
                    break;
                }
                else
                {
                    Console.WriteLine("bu adi  siyahida yoxdu");
                    break;
                }
            }
        }
        static void indexname(string[] siyahi)
        {
            Console.WriteLine("index daxil edin");
            int index = int.Parse(Console.ReadLine());
            for (int i = 0; i < siyahi.Length; i++)
            {
                if (i == index)
                {
                    Console.WriteLine(siyahi[index]);
                }
            }
        }

    }

}
