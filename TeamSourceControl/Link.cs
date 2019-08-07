using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSourceControl
{
   public class Link
    {
        public Link()
        {

        }

        public Link( string URL, string Title)
        {
          
            LinkURL = URL;
            LinkTitle = Title;
        }

        public   int LinkID { get; set; }

        public string LinkURL { get; set; }

        public string LinkTitle { get; set; }




    }
}
