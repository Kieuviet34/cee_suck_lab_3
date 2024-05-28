using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cee_suck_lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ar = new int[n];
            for (int i = 0; i < n; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            //them phan tu vao vtri bki
            Console.WriteLine("nhap phan tu can them: ");
            int new_el = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vi tri can them: ");
            int new_pos = int.Parse(Console.ReadLine());

            if(new_pos >= 0 && new_pos <= ar.Length)
            {
                List<int> ls = ar.ToList();
                ls.Insert(new_pos, new_el);
                ar = ls.ToArray();
            }
            //xoa phan tu vtri bki
            Console.WriteLine("Nhap vi tri can xoa: ");
            int del_pos = int.Parse(Console.ReadLine());
            if(del_pos >= 0 && del_pos <= ar.Length)
            {
                List<int> list = ar.ToList();
                list.RemoveAt(del_pos);
                ar = list.ToArray();
            }
            else
            {
                Console.WriteLine("Vi tri khong hop le");
            }
            //tim phan tu giong nhau 
            var group_el = ar.GroupBy(x => x).Select(g => new
            {
                Value = g.Key,
                Count = g.Count()
            });
            foreach(var item in group_el)
            {
                Console.WriteLine($"Gia tri {item.Value} xuat hien {item.Count} lan");
            }
            //

            //chia mang chan - le
            int[] even = ar.Where(x => x % 2 == 0).ToArray();
            int[] odd = ar.Where(x => x % 2 != 0).ToArray();
            Console.WriteLine("mang chan: " + string.Join(",", even));
            Console.WriteLine("mang le: " + string.Join(",", odd));
            //in ra phan tu duy nhat trong mang 
            int[] unique = ar.Distinct().ToArray();
            Console.WriteLine("phan tu duy nhat: "+ string.Join(",", unique));
            Console.ReadLine();                                                     
        }
    }
}
