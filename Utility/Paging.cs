using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    //public class Paging
    //{
    //}
    
    ///==========================================
    /// <summary>
    /// Author: Gunnar Peipman
    /// https://gunnarpeipman.com/ef-core-paging/
    /// PagedResultBase – abstract base class for paged results, used in views and view components.
    /// </summary>
    public abstract class PagedResultBase
    {
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public int PageSize { get; set; }
        public int RowCount { get; set; }

        public int FirstRowOnPage
        {
            get
            {
                return (CurrentPage - 1) * PageSize + 1;
            }
        }

        public int LastRowOnPage
        {
            get
            {
                return Math.Min(CurrentPage * PageSize, RowCount);
            }
        }
    }

    /// <summary>
    /// Author: Gunnar Peipman
    /// https://gunnarpeipman.com/ef-core-paging/
    /// PagedResult<T> – strongly typed class for results and result set properties
    /// </summary>
    /// <typeparam name="T">As class</typeparam>
    public class PagedResult<T> : PagedResultBase where T : class
    {
        public IList<T> Results { get; set; }

        public PagedResult()
        {
            Results = new List<T>();
        }
    }
    ///==========================================


    public static class QueryExtensions
    {
        /// <summary>
        /// Author: Gunnar Peipman
        /// https://gunnarpeipman.com/ef-core-paging/
        /// This is the universal extension method for IQueryable<T> that returns one page of results and some numbers that describe the result set.
        /// </summary>
        public static PagedResult<T> GetPaged<T>(this IQueryable<T> query, int pageNumber, int pageSize) where T : class
        {
            var result = new PagedResult<T>();
            result.CurrentPage = pageNumber;
            result.PageSize = pageSize;
            result.RowCount = query.Count();

            var pageCount = (double)result.RowCount / pageSize;
            result.PageCount = (int)Math.Ceiling(pageCount);

            var skip = (pageNumber - 1) * pageSize;
            result.Results = query.Skip(skip).Take(pageSize).ToList();

            return result;
        }

        /// <summary>
        /// Author: Maarten
        /// https://stackoverflow.com/users/261050/maarten
        /// Paging problem.
        /// https://stackoverflow.com/questions/19766300/pagedlist-with-entity-framework-getting-all-records
        /// </summary>
        /// <typeparam name="T">As class.</typeparam>
        /// <param name="query">Query from your EF, list.</param>
        /// <param name="pageNumber">Page number.</param>
        /// <param name="pageSize">Page size.</param>
        /// <returns></returns>
        public static IQueryable<T> ToPagedQuery<T>(this IQueryable<T> query, int pageNumber, int pageSize)
        {
            return query.Skip(pageSize * (pageNumber - 1)).Take(pageSize);
        }

        public static IQueryable<T> ToPagedQuery<T>(this IQueryable<T> query, int pageNumber, int pageSize, out int pageCount, out int rowCount)
        {
            rowCount = query.Count();

            double queryPageCount = rowCount / pageSize;

            pageCount = (int)Math.Ceiling(queryPageCount);

            return query.Skip(pageSize * (pageNumber - 1)).Take(pageSize);
        }
        
        
    }
}