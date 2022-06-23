from collections import deque


class Solution(object):
    def hello(self):
        print('Hello!')
    
    # O(N)
    def validate(self, input):
        stack = []
        for s in input:             
            if (s in [ '(', '[']):                
                stack.append(s)
                continue

            if not s in [')', ']']:
                continue
            
            if (len(stack) == 0):
                return False

            x = stack.pop()
            if x == '(' and s != ')':
                return False
            
            if x == '[' and s != ']':
                return False

        return len(stack) == 0

print(Solution().validate('(())'))

print(Solution().validate('[[]]'))

print(Solution().validate('([[]])'))

print(Solution().validate('([[]]'))

print(Solution().validate('[[ Hello World ]]'))

print(Solution().validate('[[ Hello World ])'))