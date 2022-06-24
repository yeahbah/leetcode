# for bigger arrays, the array can be halve and halve until you find that perfect spot 
# to find the lo and hi index
class Solution:
    def getRange(self, arr, target):

        result = self.getHiLo(arr, target)

        return result

    def getHiLo(self, arr, target):
        halfLength = len(arr) // 2
        midIndex = halfLength - 1
        midValue = arr[midIndex]
        result = -1, -1
        if target == midValue:
            # target could be either more at the left or right

            # find low
            i = midIndex
            lo = i
            hi = i
            while(i >= 0):
                if arr[i] < target:
                    break

                if arr[i] == target:
                    lo = i
                
                i -= 1
            
            # find hi
            for t in range(midIndex, len(arr)):
                if arr[t] > target:
                    break

                if arr[t] == target:
                    hi = t    

            result = lo, hi        
            

        if target < midValue:
            # target is at the left
            result = self.getRangeHelper(arr[0:midIndex], target, midIndex)            
        
        if target > midValue:
            # target is at the right
            result = self.getRangeHelper(arr[midIndex::], target, midIndex)

        return result
    
    def getRangeHelper(self, arr, target, startIndex):
        lo = -1
        hi = -1
        i = startIndex
        for t in arr:
            if t > target:
                break

            if t == target and lo == -1:
                lo = i
                
            if t == target:
                hi = i
                
            i += 1

        return lo, hi

arr = [1, 2, 2, 2, 2, 3, 4, 7, 8, 9]
x = 2
print(Solution().getRange(arr, x)) # expected: 1, 4

arr = [1,3,3,5,7,8,9,9,9,15]
x = 9
print(Solution().getRange(arr, x)) # expected 6, 8

arr = [100, 150, 150, 153]
x = 150
print(Solution().getRange(arr, x)) # expected 1, 2
