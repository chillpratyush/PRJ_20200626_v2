using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TBL_TRN_TASKS_CLASSLIBRARY;

namespace PRJ_20200626_v2.Controllers
{
    public class TBL_TRN_TASKSController : ApiController
    {
        public IEnumerable<TBL_TRN_TASKS> Get()
        {
            using (EasyLivingEntities entities = new EasyLivingEntities())
            {
                return entities.TBL_TRN_TASKS.ToList();
            }
        }
        public TBL_TRN_TASKS Get(int id)
        {
            using (EasyLivingEntities entities = new EasyLivingEntities())
            {
                return entities.TBL_TRN_TASKS.FirstOrDefault(e => e.TASK_ID == id);
            }

        }

        public HttpResponseMessage Post([FromBody] TBL_TRN_TASKS tbl_trn_tasks)
        {
            try
            {
                using (EasyLivingEntities entities = new EasyLivingEntities())
                {
                    entities.TBL_TRN_TASKS.Add(tbl_trn_tasks);
                    entities.SaveChanges();
                    var message = Request.CreateResponse(HttpStatusCode.Created, tbl_trn_tasks);
                    message.Headers.Location = new Uri(Request.RequestUri + tbl_trn_tasks.TASK_ID.ToString());
                    return message;
                }
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}