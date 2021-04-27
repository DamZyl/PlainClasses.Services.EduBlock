using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PlainClasses.Services.EduBlock.Api.Controllers.Requests;
using PlainClasses.Services.EduBlock.Application.Commands.AddFunction;
using PlainClasses.Services.EduBlock.Application.Commands.AddPlatoon;
using PlainClasses.Services.EduBlock.Application.Commands.CreateEduBlock;
using PlainClasses.Services.EduBlock.Application.Commands.DeleteEduBlock;
using PlainClasses.Services.EduBlock.Application.Commands.DeleteFunction;
using PlainClasses.Services.EduBlock.Application.Commands.DeletePlatoon;
using PlainClasses.Services.EduBlock.Application.Commands.UpdateEduBlock;
using PlainClasses.Services.EduBlock.Application.Queries.GetEduBlock;
using PlainClasses.Services.EduBlock.Application.Queries.GetEduBlocks;

namespace PlainClasses.Services.EduBlock.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EduBlockController : Controller
    {
        private readonly IMediator _mediator;

        public EduBlockController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [Route("")]
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<EduBlockViewModel>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetEduBlocks()
        {
            var eduBlocks = await _mediator.Send(new GetEduBlocksQuery());

            return Ok(eduBlocks);
        }
        
        [Route("{id}")]
        [HttpGet]
        [ProducesResponseType(typeof(EduBlockDetailViewModel), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetEduBlock(Guid id)
        {
            var eduBlock = await _mediator.Send(new GetEduBlockQuery { Id = id });

            return Ok(eduBlock);
        }
        
        [Route("")]
        [HttpPost]
        [ProducesResponseType(typeof(ReturnEduBlockViewModel), (int)HttpStatusCode.Created)]
        public async Task<IActionResult> CreateEduBlock([FromBody]CreateEduBlockRequest request) 
        {
            var eduBlock = await _mediator.Send(new CreateEduBlockCommand(request.EduBlockSubjectId, 
                request.StartEduBlock, request.EndEduBlock, request.Remarks, request.Place, request.PlatoonIds));

            return Created(string.Empty, eduBlock);
        }  
        
        [Route("{id}/platoon/{platoonId}")]
        [HttpPost]
        [ProducesResponseType(typeof(ReturnEduBlockViewModel), (int)HttpStatusCode.Created)]
        public async Task<IActionResult> AddPlatoonToEduBlock(Guid id, Guid platoonId) 
        {
            var eduBlock = await _mediator.Send(new AddPlatoonCommand(id, platoonId));

            return Created(string.Empty, eduBlock);
        }
        
        [Route("{id}/function")]
        [HttpPost]
        [ProducesResponseType(typeof(ReturnEduBlockViewModel), (int)HttpStatusCode.Created)]
        public async Task<IActionResult> AddFunctionForPersonInEduBlock(Guid id, [FromBody]AddFunctionRequest request) 
        {
            var eduBlock = await _mediator.Send(new AddFunctionCommand(id, request.PersonId, request.Function));

            return Created(string.Empty, eduBlock);
        }
        
        [Route("{id}")]
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public async Task<IActionResult> UpdateEduBlock(Guid id, [FromBody]UpdateEduBlockRequest request)
        {
            await _mediator.Send(new UpdateEduBlockCommand(id, request.Remarks, request.Place, 
                request.StartEduBlock, request.EndEduBlock));

            return NoContent();
        }
        
        [Route("{id}")]
        [HttpDelete]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public async Task<IActionResult> DeleteEduBlock(Guid id)
        {
            await _mediator.Send(new DeleteEduBlockCommand(id));

            return NoContent();
        }
        
        [Route("{id}/platoon/{platoonId}")]
        [HttpDelete]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public async Task<IActionResult> DeletePlatoonFromEduBlock(Guid id, Guid platoonId)
        {
            await _mediator.Send(new DeletePlatoonFromEduBlockCommand(id, platoonId));

            return NoContent();
        }
        
        [Route("{id}/function/{functionId}")]
        [HttpDelete]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public async Task<IActionResult> DeleteFunctionPersonFromEduBlock(Guid id, Guid functionId)
        {
            await _mediator.Send(new DeleteFunctionCommand(id, functionId));

            return NoContent();
        }
    }
}