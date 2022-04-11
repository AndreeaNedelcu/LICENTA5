using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LICENTA5.Models
{
    public class PaginatedList<Reservation> : List<Reservation>
    {
       
        public int PageIndex { get; private set; }
        public int TotalPages { get; private set; }

        public PaginatedList(List<Reservation> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            this.AddRange(items);
        }

        public bool HasPreviousPage => PageIndex > 1;

        public bool HasNextPage => PageIndex < TotalPages;

        public static async Task<PaginatedList<Reservation>> CreateAsync(IQueryable<Reservation> source, int pageIndex, int pageSize)
        {
            var count = await source.CountAsync();
            var items = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
            return new PaginatedList<Reservation>(items, count, pageIndex, pageSize);
        }

        //The CreateAsync method in this code takes page size and page number and applies the appropriate Skip and Take 
        //statements to the IQueryable. When ToListAsync is called on the IQueryable, it will return a List containing 
        //only the requested page. The properties HasPreviousPage and HasNextPage can be used to enable or disable 
        //Previous and Next paging buttons.

    }
}
