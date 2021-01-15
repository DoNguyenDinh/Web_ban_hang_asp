using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerces_asp.net.Areas.Admin.Models
{
    public class PaginateList<T> :List<T>
    {
        public int PageIndex { get; set; }
        public int TotalPageP { get; set; }
        public PaginateList(List<T> items,int count,int pageIndex,int pagesize)
        {
            PageIndex = pageIndex;
            TotalPageP = (int)Math.Ceiling(count / (double)pagesize);
            this.AddRange(items);


        }
        public bool PreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }
        public bool NextPage
        {
            get
            {
                return (PageIndex < TotalPageP);
            }
        }
        public static async Task<PaginateList<T>>CreateAsync(IQueryable<T>source,int pageIndex,int pagesize)
        {
            var count = await source.CountAsync();
            var items = await source.Skip((pageIndex - 1) * pagesize).Take(pagesize).ToListAsync();
            return new PaginateList<T>(items, count, pageIndex, pagesize);

        }
    }
}
