using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*
     * interface class, all its methode must be overrided,
     * can only have a static method with body or a methode without body
     * can only have a static variables. 
     * i can not inheart from 
     */
        public abstract class Vechile // can not have object, can be in the left handside
        {
            public int id;
        }
    public interface Iloader
    {
        public static int age = 0;
        public static int count()
        {
            return age++;
        }
        void Load();
        void Unload();

    }
    public class BMW : Vechile, Iloader // concreate class  ctrl+.
    {
        public BMW() 
        {
            Iloader.age++;
        }
        public void Load()
        {
        }

        public void Unload()
        {
        }
    }
    interface a1
    {
        public void move()
        {
            Console.WriteLine("A1");
        }
    }
    interface a2
    {
       public void move()
        {
            Console.WriteLine("A2");
        }
    }
    class a : a1 ,a2
    {
        public void move()
        {
            Console.WriteLine("a");

        }

        
    }

}
