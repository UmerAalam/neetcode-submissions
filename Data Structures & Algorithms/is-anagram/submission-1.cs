public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] sValues = s.ToCharArray();
        Array.Sort(sValues);
        char[] tValues = t.ToCharArray();
        Array.Sort(tValues);
        if(sValues.Length != tValues.Length){
            return false;
        }
        int Length = sValues.Length;
        for(int i = 0; i < Length; i++){
            if(sValues[i] != tValues[i]){
                return false;
            }
        }
        return true;
    }
}

// Check Same Amount Of characters;
