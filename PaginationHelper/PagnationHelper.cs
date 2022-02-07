using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.PaginationHelper
{
    public class PagnationHelper<T>
    {
        // TODO: Complete this class

        /// <summary>
        /// Constructor, takes in a list of items and the number of items that fit within a single page
        /// </summary>
        /// <param name="collection">A list of items</param>
        /// <param name="itemsPerPage">The number of items that fit within a single page</param>
        public PagnationHelper(List<T> collection, int itemsPerPage)
        {
            this.collection = collection;
            this.itemsPerPage = itemsPerPage;
        }




        private IList<T> collection = new List<T>();
        private int itemsPerPage;

        /// The number of items within the collection
        /// </summary>
        public int ItemCount
        {
            get
            {
                return this.collection.Count();
            }
        }

        /// <summary>
        /// The number of pages
        /// </summary>
        public int PageCount 
        {
            get
            {
                if (this.ItemCount % this.itemsPerPage == 0)
                {
                    return this.ItemCount / this.itemsPerPage;
                }
                else
                {
                    return (int)Math.Floor((double)(this.ItemCount + (this.itemsPerPage - 1)) / this.itemsPerPage);
                }
               
            }
        }

        /// <summary>
        /// Returns the number of items in the page at the given page index 
        /// </summary>
        /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
        /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
        public int PageItemCount(int pageIndex)
        {
            // a, b, c, d, e, f, y, u, o
            //pages = 2
            // items = 6

            //itemsPerPage = 4
            var resultOfItemsOfPage = -1;

            if (pageIndex >= this.PageCount || pageIndex < 0)
            {
                return resultOfItemsOfPage;
            }
            else if (pageIndex == 0 && this.PageCount > 1 || pageIndex < this.PageCount - 1)
            {
                return this.itemsPerPage;
            }
            else if (pageIndex == this.PageCount - 1)
            {
                resultOfItemsOfPage = this.ItemCount - (this.PageCount - 1) * this.itemsPerPage;
            }

            return resultOfItemsOfPage;


        }

        /// <summary>
        /// Returns the page index of the page containing the item at the given item index.
        /// </summary>
        /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
        /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
        public int PageIndex(int itemIndex)
        {
            var pageNum = -1;
            if (itemIndex >= this.collection.Count || itemIndex < 0)
            {
                return pageNum;
            }
            else
            {
                pageNum = (int)Math.Floor((decimal)itemIndex / this.itemsPerPage);
            }

            return pageNum;
        }
    }
}

