using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace genericRepoDemo.Controllers
{
    public class BaseController<T> : Controller where T : class
    {
        public List<T> PaginatedResult(List<T> t, int page, int rowsPerPage)
        {
            @ViewBag.TotalRecords = t.Count;
            @ViewBag.CurrentPage = page;

            var skip = (page - 1) * rowsPerPage;

            var paginatedResult = t.Skip(skip).Take(rowsPerPage).ToList();
            return paginatedResult;
        }
    }
}