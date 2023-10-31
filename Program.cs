public class Solution {
    public bool IsAnagram(string s, string t) {
           
            if(s.Length != t.Length)
            {
                return false;
            }
            
            char[] first = s.ToCharArray();
            char[] sec = t.ToCharArray();
            Array.Sort(first);
            Array.Sort(sec);               

            for(int i = 0; i < first.Length; i++)
            {
                if (first[i] != sec[i])
                {
                    return false;
                }
            }

            return true;
    }
}
