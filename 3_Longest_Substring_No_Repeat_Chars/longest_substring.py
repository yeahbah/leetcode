class Solution:
    # O(N2 + M) very slow
    def lengthOfLongestSubstring(self, s: str) -> int:
        substrings = {}
        hash = {}
        sub = ''
        for i in range(0, len(s)):
            sub = s[i]
            hash[s[i]] = True
            for j in range(i + 1, len(s)):
                if s[j] in hash:
                    substrings[sub] = len(sub)
                    hash.clear()
                    sub = ''
                    break
                else:                    
                    sub += s[j]   
                    hash[s[j]] = True
            if len(sub) > 0:
                substrings[sub] = len(sub)
                hash.clear()
        
        c = 0
        for r in substrings: 
            l = len(r)           
            if l > c:
                c = l
        
        # return (c, substrings)
        return c
        

sample1 = 'abcabccbb'
sample2 = 'bbbbb'
sample3 = 'pwwkew'

solution = Solution()
result = solution.lengthOfLongestSubstring(sample1)
print(result)

result = solution.lengthOfLongestSubstring(sample2)
print(result)

result = solution.lengthOfLongestSubstring(sample3)
print(result)

# # expected: y1239
result = solution.lengthOfLongestSubstring('yyy12399bbcde')
print(result)

result = solution.lengthOfLongestSubstring('hello world')
print(result)

