using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission11_NickDizes.Models;
using Mission11_NickDizes.Models.ViewModels;

namespace Mission11_NickDizes.Controllers;

public class HomeController : Controller
{
    private IBookRepository _repo;
    public HomeController(IBookRepository temp)
    {
        _repo = temp;
    }

    public IActionResult Index(int pageNum)
    {
        int pageSize = 10;
        var blah = new BookListViewModel
        {
            Books = _repo.Books
                .OrderBy(x => x.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

            PaginationInfo = new PaginationInfo
            {
                CurrentPage = pageNum,
                ItemsPerPage = pageSize,
                TotalItems = _repo.Books.Count()
            }
        };
        return View(blah);
    }
}