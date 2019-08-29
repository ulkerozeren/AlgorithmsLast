using System;
using System.Collections.Generic;
using System.Globalization;

namespace Algoritma
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 5, 2, 0, 9, -45 };
            int[] arr1 = new int[] { 1, 5, 2, 0, 9, -45 };
            int[] arr2 = new int[] { 0, 5, 0, 2, 78 };
            string[] presidents = { "G", "H", "a", "H", "over", "Jack" };

            //WriteNTimes(str,4);
            // ReverseString(str);
            //SortArrayDesc(arr);
            //SortArrayAsc(arr);
            //FindElementsFromArrays(presidents);
            // FindMaxMin(arr);
            //WriteDayOfWeek();
            //FindSameCharacters("denemednm");
            // CheckForAnagram("tabak","kacta");
            // WriteCountofWords("ayse tatile cıksın ama nereye gitsin");
            //RemoveSameCharacters("deneme");
            // VerifyString("tekrake");
            //ChangeSpaces("ayse tatile cıksın ama nereye gitsin");
            //SumOfArrays(arr1,arr2);
            //SortArrayDesc(arr1);
            //PassZeroValues(arr2);
            // ReplaceValues(4, 6);

            //string result = RemoveSameCharacters2("adana");
            // Console.WriteLine(result);

            //Console.WriteLine(AnagramControl("aybe","esya"));
            // BubleSort(arr);

            //  Console.WriteLine(NumberOfWords(" asd dfdf lkjlj dfdf "));

            //  Console.WriteLine(ReverseString1("ulker"));
           // Pyramid(5);

            Console.WriteLine();
            //InversePyramid(20);


            Console.WriteLine(Palindrome("egy")); 
            Console.ReadLine();

        }

        public static bool Palindrome(string str)
        {
            bool result = false;
            string reverseStr = "";

            for (int i = str.Length-1; i >=0; i--)
            {
                reverseStr += str[i];
            }

            if (str==reverseStr)
            {
                result = true;
            }


            return result;
        }

        public static void InversePyramid(int n)
        {

            for (int i = n; i >= 1; i--)
            {

                for (int j = i; j < n; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");

                }
                Console.WriteLine();
            }
        }


        public static void Pyramid(int n)
        {

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                    
                }
                Console.WriteLine();
            }
        }


        public static string ReverseString1(string str)
        {
            string result = "";

            for (int i = str.Length-1; i >= 0; i--)
            {
                result += str[i];
            }

            return result;
        }

        public static int NumberOfWords(string str)
        {
            int result = 0;

            str=str.Trim();

            if (str==" ")
            {
                return 0;
            }

            while (str.Contains("  "))
            {
                str = str.Replace("  ", " ");
            }

            foreach (var item in str.Split(' '))
            {
                result++;
            }

            return result;
        }


        public static bool AnagramControl(string str1, string str2)
        {
            bool result = false;
            char[] chr1 = str1.ToCharArray();
            char[] chr2 = str2.ToCharArray();
            Array.Sort(chr1);
            Array.Sort(chr2);

            string newStr1 = new string(chr1);
            string newStr2 = new string(chr2);

            if (newStr1==newStr2)
            {
                result = true;
            }

            return result;
        }

        public static string RemoveSameCharacters2(string str)
        {
            string result = "";

            foreach (var item in str)
            {
                if (result.IndexOf(item) == -1)
                {
                    result += item;
                }
            }

            return result;
        }

        /// <summary>
        /// Geçici değişken kullanmadan 2 numerik değeri birbirleri ile yer değiştirin.
        /// </summary>
        public static void ReplaceValues(int value1, int value2)
        {
            value1 = value1 + value2;
            value2 = value1 - value2;
            value1 = value1 - value2;

            Console.Write(value1+ " " + value2);
        }
           
        /// <summary>
        /// Buble Sort algoritmasını yazınız.
        /// </summary>
        /// <param name="arr"></param>
        
        public static void BubleSort(int[] arr)
        {
            int temp = 0;

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                for (int j = 1; j <= arr.Length - 1; j++)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
                
            }



            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" " );
            }
        }
           

        /// <summary>
        /// 	Integer Array’deki sıfırları, array’in sonuna taşıyın.
        /// </summary>
        /// <param name="arr"></param>
        public static void PassZeroValues(int[] arr)
        {
            int counter = 0;
            List<int> result = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    counter++;
                }
                else result.Add(arr[i]);
            }

            for (int i = 0; i < counter; i++)
            {
                result.Add(0);
            }


            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
        }



        /// <summary>
        /// Array’i büyükten küçüğe sıralayın.
        /// </summary>
        /// <param name="arr"></param>
        public static void SortArrayDesc(int[] arr)
        {
            Array.Sort(arr);
            Array.Reverse(arr);

            foreach (var item in arr)
            {
                Console.WriteLine(item + " ");
            }
        }


        /// <summary>
        /// 2 Integer Array’deki sayıları ayrı ayrı toplatın, array toplamlarını birbirinden çıkartın.
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>

        public static void SumOfArrays(int[] arr1, int[] arr2)
        {
            int sum1 = 0, sum2 = 0 , result = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                sum1 += arr1[i];
            }

            for (int j = 0; j < arr2.Length; j++)
            {
                sum2 += arr2[j];
            }

            result = sum1 - sum2;

            Console.Write(result);
        }

        /// <summary>
        /// String’deki bütün boşluk karakterlerini tire ile değiştirin.
        /// </summary>
        /// <param name="str"></param>
        public static void ChangeSpaces(string str)
        {
            string newStr = str.Replace(' ', '-');
            Console.WriteLine(newStr);
 
        }

        /// <summary>
        /// String’deki karakterlerin birbirlerinden benzersiz olduğunu doğrulayın.
        /// </summary>
        /// <param name="str"></param>
        public static void VerifyString(string str)
        {
            char[] arr1 = str.ToCharArray();
            List<char> result = new List<char>();
            bool value=false;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (!result.Contains(arr1[i]))
                {
                    result.Add(arr1[i]);
                   
                }
                else
                {
                    value = true;
                    break;
                }
                
            }


            if (value) Console.Write("Tekrar eden karakter var.");
                else Console.Write("Tekrar eden karakter yok.");

        }

        /// <summary>
        /// String’deki tekrar eden karakterleri çıkarın.
        /// </summary>
        /// <param name="str"></param>
        public static void RemoveSameCharacters(string str)
        {
            char[] arr1 = str.ToCharArray();
            
            List<char> result = new List<char>();
        
            for (int i = 0; i < arr1.Length; i++)
            {        
                if (!result.Contains(arr1[i]))
                {
                    result.Add(arr1[i]);
                }
            }


            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
        }



        /// <summary>
        /// Bir string’de yinelenen karakterleri yazdırın.
        /// </summary>
        /// <param name="str"></param>
        public static void FindSameCharacters(string str)
        {
            char[] arr1 = str.ToCharArray();
            char[] arr2 = str.ToCharArray();

            List<char> result = new List<char>();
          
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = i+1; j < arr2.Length; j++)
                {
                    if (arr1[i]==arr2[j])
                    {
                        if (!result.Contains(arr1[i]))
                        {
                            result.Add(arr2[j]);
                        }
                       
                       
                        break;
                    }
                }
            }

            foreach (var item in result)
            {
                Console.Write(item+ " ");
            }
        }

        /// <summary>
        /// İki string’in birbirinin anagramı olup olmadığı kontrol ediniz.
        /// </summary>
        /// <param name="str"></param>

        public static void CheckForAnagram(string str1, string str2)
        {
            bool result = true;


            if (str1.Length!=str2.Length)
            {
                result = false;
            }

            char[] arr1 = str1.ToCharArray();
            char[] arr2 = str2.ToCharArray();

            Array.Sort(arr1);
            Array.Sort(arr2);

            for (int i = 0; i < arr1.Length; i++)
            {
                
                    if (arr1[i]!=arr2[i])
                    {
                        result = false;
                        break;
                    }
                
            }


            if (result) Console.WriteLine("Anagram");
              else Console.WriteLine("Anagram Değil");

        }

        /// <summary>
        /// String, reverse metodu kullanılmadan nasıl ters çevirilir?
        /// </summary>
        /// <param name="str"></param>
        public static void ReverseString(string str)
        {
            string reverseString = "";
            str = str.Trim();


            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverseString += str[i];
            }

            Console.WriteLine(reverseString);
        }

        /// <summary>
        /// String’deki kelime sayısını yazdırın.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="n"></param>

        public static void WriteCountofWords(string str)
        {
            char[] arr = str.ToCharArray();
            int counter = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]== ' ')
                {
                    counter++;
                }
            }

            Console.Write("Kelime Sayısı: "+ counter);
                

        }


        /// <summary>
        /// String i n kez yazdırın
        /// </summary>
        /// <param name="str"></param>
        /// <param name="n"></param>
        public static void WriteNTimes(string str, int n)
        {
            string result = "";

            for (int i = 0; i < n; i++)
            {
                result += str + " ";
            }

            Console.Write(result.Trim());
        }


        /// <summary>
        /// bir array i küçükten büyüğe sıralayın
        /// </summary>
        /// <param name="arr"></param>
        public static void SortArrayAsc(int[] arr)
        {
            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item + " ");
            }
        }


        /// <summary>
        /// bir array in ilk 2 ve son 2 elemanını bulun
        /// </summary>
        /// <param name="presidents"></param>
        public static void FindElementsFromArrays(string[] presidents)
        {
            List<string> newArr = new List<string>();
            newArr.Add(presidents[0]);
            newArr.Add(presidents[1]);

            newArr.Add(presidents.GetValue(presidents.Length - 1).ToString());
            newArr.Add(presidents.GetValue(presidents.Length - 2).ToString());

            foreach (var item in newArr)
            {
                Console.WriteLine(item);
            }
        }


        /// <summary>
        /// bir array içindeki en büyük ve en küçük değerleri bulun
        /// </summary>
        /// <param name="arr"></param>
        public static void FindMaxMin(int[] arr)
        {
            int maxValue = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (maxValue < arr[i])
                {
                    maxValue = arr[i];
                }
            }

            int minValue = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (minValue > arr[i])
                {
                    minValue = arr[i];
                }
            }

            Console.WriteLine(minValue.ToString() + " ," + maxValue.ToString());
        }

        /// <summary>
        /// haftanın günlerini yazdırın
        /// </summary>
        public static void WriteDayOfWeek()
        {
            int day = (int)DateTime.Now.DayOfWeek;


            for (int i = 0; i < CultureInfo.CurrentCulture.DateTimeFormat.DayNames.Length; i++)
            {
                if (i == day)
                {
                    Console.WriteLine(CultureInfo.CurrentCulture.DateTimeFormat.DayNames[i].ToString() + " (bugün)");
                }
                else
                {
                    Console.WriteLine(CultureInfo.CurrentCulture.DateTimeFormat.DayNames[i].ToString());
                }
            }
        }



        public static void WriteSum()
        {
            int toplam = 0;

            for (int i = 1; i < 7; i++)
            {
                while (true)
                {
                    Console.Write("sayi" + i + ": ");
                    if (int.TryParse(Console.ReadLine(), out int number))
                    {
                        toplam = toplam + number;
                        break;
                    }
                }
            }

            Console.WriteLine(toplam);
        }

        public static void Piramit()
        {

            for (int i = 1; i < 20; i++)
            {
                for (int j = i; j < 20; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

       

        public static void MutlakDeger()
        {
            Console.Write("sayi: ");
            int.TryParse(Console.ReadLine(), out int number);

            int mutlakDeger = Math.Abs(number);

            Console.WriteLine(mutlakDeger);
        }
        public static void katlar()
        {
            Console.Write("sayi: ");
            int.TryParse(Console.ReadLine(), out int number);

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void Faktoriyel()
        {
            int result = 1;

            Console.Write("sayı: ");

            int.TryParse(Console.ReadLine(), out int number);

            for (int i = 1; i <= number; i++)
            {
                result = result * i;
            }


            Console.WriteLine(result);
        }

        public static void BasamakSayisi()
        {
            Console.Write("sayi: ");
            int.TryParse(Console.ReadLine(), out int number);
            int count = 1;

            do
            {
                number = number / 10;
                count++;
            } while (number > 10);


            Console.Write(count);

        }

        public static void BasamakDegeri()
        {
            Console.Write("sayi: ");
            int.TryParse(Console.ReadLine(), out int number);

            int yuzler = number / 100;

            number = number - (yuzler * 100);
            int onlar = number / 10;

            number = number - (onlar * 10);

            int birler = number;

            Console.WriteLine("yüzler: " + yuzler);
            Console.WriteLine("onlar: " + onlar);
            Console.WriteLine("birler: " + birler);

        }
        public static void Asalsayi()
        {
            Console.Write("sayi: ");
            int.TryParse(Console.ReadLine(), out int number);

            bool value = false;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    value = true;
                }
            }

            if (value)
            {
                Console.WriteLine("asal sayı değil");
            }
            else Console.WriteLine("asal sayı");
        }



    }
}
