public class Solution {
    public bool DivideArray(int[] nums) {
        Dictionary<int, int> d = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++) d[nums[i]] = d.GetValueOrDefault(nums[i]) + 1;

        foreach(int x in d.Keys) if(d[x] % 2 != 0) return(false);

        return(true);
    }
}
