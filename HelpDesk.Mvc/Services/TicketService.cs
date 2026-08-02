using HelpDesk.Mvc.Models;
using System.Text;
using System.Text.Json;

namespace HelpDesk.Mvc.Services
{
    public class TicketService
    {
        private readonly HttpClient _httpClient;

        public TicketService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Ticket>> GetAllTicketsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Ticket>>("api/Ticket")
                   ?? new List<Ticket>();
        }

        public async Task<Ticket?> GetTicketByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Ticket>($"api/Ticket/{id}");
        }

        public async Task CreateTicketAsync(Ticket ticket)
        {
            var json = JsonSerializer.Serialize(ticket);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            await _httpClient.PostAsync("api/Ticket", content);
        }

        public async Task UpdateTicketAsync(Ticket ticket)
        {
            var json = JsonSerializer.Serialize(ticket);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            await _httpClient.PutAsync($"api/Ticket/{ticket.Id}", content);
        }

        public async Task DeleteTicketAsync(int id)
        {
            await _httpClient.DeleteAsync($"api/Ticket/{id}");
        }

        public async Task<List<Ticket>> GetTicketsByStatusAsync(string status)
        {
            return await _httpClient.GetFromJsonAsync<List<Ticket>>($"api/Ticket/Status/{status}")
                   ?? new List<Ticket>();
        }
    }
}