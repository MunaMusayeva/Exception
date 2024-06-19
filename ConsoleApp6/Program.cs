using ConsoleApp6;
using System.Data;
using System.Linq.Expressions;
using System.Net.NetworkInformation;

class Program
{
    class ATM
    {
        public int pin { get; set; }
        public double balans { get; set; }
        public ATM(int pin, double balans)
        {
            this.pin = pin;
            this.balans = balans;
        }

    }


    static void Main(string[] args)
    {
        ATM a1 = new ATM(1234, 500);
        int say = 0;
        while (true)
        {
            try
            {
                Console.WriteLine("Enter your pin:");
                int pin1 = Convert.ToInt32(Console.ReadLine());
                if (a1.pin == pin1)
                {
                    Console.WriteLine("1.Balans\n2.Nagd\n3.pin deyisme\n4.Balans artirmaq");
                    Console.WriteLine("Seciminizi daxil edin:");
                    int secim = Convert.ToInt32(Console.ReadLine());
                    if (secim == 1)
                    {
                        Console.WriteLine("Balans:");
                        Console.WriteLine(a1.balans);

                    }
                    else if (secim == 2)
                    {
                        Console.WriteLine("Cixarilacaq meblegi daxil edin:");
                        int mebleg = Convert.ToInt32(Console.ReadLine());
                        if (mebleg <= a1.balans)
                        {
                            a1.balans = a1.balans - mebleg;
                            Console.WriteLine("Mebleg balansdan cixarildi");
                        }
                        else
                        {
                            Console.WriteLine("Balansda yeterli mebleg movcud deil");
                        }
                    }
                    else if (secim == 3)
                    {
                        int say1 = 0;
                        Console.WriteLine("Kohne pini daxil edin:");
                        int pin2 = Convert.ToInt32(Console.ReadLine());
                        if (pin2 == a1.pin)
                        {
                            Console.WriteLine("Yeni pini daxil edin:");
                            int pin3 = Convert.ToInt32(Console.ReadLine());
                            a1.pin = pin3;
                        }
                        else
                        {
                            say1++;
                            if (say == 3)
                            {
                                Console.WriteLine("Siz pini 3 defe yanlis daxil etmisiniz!");
                                break;
                            }

                        }
                    }
                    else if (secim == 4)
                    {
                        Console.WriteLine("Meblegi daxil edin:");
                        int mebleg1 = Convert.ToInt32(Console.ReadLine());
                        a1.balans = a1.balans + mebleg1;
                        Console.WriteLine("Mebleg balansa elave olundu");

                    }
                }

                else
                {
                    Console.WriteLine("Pin yanlisdir");
                    say++;
                    if (say >= 3)
                    {
                        throw new _3_pin("You have entered the wrong PIN 3 times!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect PIN entered.");
                    }

                }
            }
            catch (_3_pin ex)
            {
                Console.WriteLine(ex.Message);
                say = 0;
            }
            



        }
    }
}