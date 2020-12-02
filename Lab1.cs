using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Task1
    {
        static public List<object> GetIntegerFromList(List<object> input_list)
        {
            return input_list.Where(el => el.GetType().Equals(typeof(int))).ToList();
        }
    }
    class Task2
    {
        static public char First_non_repeating_letter(string input_str)
        {
            return input_str.Where(el => input_str.Length.Equals(input_str.ToLower().Replace(el.ToString().ToLower(), "").Length + 1)).FirstOrDefault();
        }
    }
    class Task3
    {
        static public int DigitalRoot(int input)
        {
            int res = (int)input.ToString().ToList().ConvertAll(el => char.GetNumericValue(el)).Sum();
            return res.ToString().Length < 2 ? res : Task3.DigitalRoot(res);
        }
    }
    class Task4
    {
        static public int NumberOfPairs(int[] input_array, int trnum)
        {
            int i = 0;
            List<int> list = input_array.ToList();
            foreach (int x in input_array)
            {
                i += list.Where(el => el + x == trnum).Count();
                list.Remove(x);
            }
            return i;
        }
    }
    class Task5
    {
        static string MeetingHelper(ref string s)
        {
            string end = s.Substring(s.IndexOf(':') + 1);
            s = string.Concat("(", s.Replace(end, s.Substring(0, s.IndexOf(':'))).Replace(s.Substring(0, s.IndexOf(':') + 1), string.Concat(end, ", ")), ")");
            return s;
        }
        static public string Meeting(string s)
        {
            if (s.Contains(":"))
            {
                List<string> s1 = new List<string> { };
                s.ToUpper().Split(';').ToList().OrderBy(el => el.Substring(el.IndexOf(':') + 1)).ThenBy(el => el.Substring(0, el.IndexOf(':'))).ToList().ForEach(el => s1.Add(MeetingHelper(ref el)));
                return string.Join("", s1);
            }
            else return "";
        }
    }
    class ExtraTask1
    {
        static public int nextBigger(int input)
        {
            string input_str = input.ToString();
            if (string.Join("", input_str.OrderByDescending(v => v).ToList()) == input_str) return -1;
            else
            {
                char[] arr = input_str.ToArray();
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[i] > arr[i - 1])
                    {
                        char temp = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = temp;
                        return Convert.ToInt32(string.Join("", arr));
                    }
                }
            }
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
