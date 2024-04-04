using Entities.DataTransferObject;
using Entities.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entities.Exceptions.NotFoundException;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/Books")]
    public class BooksController : ControllerBase
    {


        private readonly IServiceManager _manager;


        public BooksController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task <IActionResult> GetAllBooks()
        {

            var books =await _manager.BookService.GetAllBooksAsync(false);
            return Ok(books);
        }



        [HttpGet("{id:int}")]
        public async Task <IActionResult> GetOneBook([FromRoute(Name = "id")] int id)
        {


           
            var book = await _manager.BookService
            .GetOneBookByIdAsync(id, false);

            
            return Ok(book);
        }


        [HttpPost]
        public async Task <IActionResult> CreatedOneBook([FromBody] BookDtoForInsertion bookDto)
        {


            if (bookDto is null)
                return BadRequest();//404
            if(!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

           var book= await _manager.BookService.CreateOneBookAsync(bookDto);



            return StatusCode(201, book);
        }



        [HttpPut("{id:int}")]
        public async Task <IActionResult> UpdateOneBook([FromRoute(Name = "id")] int id, [FromBody] BookDtoForUpdate bookDto)
        {

            if (bookDto is null)
                return BadRequest();

            if(!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

           await _manager.BookService.UpdateOneBookAsync(id, bookDto, false);

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task <IActionResult> DeleteAllBooks([FromRoute(Name = "id")] int id)
        {



           await _manager.BookService.DeleteOneBookAsync(id, false);

            return NoContent();
        }




        [HttpPatch("{id:int}")]
        public async Task <IActionResult> PartiallyUpdateOneBook([FromRoute(Name = "id")] int id, [FromBody] JsonPatchDocument<BookDtoForUpdate> bookPatch)
        {

            if(bookPatch is null)
                return BadRequest();//400

            var result =await _manager.BookService.GetOneBookForPatchAsync(id, false);

            bookPatch.ApplyTo(result.BookDtoForUpdate,ModelState);
            TryValidateModel(result.BookDtoForUpdate);

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

          await  _manager.BookService.SaveChangesForPatchAsync(result.BookDtoForUpdate, result.book);
           

            return NoContent();
        }



    }
}
        
    


