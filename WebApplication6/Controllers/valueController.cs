using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication6;

namespace WebApplication6.Controllers
{
    public class valueController : ApiController
    {
        IList<moya> _moya = new List<moya>()
        {
            new moya {deck="loading", passangers =5},
            new moya{deck="control", passangers=2}
        };

        [HttpGet]
        public IEnumerable<moya> showvalue()
        {
            return _moya;
        }

        [HttpGet]
        public IHttpActionResult showvalue(int i)
        {
            var result = from moya in _moya select moya;
            return Ok(result);
        }
    }
}
