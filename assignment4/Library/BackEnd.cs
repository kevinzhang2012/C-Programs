using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BackEnd
    {
        private List<string> words;
        private List<string> content;
        private Dictionary<string, int> length;
        public Dictionary<string, int> frequency;
        
        public BackEnd()
        {

        }
        public BackEnd(string data)
        {
            words = new List<string>(data.Split(' ', '\r'));
            content = new List<string>(data.Split(' ', '\r', '\n'));           
            frequency = BuildOccu(content);
            length = BuildLeng(content);
        }

        //Load Occurances
        public Dictionary<string, int> BuildOccu(List<string> list)
        {
            var occu = new Dictionary<string, int>();
            foreach (string key in list.Where(word => word != ""))
            { 
                if (occu.ContainsKey(key))
                {
                    occu[key]++;
                }
                else
                {
                    occu[key] = 1;
                }
            }
            return occu;
        }

        //Load Length
        public Dictionary<string, int> BuildLeng(List<string> list)
        {
            var leng = new Dictionary<string, int>();
            foreach (string key in list.Where(word => word != ""))
            {
                leng[key] = key.Length;
            }           
            return leng;
        }

        //--------------------------DISPLAY--------------------------
        //---------------Display messages in TextBoxes---------------
        public string MostCommon()
        {
            int max = 0;
            foreach (string key in frequency.Keys)
            {
                if (frequency[key] > max)
                {
                    max = frequency[key];
                }
            }
            var message = "Frequency: " + max.ToString() + " times\n";
            foreach (string key in frequency.Keys)
            {
                if (frequency[key] == max)
                {
                    message += key + " ";
                }

            }
            return message;
        }
        public string LongestLength()
        {
            string message = "Longest: " + length.Values.Max() + " letters.\n";
            foreach (string key in length.Keys)
            {
                if (length[key] == length.Values.Max())
                {
                    message += key + " ";
                }
            }
            return message;
        }

        public string ShortestLength()
        {
            string message = "Shorest: " + length.Values.Min() + " letters.\n";
            foreach (string key in length.Keys)
            {
                if (length[key] == length.Values.Min())
                {
                    message += key + " ";
                }
            }
            return message;
        }

        public string AverageLength()
        {
             return length.Values.Average().ToString("0.00");
        }

        public string SearchWord(string key)
        {
            if (key == "")
            {
                return "Please Enter a word to search.";
            }
            if (frequency.ContainsKey(key))
            {
                return "Number of occurrences: " + frequency[key] ;
            }
            else
            {
                return "Cannot find the specific word.";
            }
        }

        public string SearchLength(int value)
        {
            //Sort order
            var sort = length;
            var list = sort.Keys.ToList();
            list.Sort();

            string message = "";
            if (length.ContainsValue(value))
            {   
                foreach (string key in list) 
                {
                    message += (sort[key] == value) ? key + ", " : "";
                }
                return message;
            }
            else
            {
                return "Cannot find the specific word.";
            }
        }

        public string Unique()
        {
            string message = "";
            foreach (string key in frequency.Keys)
            {
                message += key+",";
            }
            return message;
        }

        public int WordsCount()
        {
            return words.Count;
        }

        public string AverageLengthAll()
        {
            double sum = 0;
            foreach (string key in frequency.Keys)
            {
                sum += frequency[key] * length[key];
            }
            return (sum / words.Count).ToString("0.00");
        }
    }
}
