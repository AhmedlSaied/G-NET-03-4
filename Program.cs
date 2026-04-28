// See https://aka.ms/new-console-template for more information
using System.Text;
using System.Diagnostics;
//Question 01 : A junior developer wrote this code to build a comma-separated list of 5,000 product IDs:
string Productlist = "";
var stopwatch = Stopwatch.StartNew();
for (int i = 1; i <= 1000; i++)
{
    Productlist += "PROD-" + i + ",";
}
stopwatch.Stop();
Console.WriteLine($"Time taken for string concatenation: {stopwatch.ElapsedMilliseconds} ms");
//(a)Explain why this code is inefficient.Reference what happens in memory.
/*
This loop creates 1,000 temporary objects. Only the last one is used,
while the other 999 become "garbage" that forces the Garbage Collector to work harder, 
slowing down the application.
*/
//Tasks:
//(b) Rewrite this code using StringBuilder to be more efficient.
StringBuilder sb = new();
var sw2 = Stopwatch.StartNew();
for (int x = 1; x <= 1000; x++)
{
    sb.Append("PROD-").Append(x).Append(",");
}
string final = sb.ToString();
//(c) Add timing code (using Stopwatch) to both versions and report the time difference.
sw2.Stop();
Console.WriteLine($"Time taken for string concatenation: {sw2.ElapsedMilliseconds} ms");


