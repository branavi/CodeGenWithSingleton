using System;

namespace SingletonTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Program c1 = Program.Instance;
            Console.WriteLine(c1.display("God"));
            Console.WriteLine(c1.display("Brana"));
        }
        private static Program singletontestobj = null;
        private Program() { }
        public static Program Instance
        {
            get
            {
                if (singletontestobj == null)
                {
                    singletontestobj = new Program();
                }
                return singletontestobj;
            }
        }

        public String display(string name)
        {

            return name;
        }
    }
}
    

