using System;
public struct books
{
    public string title;
    public float price;
    public int book_id;
    public enum booktype{
        Magazine=1,
        Novel=2,
        Referencebook=3,
        Miscellaneous=4
    }
    public int Accept()
    {
        int num;
        Console.WriteLine("Enter the details of book\n");
        Console.WriteLine("Enter the title of book:");
        title= Console.ReadLine();
        Console.WriteLine("Enter the price  of the book:");
        price=float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the ID of the book:");
        book_id=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the type of book:");
        Console.WriteLine("1. for Magazine\n");
        Console.WriteLine("2. for Novel\n");
        Console.WriteLine("3. for ReferenceBook\n");
        Console.WriteLine("4. for Miscellaneous\n");
        num =int.Parse(Console.ReadLine());
        return num;
    }
    public void display(int num)
    {
        int Num=num;
        Console.WriteLine("\n Title : {0}",title);
         Console.WriteLine("\n Price : {0}",price);
         Console.WriteLine("Book_id :{0}",book_id);
         switch(Num)
         {
             case 1:
             Console.WriteLine("Type of book :{0}",booktype.Magazine);
             break;
             case 2:
             Console.WriteLine("Type of book :{0}",booktype.Novel);
             break;
             case 3:
             Console.WriteLine("Type of book :{0}",booktype.Referencebook);
             break;
             case 4:
             Console.WriteLine("Type of book :{0}",booktype.Miscellaneous);
             break;
             default:
             Console.WriteLine("Couldn't found");
             break;
         }
    }
}
class Library{
    public static void Main(string[] args)
    {
        books bk=new books();
        int mn=bk.Accept();
        bk.display(mn);
    }
}
