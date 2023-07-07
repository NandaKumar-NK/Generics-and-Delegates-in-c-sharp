using Generic_Deleigate;
using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    /*public static void swap<T>(ref T num1, ref T num2)
    {
        T temp;
        temp = num1;
        num1 = num2;
        num2 = temp;
    }*/


    public delegate int MyDelegate();

    //static void InvokeDelegate(MyDelegate del)
    //{
    //    del("Hello World");
    //}
    public static void Main(string[] args)
    {

        
        MyDelegate del1 =  Delegate1.Method1;
        MyDelegate del2 = Delegate2.Method1;

        Console.WriteLine(del1());
        Console.WriteLine(del2());

        MyDelegate del = del1 + del2;
        Console.WriteLine(del());  
        /* MyDelegate del = del1 + del2 -del1;
         Console.WriteLine("After del1+del2");
         del("hello");*/



        /*MyDelegate delobj1 = new MyDelegate(Delegate1.Method1);
        MyDelegate delobj2 = new MyDelegate(Delegate2.Method1);
        //delobj1.Invoke("hello");
        //delobj1 = Delegate2.Method1;
        //delobj1.Invoke("hi");

        InvokeDelegate(delobj1);
        InvokeDelegate(delobj2 );*/

        /*int n1 = 10, n2 = 20;
        char c1 = 'A', c2 = 'B';
        swap(ref n1, ref n2);
        swap(ref c1, ref c2);

        Console.WriteLine(c1 +" "+c2);
        Console.WriteLine(n1 + " " + n2);*/



        //static ArithmeticException arithmeticException;
        /*GenUse <ArithmeticException> ae = new GenUse<ArithmeticException>
            ( arithmeticException );
        Console.WriteLine(ae.disp().Message);*/
        /*GenUse<int> intarr = new GenUse<int>(5);
        for(int i = 0; i <5; i++)
        {
            intarr.setarr(i, (i+1) * 10);
        }

        for(int i = 0;i < 5; i++)
        {
            Console.WriteLine(intarr.getarr(i));
        }

        GenUse<char> chararr = new GenUse<char>(5);
        for (int i = 0; i < 5; i++)
        {
            chararr.setarr(i, Convert.ToChar(i+65));
        }

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(chararr.getarr(i));
        }*/

        /* GenUse<int> gu_int = new GenUse<int> (10);
         GenUse<double> gu_dou = new GenUse<double>(10.4548);
         GenUse<string> gu_str = new GenUse<string>("nanda");

         Console.WriteLine(gu_int.Number);
         Console.WriteLine(gu_dou.Number);
         Console.WriteLine(gu_str.Number);*/
    }
}
