﻿using StudentManagerV6.Entities;

namespace StudentManagerV6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "An";
            Console.WriteLine(s1.Name);
        }

        static void PlayWithGetSet()
        {
            //biến là 1 vùng ram được đặt tên chứa giá trị nào đó
            //khi chơi với biến là ta chơi với vùng ram, chơi với giá trị thông qua tên biến
            //chơi với vùng ram/với biến ta làm được 2 điều sau
            //---READ VÙNG RAM, READ BIẾN COI NÓ CÓ VALUE GÌ???
            //---WRITE VÙNG RAM, THAY ĐỔI VALUE CỦA VÙNG RAM, CỦA BIẾN

            int x = 10; //vùng ram x mang giá trị 10 khởi đầu

            //HÃY IN RA GIÁ TRỊ CỦA BIẾN, CỦA VÙNG RAM, READ() GET()
            //SỜ CHẠM TÊN BIẾN LÀ SỜ CHẠM VALUE - GET()
            Console.WriteLine("x: " + x); //GetX() đc x

            //SỬA, ĐỔI VALUE, SET() SETTING()
            //TÊN BIẾN DẤU BẰNG CHÍNH LÀ SỬA, SET() VALUE
            x = 305;                                //Set()
            Console.WriteLine("x again: " + x);     //Get()
        }
    }
}
