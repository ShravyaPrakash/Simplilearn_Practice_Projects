using BusinessLogicLayer;
using DataAccessLayer;
using SimpliLearnProj4WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimpliLearnProj4WebAPI.Controllers
{
    public class MarksController : ApiController
    {
        MarkMethods methods = null;
        public MarksController()
        {
            methods = new MarkMethods();
        }
        // GET api/<controller>
        public List<MarksModel> GetList()
        {
            List<Mark> slist = methods.Showlist();
            List<MarksModel> list = new List<MarksModel>();
            foreach (var item in slist)
            {

                list.Add(new MarksModel
                {
                    StudId = item.StudId,
                    SubjectId = item.SubjectId,
                    marks = item.marks
                });

            }
            return list;
        }

        // GET api/<controller>/5
        public MarksModel GetById(int id)
        {
            Mark s = methods.FindSubMarks(id);
            MarksModel s1 = new MarksModel();
            s1.StudId = s.StudId;
            s1.SubjectId = s.SubjectId;
            s1.marks = s.marks;
            return s1;
        }

        // POST api/<controller>
        public void PostStud([FromBody] MarksModel s)
        {
            Mark s1 = new Mark();
            s1.StudId = s.StudId;
            s1.SubjectId = s.SubjectId;
            s1.marks = s.marks;

            methods.AddSubMarks(s1);

        }

        // PUT api/<controller>/5
        public void PutStud(int id, [FromBody] MarksModel s)
        {
            Mark s1 = new Mark();
            s1.StudId = s.StudId;
            s1.SubjectId = s.SubjectId;
            s1.marks = s.marks;

            methods.UpdateSubMarks(id, s1);

        }

        // DELETE api/<controller>/5
        public void DeleteStud(int id)
        {
            methods.DeleteSubMarks(id);

        }
    }
}