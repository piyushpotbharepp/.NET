/*
================================================
                Access Modifiers 
================================================
            Protected Access Modifier
------------------------------------------------
 >> It is accessible within the class and has limited scope
 >> It is also accessible within subclass or child class in case of inheritance
 .................................................
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Shop_Details1
    {
        String Shop_Name;
        String Shop_Description;
        int Shop_Keeper_Count;
        int Shop_Workers_Count;
        protected void GetShop_Details1(string Shop_Name, string Shop_Description, int Shop_Keeper_Count, int Shop_Workers_Count)
        {
            this.Shop_Name = Shop_Name;
            this.Shop_Description = Shop_Description;
            this.Shop_Keeper_Count = Shop_Keeper_Count;
            this.Shop_Workers_Count = Shop_Workers_Count;
        }
        protected void DisplayShop_Details1()
        {
            Console.WriteLine("Shop Name : " + Shop_Name);
            Console.WriteLine("Shop Description : " + Shop_Description);
            Console.WriteLine("Shop Keeper Count : " + Shop_Keeper_Count);
            Console.WriteLine("Shop Workers Count : " + Shop_Workers_Count);
        }
    }
    public class Shop_Details2 : Shop_Details1
    {
        string Shop_Type;
        string Shop_LBT_Number;
        public void GetShop_Details2(string Shop_Type, String Shop_LBT_Number)
        {
            GetShop_Details1("Pallavi Pustakalaya", "Book Store", 2, 3);
            this.Shop_Type = Shop_Type;
            this.Shop_LBT_Number = Shop_LBT_Number;
        }
        public void DisplayShop_Details2()
        {
            DisplayShop_Details1();
            Console.WriteLine("Shop Type : " + Shop_Type);
            Console.WriteLine("Shop LBT Number : " + Shop_LBT_Number);
        }
    }
    class Inheritance
    {
        public static void Main()
        {
            Shop_Details2 Shop_Info = new Shop_Details2();

            
            Shop_Info.GetShop_Details2("Stationary & General Store", "gg656yfuyyu5");
            Shop_Info.DisplayShop_Details2();

            Console.ReadLine();
        }
    }
}