

string[] myArray = new string[3] { "Hi", "world", ":)" };
Console.Write("[" + string.Join(",", myArray) + "]");
Console.Write(" -> ");
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i].Length <= 3)
    {    
         Console.Write($"[{myArray[i]}] ");
    }

}







