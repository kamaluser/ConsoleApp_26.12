using System;
using System.Threading;

namespace ConsoleApp_
{
    internal class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            // 1. Verilmiş 3 ədəddən hansının ən böyük olduğunu tapan proqram
            #region Task1

            //Console.WriteLine("Ededleri daxil et: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //if (a > b)
            //{
            //    if (b > c)
            //    {
            //        Console.WriteLine($"en boyuk {a}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"en boyuk {c}");
            //    }
            //}
            //else if (b > c)
            //{
            //    Console.WriteLine($"en boyuk {b}");
            //}
            //else
            //{
            //    Console.WriteLine($"en boyuk {c}");
            //}
            #endregion

            // 2. Verilmiş yazının içində A hərfinin olub olmadığını tapan proqram

            #region Task2

            //Console.WriteLine("Yazini daxil et: ");
            //string text = Console.ReadLine();
            //bool check = false;
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == 'A')
            //    {
            //        check = true;
            //        break;
            //    }
            //}
            //if(check == true)
            //{
            //    Console.WriteLine("'A' herfi var");
            //}
            //else 
            //{
            //    Console.WriteLine("'A' herfi yoxdur");
            //}

            #endregion

            // 3. Verilmiş yazıda neçə A hərfinin olduğunu tapan proqram

            #region Task3

            //Console.WriteLine("Yazini daxil et: ");
            //string str = Console.ReadLine();
            //int count = 0;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] == 'A')
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);


            #endregion

            // 4. Verilmiş müsbət cüt ədədi kradtarına yüksəldən proqram. Daxil edilən ədə musbət və cüt olmadıqca yenidən daxil edilməlidir

            #region Task4

            //int num;
            //do
            //{
            //    Console.WriteLine("Ededi daxil et: ");
            //    num = Convert.ToInt32(Console.ReadLine());
            //} while (num<=0 || num%2!=0);
            //int result = num * num;
            //Console.WriteLine(result);

            #endregion

            // 5. Verilmiş 5 uzunluqlu ədədlər siyahısındaki ədədlərin cəmini tapan proqram

            #region Task5

            //Console.WriteLine("Ededler siyahisinin uzunlugunu daxil et: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] nums = new int[n];
            //int total = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine("Ededi daxil et");
            //    nums[i] = Convert.ToInt32(Console.ReadLine());
            //    total += nums[i];
            //}
            //Console.WriteLine(total);

            #endregion

            // 6. Verilmiş təhsil növü dəyərinə əsasən o təhsilin saatını göstərən proqram.
            // Əgər verilmiş dəyər "programming"dirsə console-da 400 saat, "design"dırsa 250 saat,
            // "system"dirsə 200 saat, heç biri deyilsə "təhsil novu yanlisdir" yazılmalıdır console-da.

            #region Task6

            //Console.WriteLine("Tehsil novunu daxil et: ");
            //string tehsilNovu = Console.ReadLine();
            //switch (tehsilNovu)
            //{
            //    case "programming":
            //        Console.WriteLine("400 saat");
            //        break;
            //    case "design":
            //        Console.WriteLine("250 saat");
            //        break;
            //    case "system":
            //        Console.WriteLine("200 saat");
            //        break;
            //    default:
            //        Console.WriteLine("tehsil novu yanlisdir");
            //        break;
            //}


            #endregion



            //=================================================================================================================



            // 1. Verilmiş yazıdan içində boşluqlar olmayan yeni bir yazı düzəltmək 

            #region Task2.1

            //Console.WriteLine("Yazini daxil et: ");
            //string text = Console.ReadLine();
            //string newText = "";
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] != ' ')
            //    {
            //        newText += text[i];
            //    }
            //}
            //Console.WriteLine(newText);

            #endregion

            // 2. Verilmiş ədədlər siyahısındaki verilmiş n ədədinin yerləşdiyi indexi tapan proqram

            #region Task2.2

            //Console.WriteLine("Ededler siyahisinin uzunlugunu daxil et: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Axtarilan eded: ");
            //int axtarilanEded = Convert.ToInt32(Console.ReadLine());
            //int[] nums = new int[n];
            //int index = -1;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine("Ededleri daxil et: ");
            //    nums[i] = Convert.ToInt32(Console.ReadLine());
            //    if (nums[i] == axtarilanEded)
            //    {
            //        index = i;
            //        break;
            //    }
            //}

            //if(index != -1)
            //{
            //    Console.WriteLine(index);
            //}
            //else
            //{
            //    Console.WriteLine("Eded siyahida yoxdur");
            //}

            #endregion

            // 3. Verilmiş yazılar siyahısında verilmiş hərfdən neçə ədəd olduğunu tapan proqram

            #region Task2.3

            //Console.WriteLine("Yazilar siyahisinin uzunlugunu daxil et: ");
            //int length = Convert.ToInt32(Console.ReadLine());
            //string[] strings = new string[length];
            //Console.WriteLine("Axtarilan herf: ");
            //char letter = Convert.ToChar(Console.ReadLine());
            //int count = 0;
            //for (int i = 0; i < strings.Length; i++)
            //{
            //    Console.WriteLine("Siyahinin elementlerini daxil et: ");
            //    strings[i] = Console.ReadLine();
            //    for (int j = 0; j < strings[i].Length; j++)
            //    {
            //        if (strings[i][j] == letter)
            //        {
            //            count++;
            //        }
            //    }
            //}
            //Console.WriteLine(count);

            #endregion

            // 4. Verilmiş yazının əvvəlindəki boşluqlar silinmiş bir string düzəldən proqram
            // (Misalçün verilmiş yazı "   salam necesen?   "-dirsə yeni düzələcək string "salam necəsən?   " olmalıdır.

            #region Task2.4

            //Console.WriteLine("Yazini daxil et: ");
            //string text = Console.ReadLine();
            //string text2 = "";
            //int baslangicIndex = 0;
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] != ' ')
            //    {
            //        baslangicIndex = i;
            //        break;
            //    }
            //}
            //for (int j = baslangicIndex; j < text.Length; j++)
            //{
            //    text2 += text[j];
            //}
            //Console.WriteLine(text2);
            #endregion

            // 5. Verilmiş 2 ədəd üzərində verilmiş simvola uyğun əməliyyat edən proqram.
            // Simvol +,-,* və ya / olmalıdır, əks halda simvolu yenidən daxil edilməsi istənilməlidir.
            // (Misaçün simvol * olarsa verilmiş 2 ədəd vurulacaq və nəticəsi göstəriləcək)

            #region Task2.5

            //Console.WriteLine("Ededleri daxil et: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int result = 0;
            //bool check = true;
            //do
            //{
            //    check = true;
            //    Console.WriteLine("Emeliyyat: ");
            //    char opr = Convert.ToChar(Console.ReadLine());
            //    switch (opr)
            //    {
            //        case '+':
            //            result = num1 + num2;
            //            break;
            //        case '-':
            //            result = num1 - num2;
            //            break;
            //        case '*':
            //            result = num1 * num2;
            //            break;
            //        case '/':
            //            result = num1 / num2;
            //            break;
            //        default:
            //            check = false;
            //            Console.WriteLine("Emeliyyat yanlisdir!");
            //            break;
            //    }

            //} while (check == false);
            //Console.WriteLine(result);

            #endregion


            //=============================================================================================================

            //LAB

            //=============================================================================================================



            //Verilmis ededin kavadratini tapan proqram

            #region Lab1

            //Console.WriteLine("Ededi daxil et: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int result = number * number;
            //Console.WriteLine(result);

            #endregion


            //Verilmis ededin verilmis quvvetini tapan proqram

            #region Lab2

            //int result = 1;
            //Console.WriteLine("Ededi daxil et: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Quvveti daxil et: ");
            //int power = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < power; i++)
            //{
            //    result *= num;
            //}
            //Console.WriteLine(result);


            #endregion


            //2-ci meselede verilmis quvvet musbet eded olmasa yeniden daxil edilmesini istesin

            #region Lab3


            //int result = 1;
            //int power;
            //Console.WriteLine("Ededi daxil et: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //do
            //{

            //    Console.WriteLine("Quvveti daxil et: ");
            //    power = Convert.ToInt32(Console.ReadLine());
            //    for (int i = 0; i < power; i++)
            //    {
            //        result *= num;
            //    }
            //} while (power<=0);
            //Console.WriteLine(result);


            #endregion


            // verilmis yazinin icindeki bosluqlarin sayini tapan proqram

            #region Lab4

            //Console.WriteLine("Yazini daxil et: ");
            //string text = Console.ReadLine();
            //int count = 0;
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == ' ')
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            #endregion


            //verilmis textin solundan verilen eded geder silinsin 

            #region Lab5

            //Console.WriteLine("Yazini daxil et: ");
            //string text = Console.ReadLine();
            //Console.WriteLine("Verilen eded: ");
            //int v = Convert.ToInt32(Console.ReadLine());
            //string newText = "";
            //for(int i = v; i < text.Length; i++)
            //{
            //    newText += text[i];
            //}
            //Console.WriteLine(newText);

            #endregion


            //Verilmis adlar siyahisinda adinin uzunlugu 5-den uzun olan nece ad oldugunu tapanm proqram

            #region Lab6

            //Console.WriteLine("Adlar siyahisinin uzunlugunu daxil et: ");
            //int length = Convert.ToInt32(Console.ReadLine());
            //string[] strArr = new string[length];
            //int count = 0;
            //for (int i = 0; i < strArr.Length; i++)
            //{
            //    Console.WriteLine("Siyahidaki elementleri daxil et: ");
            //    strArr[i] = Console.ReadLine();
            //    if (strArr[i].Length > 5)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);


            #endregion

            //Verilmis adlar siyahisinda adinin uzunlugu 5-den uzun olan adlardan
            //ibaret yeni bir array duzelden proqram

            #region Lab7

            //Console.WriteLine("Adlar siyahisinin uzunlugunu daxil et: ");
            //int length = Convert.ToInt32(Console.ReadLine());
            //string[] strArr = new string[length];
            //int count = 0;
            //for (int i = 0; i < strArr.Length; i++)
            //{
            //    Console.WriteLine("Siyahidaki elementleri daxil et: ");
            //    strArr[i] = Console.ReadLine();
            //    if (strArr[i].Length > 5)
            //    {
            //        count++;
            //    }
            //}

            //string[] newArr = new string[count];
            //int index = 0;
            //for (int i = 0; count < strArr.Length; i++)
            //{
            //    if (strArr[i].Length > 5)
            //    {
            //        newArr[index] = strArr[i];
            //        index++;
            //    }
            //}
            //Console.WriteLine(newArr[i]);

            #endregion


            //                            -------BUGUNUN TASKI-------

            // 1. Verilmiş yazının sonundaki boşluqları silinmiş yeni bir yazı düzəldən proqram yazırsınız

            #region Day9 Task1

            //Console.WriteLine("Yazini daxil et: ");
            //string str = Console.ReadLine();
            //string newStr = "";
            //int endIndex = str.Length - 1;
            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    if (str[i] != ' ')
            //    {
            //        endIndex = i;
            //        break;
            //    }
            //}
            //for (int i = 0; i <= endIndex; i++)
            //{
            //    newStr += str[i];
            //}
            //Console.WriteLine(newStr);

            #endregion
        }
    }
}
