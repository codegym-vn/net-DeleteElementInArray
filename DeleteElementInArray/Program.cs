using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, index_del, lenght; //index_del la vi tri can xoa
            int[] myArray = new int[50];
            Console.Write("\nXoa phan tu trong mang C#:\n");
            Console.Write("---------------------------\n");
            Console.Write("Nhap kich co mang: ");
            lenght = Convert.ToInt32(Console.ReadLine());
            /* nhap cac phan tu vao trong mang*/
            Console.Write("Nhap {0} phan tu vao mang:\n", lenght);
            for (int index = 0; index < lenght; index++)
            {
                Console.Write("Phan tu - {0}: ", index);
                myArray[index] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\nNhap vi tri can xoa: ");
            index_del = Convert.ToInt32(Console.ReadLine());
            if (index_del> lenght)
            {
                Console.Write("\nVi tri can xoa vuot qua kich thuoc cua mang hien tai ");
            }
            else
            {
                /* xac dinh vi tri cua i trong mang*/
                i = 0;
                while (i != index_del - 1)
                    i++;
                /*vi tri i trong mang se duoc thay the boi gia tri ben phai cua no */
                while (i < lenght)
                {
                    myArray[i] = myArray[i + 1];
                    i++;
                }
                lenght--;
                Console.Write("\nIn mang sau khi da xoa phan tu: ");
                for (int index = 0; index < lenght; index++)
                {
                    Console.Write("  {0}", myArray[index]);
                }
                Console.Write("\n\n");
            }
            Console.ReadKey();
        }
    }
}
