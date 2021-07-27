class Solution:
    def twoSum(self, nums, target: int):
            result = []
            for i in range(0, len(nums)):
                for j in range(i + 1, len(nums)):
                    sum = nums[i] + nums[j]
                    if sum == target:
                        result.append(i)
                        result.append(j)
                        break
                if len(result) > 0:
                    return result  

    def twoSum2(self, nums, target: int):
        dict = {}
        for i in range(len(nums)):
            sums = target - nums[i]
            if sums in dict:
                return [i, dict[sums]]
            else:
                dict[nums[i]]=i             

solution = Solution()
result = solution.twoSum2([2, 7, 11, 15], 18)
print(result)
