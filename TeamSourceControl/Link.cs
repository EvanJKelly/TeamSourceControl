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

        public Link(string Title, string URL)
        {

            LinkTitle = Title;
            LinkURL = URL;
        }


        public int LinkId { get; set; }

        public string LinkTitle { get; set; }

        public string LinkURL { get; set; }

        public override string ToString()
        {
            return LinkTitle;
        }
    }
}
