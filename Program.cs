// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;
#region Question 01
//Question 01 :
//A junior developer wrote this code to build a comma-separated list of 5,000 product IDs:
//string Productlist = "";
//var stopwatch = Stopwatch.StartNew();
//for (int i = 1; i <= 1000; i++)
//{
//    Productlist += "PROD-" + i + ",";
//}
//stopwatch.Stop();
//Console.WriteLine($"Time taken for string concatenation: {stopwatch.ElapsedMilliseconds} ms");
////(a)Explain why this code is inefficient.Reference what happens in memory.
//This loop creates 1,000 temporary objects. Only the last one is used,
//while the other 999 become "garbage" that forces the Garbage Collector to work harder, 
//slowing down the application.
////Tasks:
////(b) Rewrite this code using StringBuilder to be more efficient.
//StringBuilder sb = new();
//var sw2 = Stopwatch.StartNew();
//for (int x = 1; x <= 1000; x++)
//{
//    sb.Append("PROD-").Append(x).Append(",");
//}
//string final = sb.ToString();
////(c) Add timing code (using Stopwatch) to both versions and report the time difference.
//sw2.Stop();
//Console.WriteLine($"Time taken for string concatenation: {sw2.ElapsedMilliseconds} ms");
#endregion
#region Question 02
//Question 02: Ticket Pricing System 
//Write a program for a cinema ticket pricing system with these rules:
//Condition
//Price
//Age < 5 
//Free
//Age 5 - 12
//30 LE
//Age 13 - 59
//50 LE
//Age 60+
//25 LE
//Weekend (Fri/Sat)
//Add 10 EGP to any non-free ticket
//Student with valid ID
//20% discount (applied after weekend surcharge)

////Tasks:

////(a)Implement using if-else if-else statements
//Console.WriteLine("=== Cinema Ticket Pricing System ===");
////(b) The program should ask for: age, day of week (1-7, where 6 = Fri, 7=Sat),
////and whether they have a student ID (yes/no)

//Console.Write("Enter Age: ");
//int age = int.Parse(Console.ReadLine());

//Console.Write("Enter Day of Week (1-7, where 6=Fri, 7=Sat): ");
//int day = int.Parse(Console.ReadLine());

//Console.Write("Do you have a valid Student ID? (yes/no): ");
//string studentInput = Console.ReadLine().ToLower();
//bool isStudent = studentInput == "yes" || studentInput == "y";

//double finalPrice = 0;
//string breakdown = "";

//if (age < 5)
//{
//    finalPrice = 0;
//    breakdown = "Age < 5: Free";
//}
//else if (age <= 12)
//{
//    finalPrice = 30;
//    breakdown = "Base Price (Child 5-12): 30 LE";
//}
//else if (age <= 59)
//{
//    finalPrice = 50;
//    breakdown = "Base Price (Adult 13-59): 50 LE";
//}
//else
//{
//    finalPrice = 25;
//    breakdown = "Base Price (Senior 60+): 25 LE";
//}

//if (finalPrice > 0)
//{
//    if (day == 6 || day == 7)
//    {
//        finalPrice += 10;
//        breakdown += "\nWeekend Surcharge: +10 LE";
//    }

//    if (isStudent)
//    {
//        double discount = finalPrice * 0.20;
//        finalPrice -= discount;
//        breakdown += $"\nStudent Discount (20%): -{discount} LE";
//    }
//}

////(c) Display the final price with a breakdown of how it was calculated
//Console.WriteLine("\n--- Receipt ---");
//Console.WriteLine(breakdown);
//Console.WriteLine($"Total Final Price: {finalPrice} LE");
//Console.WriteLine("----------------");



#endregion
#region Question 03
//Convert the following if-else chain to:
//(a)A traditional switch statement
//(b) A switch expression 

string fileExtension = "pdf";
string fileType;

switch (fileExtension.ToLower())
{
    case ".pdf":
        fileType = "PDF Document";
        break;
    case ".docx":
    case ".doc":
        fileType = "Word Document";
        break;
    case ".xlsx":
    case ".xls":
        fileType = "Excel Spreadsheet";
        break;
    case ".jpg":
    case ".png":
    case ".gif":
        fileType = "Image File";
        break;
    default:
        fileType = "Unknown File Type";
        break;
}
#endregion

