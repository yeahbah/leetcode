namespace Trees;

public class Node
{
    public Node(int value)
    {
        Value = value;
    }
    
    public Node? Left { get; set; }
    public Node? Right { get; set; }
    
    public int Value { get; set; }

    public static Node? Insert(int value, Node node)
    {
        if (value < node.Value)
        {
            if (node.Left != null)
                return Insert(value, node.Left);

            node.Left = new Node(value);
            return node.Left;
        }
        
        if (value > node.Value)
        {
            if (node.Right != null)
                return Insert(value, node.Right);
            
            node.Right = new Node(value);
            return node.Right;
        }

        return null;
    }

    public static void Traverse(Node? node, Action<Node>? action = null)
    {
        if (node == null) return;
        
        Traverse(node.Left, action);
        
        action?.Invoke(node);
        
        Traverse(node.Right, action);
        
    }

    public static bool ValidateTree(Node? node, int low, int high)
    {
        if (node == null) return true;

        if ((node.Value > low && node.Value < high)
            && ValidateTree(node.Left, low, node.Value)
            && ValidateTree(node.Right, node.Value, high))
            return true;

        return false;
    }
    
}