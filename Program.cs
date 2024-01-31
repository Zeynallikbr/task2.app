using System;
using System.Net.NetworkInformation;

namespace Emekhaqqi.app
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
            if (numberOfChildren > 1)
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
            //evli ve usaq muavinbeti,
            float maritialSupport = 0;//evlilik dəstəyi
            float childSupport = 0;//uşaq dəstəyi
            if (maritalStatus == "e" || maritalStatus == "E")
            {
                maritialSupport = 50;

                if (numberOfChildren == 1)
                {
                    childSupport = 30;
                }
                else if (numberOfChildren == 2)
                {
                    childSupport = (childSupport + 25);
                }
                else if (numberOfChildren == 3)
                {
                    childSupport = (childSupport + 20);
                }
                else
                {
                    childSupport += 15;
                }
               
            }
            else if (maritalStatus == "d" || maritalStatus == "D")
            {
                maritialSupport = 50;

                if (numberOfChildren == 1)
                {
                    childSupport = 30;
                }
                else if (numberOfChildren == 2)
                {
                    childSupport = (childSupport + 25);
                }
                else if (numberOfChildren == 3)
                {
                    childSupport = (childSupport + 20);
                }
                else
                {
                    childSupport += 15;
                }
            }
            //else if (maritalStatus == "e" && numberOfChildren > 0)











            Console.WriteLine("Net maas:" + totalWages);
            Console.WriteLine("Aile veziyeti: " + maritalStatus);
            Console.WriteLine("Uşaqların sayı: " + numberOfChildren);
            Console.WriteLine("Əlil olub-olmaması: " + disabledPerson);
        }
    }
}
