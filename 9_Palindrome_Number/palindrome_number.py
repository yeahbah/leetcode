class Solution:
    def isPalindrome(self, x: int) -> bool:
        temp = str(x)
        temp = temp[::-1]
        return str(x) == temp

    
solution = Solution()

print(solution.isPalindrome(121))
print(solution.isPalindrome(-121))
print(solution.isPalindrome(99999999))
print(solution.isPalindrome(1111222221111))