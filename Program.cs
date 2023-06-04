
string[] array = new string[] {"Hello", "2", "world", ":-)"};
string[] array2 = new string[] {};

for (int i = 0; i < array.Length; i++)
{   
    if(array[i].Length <=3)
    {
    Array.Resize(ref array2, array2.Length + 1 );
    array2[array2.Length - 1] = array[i];
    }
}

System.Console.WriteLine('['+ String.Join(',', array) + ']');
System.Console.WriteLine('['+ String.Join(',', array2) + ']');