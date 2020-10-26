# CodingRiddles
## Coding questions by Stan Khaykin
### EZ-15: Print a triangle based on user's input. Example:
```C#
Enter size of base: 5

  *
 ***
*****

Enter size of base: 7

   *
  ***
 *****
*******

Enter size of base: 1
Too small!

Enter size of base: 11
Too large!

Enter size of base: 2
Must be an odd number!

Enter size of base: 3

 *
***
```
Valid base sizes are odd numbers 3 - 9
### EZ-14: Please make a function that works similar to int.Parse:
```C#
string userInput = "42";
int number = int.Parse(userInput);  // number is 42

The function takes in a string, and returns a int:
int ParseInt(string input)
{
  // your code
}
```
HINT: remember, string is can be treated as an array of characters - and you can figure out if each character is a number by checking if it's between '0' and '9'. Once you know it's a number, the easiest way to convert that to an integer is to subtract the value '0' (BONUS if you can figure out why that works!). Here's an example:
```C#
if(character >= '0' && character <= '9')
{
  // This is a digit - let's see which one!
  int digit = character - '0';
}
```
Of course, you still need to figure out what to do with all those digits...
### DS-10: I have a sorted array of integers, like 1, 42, 54, 72, 99, 101; I'd like a function that produces a binary tree (like a BST) from this list. However, it's very important that the tree remains as close to balanced as possible; but I don't want to use AVL or Red/Black trees, due to extra costs of insertion. In fact, here's the structure I want to place my result in:
```C#
class SimpleTree
{
   public int Value { get; set; } 
   public SimpleTree Left { get; set; } 
   public SimpleTree Right { get; set; }
} 

So, the function I want takes in an array and returns a tree:
SimpleTree MakeTree(int[] numbers)
{
   // your code here
}
```
Note, I want it balanced and useful - I want to be able to find any value in the resulting BST in O(log(n)) time complexity, on average. Give it a shot!
### DS-14: Can you write a function to reverse a Linked List? This is the list definition:
```C#
class Node<T>
{
  public T Value { get; set; }
  public Node<T> Next { get; set; }
}

Please note, the code for the Linked List cannot be modified in any way (meaning, you can't add properties to the Node<T> class, for instance). Please make sure your solution is efficient, both in terms of time complexity and space complexity. Please write the ReverseLinkedList function:
void ReverseLinkedList<T>(ref Node<T> list)
{
  // your code
}
```
You can safely presume there are no cycles in the input list - that is, it's a singly-linked list, with last node's Next property being null Thanks to @Peter Husman for clarifying this important detail!
### DS-15: Write a function to check if a Binary Tree  is symmetric. Imagine drawing a Binary Tree (or using a visualizer) - looking from the root node at the left and right subtrees, you can probably tell if they are a mirror image of each other (not by values, but by layout of the nodes). Can you write a function that returns true for a tree that's symmetric, and false otherwise? Here's the definition of the tree to use:
```C#
class Node<T>
{
   public T Value { get; set; } 
   public Node<T> Left { get; set; }
   public Node<T> Right { get; set; } 
}
```
Function to write:
```C#
bool IsSymmetric<T>(Node<T> tree)
{
   // your code... 🤔 
} 
```
### DS-17: Morse Code  Message Translator: 
Consider a program that can translate a message from English to Morse Code, and from Morse Code back to English? Example:

Menu:
1. English -> Morse Code
2. Morse Code -> English

Enter choice: 1
Enter message: HELLO
Morse code: .... . .-.. .-.. ---

Menu:
1. English -> Morse Code
2. Morse Code -> English

Enter choice: 2
Enter message: .... ..
English: HI


In the first example, user enters the word "HELLO", and the program responds with Morse code (note: use a space between each Morse code letter, and 3 spaces between words!) . In the second example, user enters a Morse code message ".... ..", and the program responds with the English word "HI". 

Can you make a MorseCodeTranslator class that can be used in such program efficiently? My strong preference for this is O(1) look up times, and as few conditional checks as possible.
