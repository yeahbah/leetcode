class Solution:
    def isPalindrome(self, x: int) -> bool:
        temp1 = str(x)
        temp = temp1[::-1]
        return temp1 == temp

    
solution = Solution()

print(solution.isPalindrome(121))
print(solution.isPalindrome(-121))
print(solution.isPalindrome(99999999))
print(solution.isPalindrome(1111222221111))