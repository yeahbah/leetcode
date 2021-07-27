class Solution:
    def reverse(self, x: int) -> int:
        number = list(str(abs(x))) 
        j = 1
        for i in range(0, len(number)):    
            last_index = len(number) - j
            if i == last_index or i > last_index:
                break
            tmp = number[i]
            number[i] = number[last_index]
            number[last_index] = tmp
            j += 1

        result = int(''.join(number))
        if result > 2147483647:
            return 0

        if x < 0:
            return result * -1
        else:
            return result

    # https://leetcode.com/problems/reverse-integer/discuss/1364007/99.55-Faster-Python-O(n)-Easily-understandable
    def reverse2(self, x: int) -> int:
        if(x>0):
            a = str(x)
            a = a[::-1]
            return int(a) if int(a)<=2**31-1 else 0
        else:
            x=-1*x
            a = str(x)
            a = a[::-1]
            return int(a)*-1 if int(a)<=2**31 else 0 

solution = Solution()
print(solution.reverse(123))
print(solution.reverse2(123))
print(solution.reverse(-123))
print(solution.reverse2(-123))
# print(solution.reverse(120))
# print(solution.reverse(0))
print(solution.reverse(2147483647))
print(solution.reverse2(2147483647))

# https://www.geeksforgeeks.org/python-arrays/
print('reversestring'[::-1])
