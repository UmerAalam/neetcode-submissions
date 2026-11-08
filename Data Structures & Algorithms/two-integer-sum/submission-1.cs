public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> values = new Dictionary<int,int>();
        int length = nums.Length;
        for(int i = 0; i < length; i++) {
            int difference = target - nums[i];
            if(!values.ContainsKey(nums[i])){
                values.Add(nums[i],i);
            }
            if(values.ContainsKey(difference) && values[difference] != i){
                int firstValue = 0;
                if(values.TryGetValue(difference, out int value)){
                    firstValue = value;
                }
                return [value,i];
            }
        }
        return [];
    }
}
// Check Same Key Problem
