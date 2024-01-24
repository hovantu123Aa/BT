using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT
{
    class node
    {
        private int info;
        public node next;
        public node(int x)
        {
            info = x;
            next = null;
        }
        public int Info
        {
            set { this.info = value; }
            get { return info; }
        }
        public node Next
        {
            set { this.next = value; }
            get { return next; }
        }
    }
    class Singleinklist
    {
        private node Head;
        public Singleinklist()
        {
            Head = null;
        }
        //them vao dau
        public void addhead(int x)
        {
            node p = new node(x);
            p.next = Head;
            Head = p;
        }
        //them vào  cuoi
        public void addlast(int x)
        {
            node q = new node(x);
            if (Head == null)
            {
                Head = q;
            }
            else
            {
                node p = Head;
                while (q.next != null)
                {
                    q = q.next;
                }
                q.next = p;
            }
        }
        //xoa dau
        public void Deletehead()
        {
            if (Head != null)
            {
                node p = Head;
                Head = Head.next;
                p.next = null;
            }
        }
        //xoa cuoi
        public void Deletelast()
        {
            if (Head != null)
            {
                node p = Head;
                node q = null;
                while (p.next != null)
                {
                    q = p;
                    p = p.next;
                }
                q.next = null;
            }
        }
        // xoa bat ki vi tri nào
        public void Deletenode(float x)
        {
            node p = Head;
            node q = null;
            while (p != null && p.Info != x)
            {
                q = p;
                p = p.next;
            }
            if (p != null)
            {
                q.next = p.next;
                p.next = null;
            }
        }
        //tim max
        public node findmax()
        {
            node max = Head;
            node p = Head.next;
            while (p != null)
            {
                if (p.Info> max.Info)
                {
                    max = p;

                }
                p = p.next;
            }
            return max;
        }
        //tinh chung binh 
        public float avg()
        {
            float sum = 0;
            int count = 0;
            node p = Head;
            while (p != null)
            {
                sum += p.Info;
                count++;
                p = p.next;
            }
            return sum / count;
        }
        // xuat ra mang hinh
        public void processlist()
        {
            node p = Head;
            while (p != null)
            {
                Console.Write($"{ p.Info} ");
                p = p.next;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Singleinklist l = new Singleinklist();
            NhapDanhSach(l);
            Console.Write("danh  lien ket duoc tao :");
            l.processlist();
            node max = l.findmax();
            Console.WriteLine($"\nnut co gia tri lon nhat:{max.Info}");
            Console.Write($"\ntong trung binh cua nut la:{l.avg()}");
            Console.WriteLine("\nnhap gia tri muon xoa :");
            float x = float.Parse(Console.ReadLine());
            l.Deletenode(x);
            Console.WriteLine("\ndanh sach sao khi xoa:");
            l.processlist();
            Console.ReadLine();
        }
        static void NhapDanhSach(Singleinklist l)
        {
            string chon = "y";
            int x;
            while (true)
            {
                Console.Write("nhap gia tri nut:");
                x = int.Parse(Console.ReadLine());
                l.addhead(x);
                Console.Write("tiep tuc(Y/n)?:");
                chon = Console.ReadLine();
                if (chon == "n")
                    break;

            }
        }
    }
}
