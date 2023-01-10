using Microsoft.AspNetCore.Mvc;
using ShekelHomeAsssignment.Data;
using ShekelHomeAsssignment.Models;
using ShekelHomeAsssignment.Service;
using ShekelHomeAsssignment.Utilities;

namespace ShekelHomeAsssignment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customersService;
        public CustomerController(ICustomerService customersService)
        {
            _customersService = customersService;
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomer(AddCustomerRequest cutomerRequest)
        {
            try
            {
                CustomerRequestValidityCheck(cutomerRequest);
                await _customersService.AddCustomer(cutomerRequest).ConfigureAwait(false);
            }
            catch (ErrorResponse ex)
            {
                return StatusCode(ex.ErrorCode, ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetGroup(int id)
        {
            try
            {
                return Ok(await _customersService.GetGroup(id));
            }
            catch (ErrorResponse ex)
            {
                return StatusCode(ex.ErrorCode, ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        private bool CustomerRequestValidityCheck(AddCustomerRequest customerRequest)
        {
            if (customerRequest.CustomerId == default(int))
                throw new ErrorResponse(400, "Invalid Customer Id");

            if (string.IsNullOrEmpty(customerRequest.Address))
                throw new ErrorResponse(400, "Invalid Address");

            if (customerRequest.FactoryCode == default(int))
                throw new ErrorResponse(400, "Invalid Factory Id");

            if (customerRequest.GroupKod == default(int))
                throw new ErrorResponse(400, "Invalid GroupKod");
            return true;
        }
    }
}
