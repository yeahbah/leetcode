class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

class Solution:
    def addTwoNumbers(self, l1: ListNode, l2: ListNode) -> ListNode:
        result = ListNode()
        if l1 == None and l2 == None:
            return

        if l1 == None:
            l1 = ListNode()
        l1_value = l1.val
        
        if l2 == None:
            l2 = ListNode()
        l2_value = l2.val

        sum = l1_value + l2_value
        carry = 0
        if sum > 9:
            carry = 1
        
        if l1.next != None:
            l1.next.val = l1.next.val + carry
        elif l2.next != None:
            l2.next.val = l2.next.val + carry
        elif carry > 0:
            l1.next = ListNode(1)

        result.val = sum - (carry * 10)
        result.next = self.addTwoNumbers(l1.next, l2.next)

        return result        

def array_to_list_node(array, index):
    for i in range(index, len(array)):
        result = ListNode(array[index])
        result.next = array_to_list_node(array, i + 1)
        return result

def print_list_node(listNode):
    current_node = listNode
    while current_node != None:    
        print(current_node.val)
        current_node = current_node.next

# node1 = array_to_list_node([2, 4, 3], 0)    
# node2 = array_to_list_node([5, 6, 4], 0)

# node1 = array_to_list_node([9,9,9,9,9,9,9], 0)
# node2 = array_to_list_node([9,9,9,9], 0)

node1 = array_to_list_node([2,4,9], 0)
node2 = array_to_list_node([5,6,4,9], 0)

solution = Solution()
result = solution.addTwoNumbers(node1, node2)

print_list_node(result)