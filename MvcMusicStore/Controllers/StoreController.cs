using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/
        public string Index()
        {
            return "Hello from Store.Index()!";
        }

        //
        // GET: /Store/Browse?genre=?Disco
        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode(string.Format("Store.Browse, Genre = {0}", genre));
            return message;
        }
        
        //
        // GET: /Store/Details/5
        public string Details(int id)
        {
            string message = HttpUtility.HtmlEncode(string.Format("Store.Details, ID = {0}", id));
            return message;
        }
    }
}
