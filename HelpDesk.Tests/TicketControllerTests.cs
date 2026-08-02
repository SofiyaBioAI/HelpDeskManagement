using HelpDesk.Api.Controllers;
using HelpDesk.Api.Models;
using HelpDesk.Api.Repositories;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Net.Sockets;
using Xunit;

namespace HelpDesk.Tests
{
    public class TicketControllerTests
    {
        private readonly Mock<ITicketRepository> _mockRepository;
        private readonly TicketController _controller;

        public TicketControllerTests()
        {
            _mockRepository = new Mock<ITicketRepository>();
            _controller = new TicketController(_mockRepository.Object);
        }

        [Fact]
        public async Task GetAllTickets_ReturnsOkResult_WhenTicketsExist()
        {
            // Arrange
            var tickets = new List<Ticket>
            {
                new Ticket
                {
                    Id = 1,
                    Title = "Printer Issue",
                    Description = "Printer not working",
                    Priority = "High",
                    Status = "Open",
                    RaisedBy = "Sofiya",
                    CreatedDate = DateTime.Now
                }
            };

            _mockRepository.Setup(r => r.GetAllTicketsAsync())
                           .ReturnsAsync(tickets);

            // Act
            var result = await _controller.GetAllTickets();

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async Task GetTicketById_ReturnsOkResult_WhenTicketExists()
        {
            // Arrange
            var ticket = new Ticket
            {
                Id = 1,
                Title = "Printer Issue",
                Description = "Printer not working",
                Priority = "High",
                Status = "Open",
                RaisedBy = "Sofiya",
                CreatedDate = DateTime.Now
            };

            _mockRepository.Setup(r => r.GetTicketByIdAsync(1))
                           .ReturnsAsync(ticket);

            // Act
            var result = await _controller.GetTicketById(1);

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async Task GetTicketById_ReturnsNotFound_WhenTicketDoesNotExist()
        {
            // Arrange
            _mockRepository.Setup(r => r.GetTicketByIdAsync(100))
                           .ReturnsAsync((Ticket)null);

            // Act
            var result = await _controller.GetTicketById(100);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task CreateTicket_ReturnsOkResult_WhenTicketIsCreatedSuccessfully()
        {
            // Arrange
            var ticket = new Ticket
            {
                Title = "Network Issue",
                Description = "Internet Down",
                Priority = "Medium",
                Status = "Open",
                RaisedBy = "Sofiya"
            };

            _mockRepository.Setup(r => r.CreateTicketAsync(It.IsAny<Ticket>()))
                           .ReturnsAsync(1);

            // Act
            var result = await _controller.CreateTicket(ticket);

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async Task CreateTicket_ReturnsBadRequest_WhenTicketIsNull()
        {
            // Act
            var result = await _controller.CreateTicket(null);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task GetTicketsByStatus_ReturnsOkResult_WhenMatchingTicketsExist()
        {
            // Arrange
            var tickets = new List<Ticket>
            {
                new Ticket
                {
                    Id = 1,
                    Title = "Network Issue",
                    Description = "Internet Down",
                    Priority = "High",
                    Status = "Open",
                    RaisedBy = "Sofiya",
                    CreatedDate = DateTime.Now
                }
            };

            _mockRepository.Setup(r => r.GetTicketsByStatusAsync("Open"))
                           .ReturnsAsync(tickets);

            // Act
            var result = await _controller.GetTicketsByStatus("Open");

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }
    }
}