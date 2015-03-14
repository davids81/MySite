using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DavesNation.Models
{
    public class PostEntry
    {

        public int Id
        {
            get;set;
        }

        public string Title
        {
            get;set;
        }

        public DateTime Date
        {
            get;set;
        }

        public bool Deleted
        {
            get;set;
        }

        public int OwnerId
        {
            get;set;
        }

        public string Text
        {
            get;set;
        }
      
    }
}