﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;

namespace TinkerSwiftApi.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            //I can get userID, username and more with this statement
            string userId = RequestContext.Principal.Identity.GetUserId();
            return new string[] { "value1", "value2", userId };
        }

        // public IEnumerable<string> Get()
        //public IHttpActionResult Get()
        //{
        //    //I can get userID, username and more with this statement
        //    //string userId = RequestContext.Principal.Identity.GetUserId();
        //    //return new string[] { "value1", "value2", userId };

        //    string userId = RequestContext.Principal.Identity.GetUserId();
        //    return Ok(new string[] { "value1", "value2", userId });
        //}

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
