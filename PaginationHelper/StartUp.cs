using System;
using System.Collections.Generic;

namespace _02.PaginationHelper
{
    public class StartUp
    {
        public static void Main()
        {
            

            var helper = new PagnationHelper<int>(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 }, 10);


           

            Console.WriteLine(helper.PageCount); //should == 2

            Console.WriteLine(helper.ItemCount); //should == 6

            Console.WriteLine(helper.PageItemCount(0)); //should == 4
            Console.WriteLine(helper.PageItemCount(1)); // last page - should == 2
            Console.WriteLine(helper.PageItemCount(2)); // should == -1 since the page is invalid

            // pageIndex takes an item index and returns the page that it belongs on
            Console.WriteLine(helper.PageIndex(5)); //should == 1 (zero based index)
            Console.WriteLine(helper.PageIndex(2));// should == 0
             Console.WriteLine(helper.PageIndex(20));//should == -1
             Console.WriteLine(helper.PageIndex(-10)); //should == -1
        }
    }
}
