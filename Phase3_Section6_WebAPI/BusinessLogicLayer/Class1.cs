using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class MarkMethods
    {
        SchoolEntities context = null;
        public MarkMethods()
        {
            context = new SchoolEntities();
        }
        public bool AddSubMarks(Mark s)
        {
            try
            {
                context.Marks.Add(s);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public bool UpdateSubMarks(int id, Mark s)
        {
            try
            {
                List<Mark> list = context.Marks.ToList();
                Mark s1 = list.Find(x => x.StudId == id);
                s1.StudId = s.StudId;
                s1.subject = s.subject;
                s1.marks = s.marks;

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public Mark FindSubMarks(int id)
        {
            List<Mark> list = context.Marks.ToList();
            Mark s1 = list.Find(x => x.StudId == id);
            return s1;
        }
        public bool DeleteSubMarks(int id)
        {
            try
            {
                List<Mark> list = context.Marks.ToList();
                Mark s1 = list.Find(x => x.StudId == id);
                context.Marks.Remove(s1);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public List<Mark> Showlist()
        {
            List<Mark> list = context.Marks.ToList();
            return list;
        }
    }
}
