using System;

namespace MyString
{
    public class Str
    {
        public static void AllCountSymbols(ref string str, ref string key)
        {
            for (int i = 0; i < str.Length; i++)
            {
                bool check = true;

                for (int j = 0; j < key.Length; j++)
                {
                    if (str[i] == key[j])
                    {
                        check = false;
                        break;
                    }
                }

                if (check == true)
                {
                    key += str[i];
                    int count = 0;
                    for (int j = i; j < str.Length; j++)
                        if (str[j] == str[i])
                            count += 1;
                    Console.WriteLine(str[i] + " " + count);
                }
            }
        }

        public static void LocaleCountSymbols(ref string str)
        {           
            string rezult = "" + str[0];
            int temp = 1;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == rezult[rezult.Length - 1])
                    temp += 1;
                else
                {
                    rezult += "{" + temp + "}" + str[i];
                    temp = 1;
                }
            }
           
            str = rezult + "{" + temp + "}";
        }

        public static void SortWordsABC(ref string [] words)      //Compare - 0 - строки рівні, -х - перша строка раніше другої, х - перша строка пізніше другої
        {
            int count_true = 0;
            while (count_true != words.Length - 1)
            {
                count_true = 0;
                for (int i = 0; i < words.Length - 1; i++)
                {
                    if (String.Compare(words[i], words[i + 1]) > 0)
                    {
                        string temp = words[i];
                        words[i] = words[i + 1];
                        words[i + 1] = temp;
                    }
                }

                for (int i = 0; i < words.Length - 1; i++)
                    if (String.Compare(words[i], words[i + 1]) <= 0)
                        count_true += 1;
            }
        }

        public static void GetArrayOfWords(ref char key, ref string str, out string [] rezult)  //Split - розбиття за символом на масив строк
        {
            rezult = str.Split(key);

            /*
             * 
            int count_words = 0;    //кількість слів
            for (int i = 0; i < str.Length; i++) //і - індекс в головній строці
                if (str[i] == key) //якщо ми найшли символ за яким хочемо розбити - ми знайшли слово
                    count_words += 1;
            count_words += 1;  //слово після останнього ключового символу

            rezult = new string[count_words];  //масив що повернеться
            string temp = "";  //слово
            int j = 0;  //індекс масива строк
            for (int i = 0; i < str.Length; i++)  //і - індекс головної строки
            {
                if (str[i] != key)  //поки не знайдено ключовий символ формуємо слово
                    temp += str[i];
                else
                {
                    rezult[j] = temp;  //додаємо слово в масив
                    temp = "";  //очищуємо тимчасову змінну 
                    j += 1;  //зібльшуємо індекс масива
                }
            }
            rezult[j] = temp; //додаємо останнє слово
             * 
             */
        }

        public static void DeleteWordConstSize(ref string str, int size)  //Substring - отримати підстроку, IndexOf - ындекс першого входження елемента, Remove - обрізати строку
        {
            string temp = "";
            str += " ";
            while (str.Length != 0)
            {
                if (str.IndexOf(' ') == size)
                    temp += str.Substring(0, str.IndexOf(' ') + 1);
                str = str.Remove(0, str.IndexOf(' ') + 1);
            }
            str = temp;
        }

        public static void UniformAddedSpace(ref string str) //Insert - вставити в позицію символ
        {
            int i = 0;
            while (str.Length != 60)
            {
                if (i == str.Length - 1)
                    i = 0;
                if (str[i] == ' ')
                {
                    i += 1;
                    str = str.Insert(i, " ");
                }
                i += 1;
            }
        }

        public static void DeleteWordsWithEvenMumber(ref string str, out int max)
        {
            int index_space = 0;
            string rezult = "";
            max = 0;
            str += " ";
            while (str != "")
            {
                if (index_space % 2 == 0)
                {
                    string temp = str.Substring(0, str.IndexOf(' '));
                    rezult += temp + " ";
                    if (temp.Length > max)
                        max = temp.Length;
                }
                str = str.Remove(0, str.IndexOf(' ') + 1);
                index_space += 1;
            }
            str = rezult;
        }

        public static void DeleteWordsWithOddMumber(ref string str, out int max)
        {
            int index_space = 0;
            string rezult = "";
            max = 0;
            str += " ";
            while (str != "")
            {
                if (index_space % 2 == 1)
                {
                    string temp = str.Substring(0, str.IndexOf(' '));
                    rezult += temp + " ";
                    if (temp.Length > max)
                        max = temp.Length;
                }
                str = str.Remove(0, str.IndexOf(' ') + 1);
                index_space += 1;
            }
            str = rezult;
        }

        public static void CountWordsWithEqualStart(string str, string key, out int count_words)
        {
            count_words = 0;
            while (str.IndexOf(key) != -1)
            {
                str = " " + str;
                if (str[str.IndexOf(key) - 1] == ' ')
                    count_words += 1;
                str = str.Remove(0, str.IndexOf(key) + key.Length + 1);
                str = str.Remove(0, str.IndexOf(" ") + 1);
            }
        }

        public static void PrintStringArray(ref string[] str)
        {
            Console.WriteLine("Rezult : \n");
            for (int i = 0; i < str.Length; i++)
                Console.WriteLine(str[i] + "\n");
        }

        public static void ReplaceGen(ref string str)
        {
            str = str.Replace(" ", "_");
        } //Replace - заміна одних слів на інші

        public static void StrTrim(ref string str) //Trim - обрізає символи спочатку і з кінця
        { 
            /*str = str.Trim();
            str = str.Trim(new char[] { 'd', 'h' });*/

            while(str[0] == ' ')
            {
               str = str.Remove(0,1);
            }
            while (str[str.Length - 1] == ' ')
            {
                str = str.Remove(str.Length - 1, 1);
            }
            
        }        

    }
}
