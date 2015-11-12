using ShareMockups.DomainClasses;
using System.Collections.Generic;

namespace ShareMockups.DataContexts
{
    public class ShareMockupsViewModel
    {
        public ShareMockupsViewModel()
        {
            init();
        }

        public void init()
        {
            EventCommand = "List";
            EventArgument = string.Empty;

            Mockups      = new List<ShareMockup>();
            SearchEntity = new ShareMockup();
            Entity       = new ShareMockup();

        }

        public ShareMockup       Entity       { get; set; }
        public List<ShareMockup> Mockups      { get; set; }
        public ShareMockup       SearchEntity { get; set; }

        public string EventCommand  { get; set; }
        public bool   IsValid       { get; set; }
        public string Mode          { get; set; }
        public string EventArgument { get; set; }


        public void HandleRequest()
        {
            switch (EventCommand.ToLower())
            {
                case "list":
                case "search":
                    Get();
                    break;

                default:
                    break;
            }
        }

        public void Get()
        {

            ShareMockupManager mgr = new ShareMockupManager();
            Mockups = mgr.Get(SearchEntity);
        }

    }
}
