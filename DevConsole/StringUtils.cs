using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevConsole
{
    public class StringUtils
    {

        public string ReverseWord(string sentence,char[] Delimiters)
        {
            StringBuilder sb = new StringBuilder();

            var arr = sentence.ToCharArray();

            StringBuilder temp = new StringBuilder();
            for (int i = 0; i < arr.Length; i++)
            {
                var result = Delimiters.Select(c => c == arr[i]).FirstOrDefault();
                if (result == null)
                {
                    temp.Append(arr[i]);
                }
                else
                {
                    var reversvedStr = Reverse(temp.ToString());
                    sb.Append(arr[i]);
                    sb.Append(reversvedStr);
                    temp = new StringBuilder();
                }
            }

            return sb.ToString();
        }        

        public string Reverse(string words)
        {
            var arr = words.ToCharArray();

            var len = arr.Length;
            for (int i = 0; i < len / 2; i++)
            {
                var temp = arr[i];
                arr[i] = arr[len-i];
                arr[len - i] = temp;                
            }

            return arr.ToString();
        }

        public int CountOccurrence(string parent, string sub)
        {
            int count = 0;

            int len = parent.Length;
            int index = 0;
            int startIndex = 0;

            while(index >= 0)
            {
                index = parent.IndexOf(sub,startIndex);
                if (index >= 0)
                {
                    count++;
                    startIndex = index + 1;
                }
            }

            return count;
        }

        public int CountOccurenceNoFunction(string parent, string sub)
        {
            int count = 0;
            int len = parent.Count();
            MatchState State = MatchState.Looking;

            char[] parentArr = parent.ToCharArray();
            char[] subArr = sub.ToCharArray();

            int ProgressIndex = 0;

            for (int i = 0; i < len; i++)
            {
                switch (State)
                {
                    case MatchState.Looking:                        
                        if (subArr[ProgressIndex] == parentArr[i])
                        {                                                        
                            if (ProgressIndex == subArr.Length)
                            {
                                State = MatchState.Matched;                                
                            }
                            else
                            {
                                State = MatchState.MatchProgress;
                                ProgressIndex++;
                            }                            
                        }                        
                        break;
                    case MatchState.MatchProgress:
                        if (subArr[ProgressIndex] == parentArr[i])
                        {
                            if (ProgressIndex == subArr.Length)
                            {
                                State = MatchState.Matched;                                
                            }
                            else
                            {
                                ProgressIndex++;
                            }
                        }
                        break;
                    case MatchState.Matched:
                        break;
                }

                if (State == MatchState.Matched)
                {
                    count++;
                    State = MatchState.Looking;
                    ProgressIndex = 0;
                }

                if (State == MatchState.Looking && len - i - ProgressIndex < sub.Length)
                {
                    break;
                }
                
            }

            return count;
        }

        public string RemoveCharacter(string parent, char character)
        {
            StringBuilder sb = new StringBuilder();
            var charArr = parent.ToCharArray();
            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i] != character)
                {
                    sb.Append(charArr[i]);
                }
            }

            return sb.ToString();
        }
    }

    public enum MatchState
    {
        Looking = 1,
        MatchProgress = 2,
        Matched = 3
    }
    
}
