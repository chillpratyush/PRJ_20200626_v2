using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TBL_TRN_TASKS_CLASSLIBRARY;

namespace PRJ_20200626_v2.Controllers
{
    public class TBL_TRN_USERController : ApiController
    {
        public IEnumerable<TBL_TRN_USER> Get()
        {
            using (EasyLivingEntities entities = new EasyLivingEntities())
            {
                return entities.TBL_TRN_USER.ToList();
            }
        }
        public TBL_TRN_USER Get(int id)
        {
            using (EasyLivingEntities entities = new EasyLivingEntities())
            {
                return entities.TBL_TRN_USER.FirstOrDefault(e => e.USER_ID == id);
            }

        }

        public HttpResponseMessage Post([FromBody] TBL_TRN_USER TBL_TRN_USER)
        {
            try
            {
                using (EasyLivingEntities entities = new EasyLivingEntities())
                {
                    entities.TBL_TRN_USER.Add(TBL_TRN_USER);
                    entities.SaveChanges();
                    var message = Request.CreateResponse(HttpStatusCode.Created, TBL_TRN_USER);
                    message.Headers.Location = new Uri(Request.RequestUri + TBL_TRN_USER.USER_ID.ToString());
                    return message;
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
