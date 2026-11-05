public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> numbers = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++) {
            if(!numbers.Add(nums[i])){
                return true;
            }
        }
        return false;
    }
}