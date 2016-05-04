using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Hni.TestMVC6.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Hni.TestMVC6.Controllers
{

    [Route("api/[controller]")]
    public class AuditorsController : Controller
    {
        private SampleInspectionContext _context;

        public AuditorsController(SampleInspectionContext context)
        {
            _context = context;
        }

        // GET: api/auditors
        [HttpGet]
        public IEnumerable<Auditor> Get()
        {
            return _context.Auditor.OrderBy(col => col.AuditorId);
        }

        // GET api/auditors/5
        [HttpGet("{id}",Name ="GetAuditor")]
        public IActionResult Get(int id)
        {
            Auditor auditor = _context.Auditor.Where(key => key.AuditorId == id).SingleOrDefault();
            if(auditor == null)
            {
                return HttpNotFound();
            }
            return new ObjectResult(auditor);
        }

        // POST api/auditors -- insert
        [HttpPost]
        public IActionResult Post([FromBody]Auditor auditor)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            _context.Auditor.Add(auditor);
            _context.SaveChanges();
            //return new NoContentResult();
            return CreatedAtRoute("GetAuditor", new { id = auditor.AuditorId }, auditor);
        }

        // PUT api/auditors/5 -- update
        [HttpPut("{id}")]
        public IActionResult Put(int id,[FromBody]Auditor auditor)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }
            if (id != auditor.AuditorId)
            {
                return HttpBadRequest();
            }

            Auditor auditorToBeUpdated = _context.Auditor.Where(key => key.AuditorId == id).SingleOrDefault();
            if(auditorToBeUpdated == null)
            {
                return HttpNotFound();
            }
            auditorToBeUpdated.AuditorName = auditor.AuditorName;
            _context.SaveChanges();
            return new NoContentResult();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Auditor auditor = _context.Auditor.Where(key => key.AuditorId == id).SingleOrDefault();
            if (auditor == null)
            {
                return HttpBadRequest();
            }
            _context.Auditor.Remove(auditor);
            _context.SaveChanges();
            return new NoContentResult();
        }
    }
}
