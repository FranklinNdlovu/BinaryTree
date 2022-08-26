
// FizzBuzz
// Loop through from 0 to 100
//for each number check if its a multiple of 3 and return Fizz if it
//if it's a multiple of 5 display Buzz
// if it's a multiple of both display FizzBuzz
// otherwise display the number

//for (int number = 0; number <= 100; number++)
//{
//    if (number % 3 == 0 && number % 5 == 0)
//        Console.WriteLine("fizzbuzz");
//    else if (number % 3 == 0)
//        console.writeline("fizz");
//    else if (number % 5 == 0)
//        console.writeline("buzz");
//    else
//        console.writeline(number);
//}

var binaryTree = new BinaryTreea();

binaryTree.Add(new Node(8));
binaryTree.Add(new Node(4));
binaryTree.Add(new Node(12));
binaryTree.Add(new Node(2));
binaryTree.Add(new Node(6));
binaryTree.Add(new Node(10));
binaryTree.Add(new Node(14));
binaryTree.Add(new Node(9));
var removedNode = binaryTree.Remove(8);
var notFound = "Node not found";
Console.WriteLine($"{(removedNode == null ? notFound : removedNode.Data)}");




