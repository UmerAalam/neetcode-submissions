public class Solution {
    public bool IsValid(string s) {
        Stack<char> values = new();
        Dictionary<char, char> closeToOpen = new() { { ')', '(' }, { '}', '{' }, { ']', '[' } };
        foreach (char c in s) {
            if(closeToOpen.ContainsKey(c)){
                if(values.Count > 0 && values.Peek() == closeToOpen[c]){
                    values.Pop();
                } else {
                    return false;
                }
            } else {
                values.Push(c);
            }
        }
        return values.Count == 0;
    }
}
