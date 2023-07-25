using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** Ortalama Hesaplama ***
            //Kullanicidan ogrenci adi istensin,ogrenci adi bos birakilmadi ise 1.vize notu istensin
            //ogrenci adi bos birakildi ise uyari verilsin,
            //1.vize notu istendikten sonra bu notun 0 - 100 arasi olup olmadigina bakilsin,
            //1.vize notu, 0'dan kucuk veya 100' den buyuk ise uyari verilsin, 0 - 100 arasi ise 2.vize notu sorulsun,
            //Kullanicidan 2.vize notu alinsin, bu notun da 0 - 100 arasi olup olmadigina bakilsin,
            //vize2 notu 0'dan kucuk veya 100'den buyuk ise uyari verilsin
            //vize2 notu 0 - 100 arasi ise artik final notu istensin
            //final notunun da 0 - 100 arasinda olup olmadigina bakilsin, bu not da 0'dan kucuk veya 100'den buyuk ise uyari verilsin
            //final notu 0 - 100 arasinda ise ortalamaya bakilsin
            //ortalama 60'a esit veya 60'dan buyuk ise "ogrenci gecti" deyip ortalamasini de belirtelim
            //ortalama 60'dan kucuk ise "Ogrenci kaldi" deyip ortalamasini de belirtelim
            //vize1 --> exam1, vize2 --> exam2, final --> final, ortalama --> average, carpan --> multiple

            string studentName;
            double exam1;
            double exam2;
            double final;
            double average;
            const double examMultiple = 0.2;
            const double finalMultiple = 0.6;

            Console.WriteLine("Please enter the student name : ");
            studentName = Console.ReadLine();

            if (studentName != "")
            {
                Console.WriteLine("Please enter the exam1 : ");
                exam1 = Convert.ToDouble(Console.ReadLine());

                if (exam1 >= 0 && exam1 <= 100 )
                {
                    Console.WriteLine("Please enter the exam2");
                    exam2 = Convert.ToDouble(Console.ReadLine());

                    if (exam2 >= 0 && exam2 <= 100)
                    {
                        Console.WriteLine("Please the final : ");
                        final = Convert.ToDouble(Console.ReadLine());

                        if (final >= 0 && final <=100)
                        {
                            average = (exam1 + exam2) * examMultiple + (final * finalMultiple);

                            if (average > 60)
                            {
                                Console.WriteLine("Congratulations, you are successful. Your average is : " + average);
                            }
                            else
                            {
                                Console.WriteLine("Unfortunately, you failed. Your average is : " + average);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Final has to be between 0 - 100");
                        }
                    }
                    else
                    {
                        Console.WriteLine("exam2 has to be between 0 - 100");
                    }
                }
                else
                {
                    Console.WriteLine("exam1 has to be between 0 - 100");
                }
            }
            else
            {
                Console.WriteLine("You should enter the student name");
            }


            Console.Read();
            
        }
    }
}
