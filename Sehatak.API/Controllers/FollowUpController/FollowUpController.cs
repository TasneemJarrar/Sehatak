using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sehatak.Application.Common;
using Sehatak.Application.DTOs.FollowUpDto;
using Sehatak.Application.Interfaces.IFollowUp;
using Sehatak.Domain.Entities.TenantEntities;

namespace Sehatak.API.Controllers.FollowUpController
{
    [ApiController]
    [Route("[Controller]")]
    public class FollowUpController : ControllerBase
    {
        private readonly IFollowUp followUpService;

        public FollowUpController(IFollowUp followUpService)
        {
            this.followUpService = followUpService;
        }

        [Authorize(Policy = "DoctorOnly")]
        [HttpPost("doctor-add-followup/{centerId}")]
        public async Task<IActionResult> DoctorAddFollowUpAsync(int centerId, [FromBody] DoctorAddFollowUpRequestDto request)
        {
            var userId = int.Parse(User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)!.Value);
            var result = await followUpService.DoctorAddFollowUpAsync(centerId, userId, request);
            return Ok(result);
        }

        [Authorize(Policy = "DoctorOnly")]
        [HttpPost("doctor-update-followup/{centerId}")]
        public async Task<IActionResult> DoctorUpdateFollowUpAsync(int centerId, [FromBody] UpdateFollowUpRequestDto request)
        {
            var userId = int.Parse(User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)!.Value);
            var result = await followUpService.DoctorUpdateFollowUpAsync(centerId, userId, request);
            return Ok(result);
        }

        [Authorize(Policy = "DoctorOnly")]
        [HttpGet("doctor-get-followups/{centerId}")]
        public async Task<IActionResult> DoctorGetAllFollowUpAsync(int centerId, [FromQuery] PagedRequest request)
        {
            var userId = int.Parse(User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)!.Value);
            var result = await followUpService.DoctorGetAllFollowUpAsync(centerId, userId, request);
            return Ok(result);
        }

        [Authorize(Policy = "ReceptionistOnly")]
        [HttpPost("receptionist-add-followup/{centerId}")]
        public async Task<IActionResult> ReceptionistAddFollowUpAsync(int centerId, [FromBody] ReceptionistAddFollowUpRequestDto request)
        {
            var userId = int.Parse(User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)!.Value);
            var result = await followUpService.ReceptionistAddFollowUpAsync(centerId, userId, request);
            return Ok(result);
        }

        [Authorize(Policy = "ReceptionistOnly")]
        [HttpPost("receptionist-update-followup/{centerId}")]
        public async Task<IActionResult> ReceptionistUpdateFollowUpAsync(int centerId, [FromBody] UpdateFollowUpRequestDto request)
        {
            var userId = int.Parse(User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)!.Value);
            var result = await followUpService.ReceptionistUpdateFollowUpAsync(centerId, userId, request);
            return Ok(result);
        }

        [Authorize(Policy = "ReceptionistOnly")]
        [HttpGet("receptionist-get-followups/{centerId}")]
        public async Task<IActionResult> ReceptionistGetAllFollowUpAsync(int centerId, [FromQuery] PagedRequest request)
        {
            var userId = int.Parse(User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)!.Value);
            var result = await followUpService.ReceptionistGetAllFollowUpAsync(centerId, userId, request);
            return Ok(result);
        }

        [Authorize(Policy = "PatientOnly")]
        [HttpGet("patient-get-followups/{centerId}")]
        public async Task<IActionResult> PatientGetAllFollowUpAsync(int centerId, [FromQuery] PagedRequest request, [FromQuery] int? subPatientId)
        {
            var userId = int.Parse(User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)!.Value);
            var result = await followUpService.PatientGetAllFollowUpAsync(centerId, userId, request, subPatientId);
            return Ok(result);
        }
    }
}
