using Structure_Class_July140824;

namespace Structure_Class_July140824
{
    class cc1
    {
        int i;
        float f;
    }
    struct  cc2
    {
        int i;
        float f;
    }

    public class class1
    {
        public int i;
        public void show()//method
        {
            Console.WriteLine("show from structure project class1");
        }
       
    }
    struct myStructure
    { 
        public int i;
        public void display()
        {
            Console.WriteLine("display from structure st");
        }
        public myStructure()
        {
            Console.WriteLine("constructor of myStructure is called.....");
        }

    }
   

    internal class Program
    {

        static void Main(string[] args)
        {
            //myStructure s1;//tech 1
            Int32 x=9;//x==>0
                      //      // s1.i = 100;//i==100
                      //s1.i = 100;
                      //x= s1.i;//x==>100

            //Console.WriteLine("s1.i="+s1.i);
            //Console.WriteLine("x="+x);

            //myStructure s2 = new myStructure();//tech 2

            //x = s2.i;


            //s1.display();
            //s2.display();


            //myStructure ms1;//1 variable
            //Console.WriteLine("------------------------");
            //myStructure ms2 = new myStructure() ;//2 variable

            unsafe
            {
                Console.WriteLine("size of class cc1=" + sizeof(cc1));
                Console.WriteLine("size of struct cc2=" + sizeof(cc2));
            }
            

            Console.ReadKey();
        }
    }
}
