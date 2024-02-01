namespace Week3.app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ümumi emek haqqı:
            Console.WriteLine("Ümumi emek haqqı (tam eded)");
            float totalWages = int.Parse(Console.ReadLine());

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
            //net maas:
            float netSalary = 0;
            //Əlil işçilər digər işçilərlə müqayisədə % 50 daha az gəlir vergisi
            if (disabledPerson == "b" || disabledPerson == "B")
            {
                if (totalWages <= 1000)
                {
                    netSalary = (totalWages * 15 / 100) * 5 / 10;
                }
                else if (totalWages > 1000 && totalWages <= 2000)
                {
                    netSalary = (totalWages * 20 / 100) * 5 / 10;
                }
                else if (totalWages > 2000 && totalWages < 3000)
                {
                    netSalary = (totalWages * 25 / 100) * 5 / 10;
                }
                else
                {
                    netSalary = (totalWages * 30 / 100) * 5 / 10;
                }
            }
            else
            {
                if (totalWages <= 1000)
                {
                    netSalary = totalWages * 15 / 100;
                }
                else if (totalWages > 1000 && totalWages <= 2000)
                {
                    netSalary = totalWages * 20 / 100;
                }
                else if (totalWages > 2000 && totalWages < 3000)
                {
                    netSalary = totalWages * 25 / 100;
                }
                else
                {
                    netSalary = totalWages * 30 / 100;
                }
            }
            Console.WriteLine("ailə müavinəti :" + familyAllowance);
            Console.WriteLine("uşaq pulu :" + usaqMuvafiqeti);
        }

    }
}

//// Əmək haqqının %15-inə qədər olan məbləğ
//if (totalWages <= 1000)
//{
//    netSalary = totalWages * 15 / 100;
//}
//else if (totalWages > 1000 && totalWages <= 2000)
//{
//    netSalary = totalWages * 20 / 100;
//}
//else if (totalWages > 2000 && totalWages < 3000)
//{
//    netSalary = totalWages * 25 / 100;
//}
//else
//{
//    netSalary = totalWages * 30 / 100;
//}