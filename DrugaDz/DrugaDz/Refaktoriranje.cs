using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugaDz
{
    public class Refaktoriranje
    {
        //2. zadatak
        public class Average
        {
            public List<double> CalculateAverages(List<double[]> arrays)
            {
                List<double> averages = new List<double>();
                foreach (double[] array in arrays) 
                {
                    double sum = CalculateSum(array);
                    double average=sum/array.Length;
                    averages.Add(average);
                }
                return averages;
            }
            public double CalculateSum(double[] array)
            {
                double sum = 0;
                foreach (double value in array) 
                {
                    sum += value;
                }
                return sum;
            }
        }
        //4. zadatak
        public class UniqueCharacterFinder
        {
            public void CountCharOccurence(string text)
            {
                var characterCounts = new Dictionary<char,int>();
                foreach (char character in text)
                {
                    if(characterCounts.ContainsKey(character))
                        characterCounts[character]++;
                    else
                        characterCounts.Add(character, 1);
                }
            }
            public List<char> GetUniqueChars (Dictionary<char,int> characterCounts)
            {
                List<char> uniqueChars = new List<char>();
                foreach (var chararacter in characterCounts)
                {
                    if (chararacter.Value == 1)
                        uniqueChars.Add(chararacter.Key);
                }
                return uniqueChars;
            }
        }
        //5. zadatak
        public class PalindromeFinder
        {
            public List<string> FindPalindromes(List<string> strings)
            {
                if (strings == null)
                    return new List<string>();

                List<string> palindromes = new List<string>();
                foreach (string str in strings)
                {
                    if (IsPalindrome(str))
                        palindromes.Add(str);
                }
                return palindromes;
            }

            private bool IsPalindrome(string input)
            {
                string cleaned = RemoveSpacesAndToLower(input);
                string reversed = ReverseString(cleaned);
                return cleaned.Equals(reversed);
            }

            private string RemoveSpacesAndToLower(string input)
            {
                return input.Replace(" ", "").ToLower();
            }

            private string ReverseString(string input)
            {
                return new string(input.Reverse().ToArray());
            }
        }
    }
}
