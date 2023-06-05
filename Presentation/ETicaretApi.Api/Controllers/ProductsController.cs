using ETicaretApi.Application.Features.Commands.Product.CreateProduct;
using ETicaretApi.Application.Features.Commands.Product.RemoveProduct;
using ETicaretApi.Application.Features.Commands.Product.UpdateProduct;
using ETicaretApi.Application.Features.Commands.ProductImageFile.RemoveProductImage;
using ETicaretApi.Application.Features.Commands.ProductImageFile.UploadProductImage;
using ETicaretApi.Application.Features.Queries.Product.GetAllProduct;
using ETicaretApi.Application.Features.Queries.Product.GetProductById;
using ETicaretApi.Application.Features.Queries.Product.ProductImageFile.GetProductImages;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ETicaretApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductsController(IMediator mediator)
        {
           
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllProductQueryRequest request)
        {
            GetAllProductQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetProductByIdQueryRequest request)
        {
            GetProductByIdQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateProductCommandRequest request)
        {

            CreateProductCommandReponse reponse = await _mediator.Send(request);
            return StatusCode((int)HttpStatusCode.Created);

        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateProductCommandRequest request)
        {
            UpdateProductCommandResponse response = await _mediator.Send(request);
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveProductCommandRequest request)
        {
            RemoveProductCommandResponse response = await _mediator.Send(request);
            return Ok();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Upload([FromQuery] UploadProductImageCommandRequest request)
        {
            request.Files = Request.Form.Files;
            UploadProductImageCommandResponse response =  await _mediator.Send(request);
            return Ok();
        }

        [HttpGet("[action]/{Id}")]
        public async Task<IActionResult> GetProductImages([FromRoute] GetProductImagesQueryRequest request)
        {
            List<GetProductImagesQueryResponse> response = await _mediator.Send(request);
            return Ok(response);
        }
        //In Requests will be changes for best practice
        [HttpDelete("[action]/{Id}")]
        public async Task<IActionResult> DeleteProductImage([FromRoute] RemoveProductImageCommandRequest request, [FromQuery] string imageId)
        {
            request.ImageId = imageId;
            RemoveProductImageCommandResponse response = await _mediator.Send(request);
            return Ok();

        }
    }
}
