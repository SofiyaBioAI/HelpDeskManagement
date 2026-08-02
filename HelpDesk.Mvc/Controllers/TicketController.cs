using HelpDesk.Mvc.Models;
using HelpDesk.Mvc.Services;
using HelpDesk.Mvc.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HelpDesk.Mvc.Controllers
{
    public class TicketController : Controller
    {
        private readonly TicketService _ticketService;

        public TicketController(TicketService ticketService)
        {
            _ticketService = ticketService;
        }

        // Dashboard
        public async Task<IActionResult> Dashboard()
        {
            var tickets = await _ticketService.GetAllTicketsAsync();

            DashboardViewModel model = new DashboardViewModel
            {
                TotalTickets = tickets.Count,
                OpenTickets = tickets.Count(t => t.Status == "Open"),
                ClosedTickets = tickets.Count(t => t.Status == "Closed")
            };

            return View(model);
        }

        // Filter Tickets by Status
        public async Task<IActionResult> Filter(string status)
        {
            if (string.IsNullOrEmpty(status))
            {
                var tickets = await _ticketService.GetAllTicketsAsync();
                return View(tickets);
            }

            var filteredTickets = await _ticketService.GetTicketsByStatusAsync(status);

            return View(filteredTickets);
        }
        // Display all tickets
        public async Task<IActionResult> Index()
        {
            var tickets = await _ticketService.GetAllTicketsAsync();
            return View(tickets);
        }

        // Display ticket details
        public async Task<IActionResult> Details(int id)
        {
            var ticket = await _ticketService.GetTicketByIdAsync(id);

            if (ticket == null)
                return NotFound();

            return View(ticket);
        }

        // Create Ticket - GET
        public IActionResult Create()
        {
            return View();
        }

        // Create Ticket - POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Ticket ticket)
        {
            ticket.Status = "Open";
            ticket.CreatedDate = DateTime.Now;

            if (!ModelState.IsValid)
            {
                return View(ticket);
            }

            await _ticketService.CreateTicketAsync(ticket);

            return RedirectToAction(nameof(Index));
        }

        // Edit Ticket - GET
        public async Task<IActionResult> Edit(int id)
        {
            var ticket = await _ticketService.GetTicketByIdAsync(id);

            if (ticket == null)
                return NotFound();

            return View(ticket);
        }

        // Edit Ticket - POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Ticket ticket)
        {
            if (!ModelState.IsValid)
            {
                return View(ticket);
            }

            await _ticketService.UpdateTicketAsync(ticket);

            return RedirectToAction(nameof(Index));
        }

        // Delete Ticket - GET
        public async Task<IActionResult> Delete(int id)
        {
            var ticket = await _ticketService.GetTicketByIdAsync(id);

            if (ticket == null)
                return NotFound();

            return View(ticket);
        }

        // Delete Ticket - POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _ticketService.DeleteTicketAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}