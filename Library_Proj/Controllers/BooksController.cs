
using Coding_Challenge_Backend.Interfaces;
using Coding_Challenge_Backend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

namespace Coding_Challenge_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;
        private readonly ILogger<BooksController> _logger;

        public BooksController(IBookService bookService, ILogger<BooksController> logger)
        {
            _bookService = bookService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetAllBooks()
        {
            try
            {
                var books = await _bookService.GetAllBooks();
                return Ok(books);
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex.Message);
                return NotFound(ex.Message);
            }
        }

        [HttpGet("bookId")]
        public async Task<ActionResult<List<Book>>> GetBookById(int bookId)
        {
            try
            {
                var book = await _bookService.GetBookById(bookId);
                return Ok(book);
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex.Message);
                return NotFound(ex.Message);
            }
        }

        [Route("AddBook")]
        [HttpPost]

        public async Task<ActionResult<Book>> AddBook(Book book)
        {
            try
            {
                book = await _bookService.AddBook(book);
                return book;
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex.Message);
                return NotFound(ex.Message);
            }
        }
        [HttpPut]
        public async Task<ActionResult<Book>> UpdateBook(Book book)
        {

            try
            {
                var _book = await _bookService.UpdateBook(book);
                return _book;
            }
            catch (Exception ex)

            {
                _logger.LogInformation(ex.Message);
                return NotFound(ex.Message);
            }
        }

        [HttpDelete]
        public async Task<ActionResult<Book>> RemoveBook(int bookId)
        {
            try
            {
                var result = await _bookService.RemoveBook(bookId);
                return result;
            }
            catch (Exception ex)

            {
                _logger.LogInformation(ex.Message);
                return NotFound(ex.Message);
            }
        }
    }

}
