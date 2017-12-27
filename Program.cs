using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Classes;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10, 5);
            Square sq = new Square(5);
            Circle sc = new Circle(5);
            Console.WriteLine("\nArraylist");
            ArrayList list = new ArrayList();
            list.Add(rect);
            list.Add(sq);
            list.Add(sc);
            foreach (var x in list) Console.WriteLine(x);
            Console.WriteLine("\nList Figure");
            List<Figure> lst = new List<Figure>();
            lst.Add(rect);
            lst.Add(sq);
            lst.Add(sc);
            foreach (var i in lst) Console.WriteLine(i);
            Console.WriteLine("\nList<Figure> sort");
            lst.Sort();
            foreach (var i in lst) Console.WriteLine(i);
            Console.WriteLine("\nMatrix3D");
            Matrix3D<Figure> matr = new Matrix3D<Figure>(3,3,3,null);
            matr[0, 0, 0] = sq;
            matr[1, 1, 1] = sc;
            matr[2, 2, 2] = rect;
            Console.WriteLine(matr[1, 1, 1].ToString());
            Console.WriteLine(matr.ToString());
            Console.WriteLine("\nSimple List");
            SimpleList<Figure> list1 = new SimpleList<Figure>();
            list1.Add(sq);
            list1.Add(sc);
            list1.Add(rect);
            list1.Add(sq);
            list1.Add(sc);
            foreach (var x in list1) Console.WriteLine(x);
            list1.Sort();
            Console.WriteLine("\n Simple List sort");
            foreach (var x in list1) Console.WriteLine(x);
            Console.WriteLine("\nMy shit kek");
            //list1.DeleteLast();
            foreach (var x in list1) Console.WriteLine(x);
            Console.WriteLine("\nSimple Stack");// реализовать
            SimpleStack<Figure> stck = new SimpleStack<Figure>();
            stck.push(sq);
            stck.push(sc);
            stck.push(rect);
            foreach (var x in stck) Console.WriteLine(x);
            Console.WriteLine("\npop");
            stck.pop();
            stck.pop();
            stck.pop();
            Console.ReadKey();

        }
    }
}
