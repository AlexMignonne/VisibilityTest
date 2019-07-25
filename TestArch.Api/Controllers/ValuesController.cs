using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TestArch.Shared;

namespace TestArch.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ValuesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET api/values
        [HttpGet("{st}")]
        public async Task<ActionResult<string>> Get(
            [FromRoute] string st,
            CancellationToken token)
        {
            return await _mediator.Send(
                new TestCommand(st),
                token);
        }
    }
}