using System;
using System.Collections;


//take user input

Console.WriteLine("Please enter word to reverse...");
Console.WriteLine();
string response = Console.ReadLine();
Console.WriteLine();

Console.WriteLine(pushStack());
//Console.WriteLine(pushStack());


//Console.WriteLine(reverseWord(response));


//Console.WriteLine(pushStack(response));





/*//Creates stack and calls method printValues
Stack mystack = new Stack();
mystack.Push(response);
mystack.Push("response + response");
printValues(mystack);
*/




/*static string pushStack()
{
    string meme = "yogibear";
    foreach (char c in meme)
    {
        Console.WriteLine(c.ToString());
        Stack myStack = new Stack();
        myStack.Push(c);
        foreach  (var i in myStack)
        {
            Console.WriteLine(c);
        }
    }
    return "";
}
 
*/


static string pushStack()
{
    Stack stack = new Stack();
    stack.Push(150);
    stack.Push(300);
    stack.Push(500);
    stack.Push(750);
    stack.Push(1000);
    stack.Push(1250);
    stack.Push(1500);
    stack.Push(2000);
    stack.Push(2500);
    Console.WriteLine("Stack elements...");

    foreach (int val in stack)
    {
        Console.WriteLine(val);
    }

    return "hi";
}




















/*//reverese word order in string?
static string reverseSent(string sentence)
{
    string output = string.Empty;
    string[] splitStrings = sentence.Split(" ");
    for (int i = splitStrings.Length -1; i > -1; i--)
    {
        output = output + splitStrings[i] + " ";
    }
    return output;
} 


//reverse letters in array
static string reverseWord(string word)
{
    char[] output1 = word.ToCharArray();
    Array.Reverse(output1);
    return new string(output1);
    Stack mystack = new Stack();
    mystack.Push("hi my name");
    mystack.Push("response + response");


}



//for each item in stack prints object 0???
static void printValues(IEnumerable myCollection)
{
    foreach(Object obj in myCollection)
    Console.WriteLine("{0}", obj);
    Console.WriteLine();
}

*/







//inside method reverse string using stack






//display to console