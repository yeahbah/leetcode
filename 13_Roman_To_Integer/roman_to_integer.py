class Solution:
    def romanToInt(self, s: str) -> int:
        romans = {'M': 1000, 'CM': 900, 'D': 500, 'CD': 400, 'C': 100, 'XC': 90, 'L': 50, 'XL': 40, 'X': 10, 'IX': 9, 'V': 5, 'IV': 4, 'I': 1}

        result = 0
        skip = []
        for index, item in enumerate(s):
            if item in ['C', 'X', 'I'] and (index + 1) < len(s):                
                next = s[index + 1]
                x = item + next
                if x in romans:                    
                    result += romans[x]
                    skip.append(index + 1)
                
                elif index not in skip:
                    result += romans[item]
                
            elif index not in skip:
                result += romans[item]

        return result

    //https://leetcode.com/problems/roman-to-integer/discuss/1501399/Python-mapping-dictionary-solution
    def romanToInt2(self, s: str) -> int:
        # create mapping dict for rom chars -> nums
        map_d = {
            'I': 1,
            'V': 5,
            'X': 10,
            'L': 50,
            'C': 100,
            'D': 500,
            'M': 1000,
        }
        n = 0
        
        for x in range(0, len(s) - 1):
            # if current char val is less than next, i.e. IV, subtract I then add V
            if map_d[s[x]] < map_d[s[x + 1]]:
                n -= map_d[s[x]]
            else:
                n += map_d[s[x]]
                
        # add final char
        n += map_d[s[-1]]
        
        return n
            

solution = Solution()
print(solution.romanToInt2('IV'))
print(solution.romanToInt2('III'))
print(solution.romanToInt2('CCC'))
print(solution.romanToInt2('IX'))
print(solution.romanToInt2('MCMXCIV'))
