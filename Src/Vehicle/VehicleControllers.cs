
using ApiTest.Src.Vehicle.Dto;
using ApiTest.Utils;
using Microsoft.AspNetCore.Mvc;


namespace ApiTest.Src.Vehicle
{
    [Route("api/vehicles")]
    public class VehicleController(VehicleServices vehicleServices) : BaseController<VehicleModel, CreateVehicleDto, UpdateVehicleDto>(vehicleServices)
    {
        private readonly VehicleServices _vehicleServices = vehicleServices;

        [HttpPost("create")]
        public IActionResult CreateVehicle([FromBody] CreateVehicleDto dto)
        {
            var result = SafeExecutor.Execute(() => _vehicleServices.CreateVehicle(dto));
            return Ok(result);
        }

        [HttpGet("license/{licensePlate}")]
        public IActionResult GetByLicensePlate(string licensePlate)
        {
            var result = SafeExecutor.Execute(() => _vehicleServices.GetByLicensePlate(licensePlate));
            return Ok(result);
        }

        [HttpGet("customer/{idCustomer}")]
        public IActionResult GetVehiclesByCustomer(int idCustomer){
            var result = SafeExecutor.Execute(() => _vehicleServices.GetVehiclesByCustomer(idCustomer));
            return Ok(result);
        }
    }

}
