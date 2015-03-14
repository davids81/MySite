using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace DavesNation.Models
{
    public static class PostRepository
    {
        public static PostEntry GetPost(int Id)
        {
            PostEntry pe = new PostEntry();
            pe.Id = Id;
            pe.Deleted = false;
            pe.OwnerId = 22;
            pe.Date = DateTime.Now;
            pe.Text = "this is my first entry";
            pe.Title = "First Blog Post";
            return pe;
        }

        public static void SavePost(PostEntry Entry)
        {

        }
    }
}