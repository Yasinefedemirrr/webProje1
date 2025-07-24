using Application.Features.Mediator.Commands.BookCommands;
using Application.Features.Mediator.Queries.BookQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BooksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> BookList()
        {
            var values = await _mediator.Send(new GetBookQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBook(int id)
        {
            var value = await _mediator.Send(new GetBookByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBook(CreateBookCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kitap Bilgisi Başarıyla eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveBook(int id)
        {
            await _mediator.Send(new RemoveBookCommand(id));
            return Ok("Kitap Bilgisi Başarıyla Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBook(UpdateBookCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kitap Bilgisi başarıyla Güncellendi");
        }
    }
}
