public class BinaryTreea
{
    public Node Root { get; set; }

    // TODO :Add Node

    public Node Remove(int data)
    {
        if (Root == null)
            return null;
        var parentNode = Root;
        var currentNode = Root;
        while(currentNode != null && currentNode.Data != data)
        {
            parentNode = currentNode;
            if (currentNode.Data > data)
                currentNode = currentNode.LeftNode;
            else
                currentNode = currentNode.RightNode;
        }

        if (currentNode == null)
            return null;
        // Leaf Node
        if(currentNode.LeftNode ==null && currentNode.RightNode==null)
        {
            if (currentNode == parentNode.LeftNode)
                parentNode.LeftNode = null;
            else
                parentNode.RightNode = null;

        }
        //Parent with Right Child
        else if (currentNode.LeftNode == null)
        {
            if (currentNode == parentNode.LeftNode)
                parentNode.LeftNode = currentNode.RightNode;
            else
                parentNode.RightNode = currentNode.RightNode;
        }
        //Parent with Left Child
        else if (currentNode.RightNode == null)
        {
            if (currentNode == parentNode.LeftNode)
                parentNode.LeftNode = currentNode.LeftNode;
            else
                parentNode.RightNode = currentNode.LeftNode;
        }
        //Parent with both children
        else
        {
            var nextChildNode = currentNode.RightNode;
            while (nextChildNode.LeftNode != null)
            {
                nextChildNode = nextChildNode.LeftNode;
            }
            if ()
        }
        return currentNode;

    }


    public void Add(Node node)
    {
        if (Root == null)
        {
            Root = node;
            return;
        }
        var parentNode = Root;
        var currentNode = Root;
        while (currentNode !=null)
        {
            parentNode = currentNode;
            if (currentNode.Data > node.Data)
            {
                if(currentNode.LeftNode == null)
                {
                    parentNode.LeftNode = node;
                    return;
                }
                currentNode = currentNode.LeftNode;
            }
            else
            {
                if (currentNode.RightNode == null)
                {
                    parentNode.RightNode = node;
                    return;
                }
                currentNode = currentNode.RightNode;
            }
                
        }
            
    }
}


