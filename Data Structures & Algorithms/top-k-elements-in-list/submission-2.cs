public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> values = new();
        int length = nums.Length;
        foreach(int num in nums){
            if(values.ContainsKey(num)){
                values[num] = values.GetValueOrDefault(num,1) + 1;
            }
            else {
                values.Add(num, 1);
            }
        }
        //Sort Values Here
        int[] sortedKItems = SortedArray(values);
        int[] result = sortedKItems.Take(k).ToArray();
        return result;
    }
    private int[] SortedArray(Dictionary<int,int> values){
        int[] keys = values.Keys.ToArray();
        int length = keys.Length;
        for (int i = 0; i < length - 1; i++) {
            bool isSwapped = false;
            for (int y = 0; y < length - 1; y++) {
                int currentIndexValue = values[keys[y]];
                int nextIndex = y + 1;
                int nextIndexValue = values[keys[nextIndex]];
                if(currentIndexValue < nextIndexValue){
                    int temp = keys[y];
                    keys[y] = keys[nextIndex];
                    keys[nextIndex] = temp;
                    isSwapped = true;
                }
            }
            if(!isSwapped) break;
        }
    return keys;
    }
}
