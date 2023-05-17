using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mvc_Razor.Data;
using Mvc_Razor.Models;

namespace Mvc_Razor.Controllers
{
    public class InfoController : Controller
    {
        private readonly ApplicationDBContext _context;
        public InfoController(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> index(string SearchString)
        {

            ViewData["CurrentFilter"] = SearchString;

            var customers = from c in _context.Customers
                            select c;
            if (!String.IsNullOrEmpty(SearchString))
            {
                customers = customers.Where(c => c.LastName.Contains(SearchString)
                                       || c.FirstName.Contains(SearchString));
            }



            List<InfoViewModel> List = new List<InfoViewModel>();
            var items = await (from customer in customers
                               join list in _context.CustomerBookLists on customer.CustomerId equals list.FkCustomerId
                               join book in _context.Books on list.FkBookId equals book.BookId
                               select new
                               {
                                   FirstName = customer.FirstName,
                                   LastName = customer.LastName,
                                   Title = book.Title,
                                   Start = list.Start,
                                   Stop = list.Stop
                               }).ToListAsync();
            // konvertera från anonymous
            foreach (var item in items)
            {
                InfoViewModel listItem = new InfoViewModel();
                listItem.Start = item.Start;
                listItem.Stop = item.Stop;
                listItem.Title = item.Title;
                listItem.FirstName = item.FirstName;
                listItem.LastName = item.LastName;
                List.Add(listItem);
            }
            // Kalla på view
            return View(List);
        }
    }
}
