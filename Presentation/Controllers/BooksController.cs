﻿using Entities.DataTransferObject;
using Entities.Models;
using Entities.Request_Features;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Presentation.ActionFilters;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static Entities.Exceptions.NotFoundException;

namespace Presentation.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
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
        [ServiceFilter(typeof(ValidateMediaTypeAttribute))]
        public async Task <IActionResult> GetAllBooks([FromQuery]BookParameters bookParameters)
        {
            var linkParameters = new LinkParameters()
            {
                BookParameters = bookParameters,
                HttpContext = HttpContext
            };
            var result =await _manager
                .BookService
                .GetAllBooksAsync(linkParameters,false);
            Response.Headers.Add("X-Pagination"
                ,JsonSerializer.Serialize(result.metaData));
           return result.linkResponse.HasLinks ?
                Ok(result.linkResponse.LinkedEntities) :
                Ok(result.linkResponse.ShapedEntities);
        }



        [HttpGet("{id:int}")]
        public async Task <IActionResult> GetOneBook([FromRoute(Name = "id")] int id)
        {


           
            var book = await _manager.BookService
            .GetOneBookByIdAsync(id, false);

            
            return Ok(book);
        }

        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [HttpPost]
        public async Task <IActionResult> CreatedOneBook([FromBody] BookDtoForInsertion bookDto)
        {
           
           var book= await _manager.BookService.CreateOneBookAsync(bookDto);

            return StatusCode(201, book);
        }


        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [HttpPut("{id:int}")]
        public async Task <IActionResult> UpdateOneBook([FromRoute(Name = "id")] int id, [FromBody] BookDtoForUpdate bookDto)
        {


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
        
    


