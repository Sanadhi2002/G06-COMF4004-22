using Microsoft.EntityFrameworkCore;

namespace Project_G06.Models
{
    public class PaginatedList
    {
        public int PageIndex { get; private set; }

        public int TotalPages { get; set; }

        public int TotalItems { get; set; }

        public int CurrentPage { get; private set; }

        public int PageSize { get; private set; }

        public int StartPage { get; private set; }
        public int EndPage { get; private set; }

        /*

        public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
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
                return (PageIndex < TotalPages);
            }
        }

        public  static async Task<PaginatedList<T>> CreateAsync (IQueryable<T> source , int pageIndex , int pageSize)
        {
            var count = await source.CountAsync();
            var items = await source.Skip(pageIndex - 1 * pageSize).Take(pageSize).ToListAsync();
            return new PaginatedList<T>(items , count , pageIndex , pageSize);  
        }
        */
        public PaginatedList()
        {

        }

        public PaginatedList(int totalItems, int page, int pageSize = 10)
        {
            int totalPages = (int)Math.Ceiling((decimal)totalItems / (decimal)pageSize);
            int currentPage = page;

            int startPage = currentPage - 5;
            int endPage = currentPage + 4;


            if (startPage <= 0)
            {
                endPage = endPage - (startPage - 1);
                startPage = 1;
            }


            if (endPage > totalPages)
            {
                endPage = totalPages;
                if (endPage > 10)
                {
                    startPage = endPage - 9;
                }
            }


            TotalItems= totalItems;
            CurrentPage = currentPage;
            PageSize = pageSize;
            TotalPages = totalPages;
            StartPage = startPage;
            EndPage = endPage;




            
        }


    }
}



        
    








