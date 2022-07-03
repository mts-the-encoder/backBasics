var arr = new string[2];
arr[0] = "item 1";
var arr2 = arr;

Console.WriteLine(arr[0]);
Console.WriteLine(arr2[0]);

arr[0] = "add item";
Console.WriteLine(arr[0]);
Console.WriteLine(arr2[0]);