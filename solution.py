class Solution:
    def divideArray(self, nums):
        c = Counter(nums)
        for x in c: if c[x] % 2 != 0: return False
        
        return True
