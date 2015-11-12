using ShareMockups.DomainClasses;
using System.Collections.Generic;
using System.Linq;

namespace ShareMockups.DataContexts
{
    public class ShareMockupManager
    {
        //private ShareMockupsContext db = new ShareMockupsContext();

        public List<ShareMockup> Get(ShareMockup entity)
        {
            List<ShareMockup> ret = new List<ShareMockup>();

            using (var ctx = new ShareMockupsContext())
            {
                var list = from s in ctx.ShareMockups
                           where s.Available == true
                           select s;

                //    //TODO: Call your data access method.
                return list.ToList();
            }

            //ret = RetrieveMockData();

            //return ret;

        }

        private List<ShareMockup> RetrieveMockData()
        {
            List<ShareMockup> ret = new List<ShareMockup>();

            ret.Add(new ShareMockup()
            {
                ShareMockupId = 1,
                MockupName = "Single Page Approach",
                Url = "http://ShareMockups/SinglePage",
                Description = "This is a test passing the ShareMockups model to ShareMockupsViewModel",
                Rate = 5,
                Available = true
            });

            ret.Add(new ShareMockup()
            {
                ShareMockupId = 1,
                MockupName = "HTML 5, CSS, and JQuery Web Technologies using CRUD",
                Url = "http://ShareMockups/ClientCRUD",
                Description = "Another TEST for Client CRUD, passing the ShareMockups model to ShareMockupsViewModel",
                Rate = 5,
                Available = true
            });

            return ret;
        }

    }
}