namespace Week3.app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ümumi emek haqqı:
            Console.WriteLine("Ümumi emek haqqı (tam eded)");
            float totalWages = float.Parse(Console.ReadLine());

            //Ailə vəziyyəti:
            Console.WriteLine("Ailə vəziyyəti (e / E: evli, s / S: subay, d / D: dul)");
            string maritalStatus = Console.ReadLine();
            if (maritalStatus == "e" || maritalStatus == "E")
            {
                Console.WriteLine("evli");
            }
            else if (maritalStatus == "s" || maritalStatus == "S")
            {
                Console.WriteLine("subay");
            }
            else if (maritalStatus == "d" || maritalStatus == "D")
            {
                Console.WriteLine("dul");
            }
            else
            {
                Console.WriteLine("bele bir deyer yoxdur zehmet olmasa yeniden yazin");
                return;
            }
            //Uşaqların sayı:
            Console.WriteLine("Uşaqların sayı (subaydırsa, bu məlumatlar daxil edilməməlidir)(YOXDURSA 0 GIRIN)");
            int numberOfChildren = int.Parse(Console.ReadLine());
            if (numberOfChildren >= 1)
            {
                Console.WriteLine($" {numberOfChildren}-usagi var");
            }
            else
            {
                Console.WriteLine("usagi yoxdur");
            }
            //Əlil olub-olmaması:
            Console.WriteLine("Əlil olub-olmaması (b / B: bəli, x / X: Xeyr)");
            string disabledPerson = Console.ReadLine();
            if (disabledPerson == "b" || disabledPerson == "B")
            {
                Console.WriteLine("beli");
            }
            else if (disabledPerson == "x" || disabledPerson == "X")
            {
                Console.WriteLine("Xeyr");
            }
            else
            {
                Console.WriteLine("yeniden girin");
                return;
            }
            //aile yardmilari-muavineti
            float familyAllowance = 0;
            if (maritalStatus == "e" || maritalStatus == "E")
            {
                familyAllowance = 50;
            }
            // usaq müavinəti
            double usaqMuvafiqeti = 0;
            if ((maritalStatus == "e" || maritalStatus == "E") || (maritalStatus == "d" || maritalStatus == "D"))
            {
                for (int i = 1; i <= numberOfChildren; i++)
                {
                    if (i == 1)
                    {
                        usaqMuvafiqeti += 30;
                    }
                    else if (i == 2)
                    {
                        usaqMuvafiqeti += 25;
                    }
                    else if (i == 3)
                    {
                        usaqMuvafiqeti += 20;
                    }
                    else
                    {
                        usaqMuvafiqeti += 15;
                    }
                }
            }
            double taxRange = 0;//vergi derecesi
            double taxAmount = 0;//vergi miqdari
            taxAmount = totalWages * taxRange;
            if (totalWages <= 1000)
            {
                taxRange = 0.15;
            }
            else if (totalWages > 1000 && totalWages <= 2000)
            {
                taxRange = 0.2;
            }
            else if (totalWages > 2000 && totalWages < 3000)
            {
                taxRange = 0.25;
            }
            else
            {
                taxRange = 0.3;
            }
            if (disabledPerson == "b" || disabledPerson == "B")
            {
                taxRange *= 0.5;//eliler ucun 50% endrim
            }

            Console.WriteLine($"ailə müavinəti :{familyAllowance}-AZN");
            Console.WriteLine($"uşaq pulu :{usaqMuvafiqeti}-AZN");
            Console.WriteLine($"gəlir vergisi dərəcəsi :{taxRange * 100}%");
            Console.WriteLine($"gəlir vergisinin məbləği :{taxAmount}-AZN");
            Console.WriteLine($"ümumi əmək haqqı :{totalWages}-AZN");
            Console.WriteLine($"xalis əmək haqqı :{totalWages + familyAllowance + usaqMuvafiqeti - taxAmount}-AZN");

            // Pul vahidləri
            int[] unitsOfMoney = { 200, 100, 50, 20, 10, 5, 1 };
            //  xalis əmək haqqı məbləği ən yaxın tam ədədə qədər yuvarlaqlaşdırılmis formasi
            foreach (int money in unitsOfMoney)
            {
                int pulSayi = (int)(totalWages / money);
                totalWages %= money;

                Console.WriteLine($"{money} AZN pulundan {pulSayi} vahid");
            }
        }
    }
}