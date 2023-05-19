using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using MCFWebAPI.DBClass;
using MCFWebAPI.Models;
using MCFWebAPI.Repositories;

using System.Linq;

namespace MCFWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MCFController : ControllerBase
    {
        private readonly IMCFRepository _repository;

        public MCFController(IMCFRepository tasklistRepository)
        {
            _repository = tasklistRepository;

        }

        [HttpGet]
        [Route("bpkb/list")]
        public async Task<IActionResult> ListBPKB()
        {
            var data = await _repository.List_BPKB();
            if (data.Any())
                return Ok(data);

            return Ok(APIResult.ResponseAPI(false, APIResult.Level.READ_FAILED));
        
        }

        [HttpGet]
        [Route("bpkb/{agreement_no}")]
        public BPKB GetBPKB(string agreement_no)
        {
            var data = _repository.Get_BPKB(agreement_no);
            return data;
        }
        [HttpGet]
        [Route("location/{location_id}")]
        public Location GetLocation(string location_id)
        {
            var data = _repository.Get_Location(location_id);
            return data;
        }

        [HttpGet]
        [Route("location/list")]
        public async Task<IActionResult> ListLocation()
        {
            var data = await _repository.List_Location();
            if (data.Any())
                return Ok(data);
            else
                return NotFound("Location is empty");
//            return Ok(APIResult.ResponseAPI(false, APIResult.Level.READ_FAILED));

        }

        [HttpPost]
        [Route("bpkb/add")]
        public ActionResult BPKBAdd([FromBody] BPKB _bpkb)
        {
            try
            {
                _repository.Add_BPKB(_bpkb);
                return Ok(APIResult.ResponseAPI(true, APIResult.Level.CREATE));

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

    }


}
