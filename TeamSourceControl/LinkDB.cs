using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSourceControl
{
    static class LinkDB
    {
        public static List<Link> GetAllLinks()
        {
            SqlConnection con = DBHelper.GetConnection();

            string query = "SELECT URL, Title " +
                "FROM VideoLinks";

            SqlCommand selCmd = new SqlCommand();
            selCmd.Connection = con;
            selCmd.CommandText = query;

            //open connection to DB
            con.Open();

            //Execute query
            SqlDataReader rdr = selCmd.ExecuteReader();

            List<Link> linkList = new List<Link>();
            while (rdr.Read())
            {
                Link tempLink = new Link();
                tempLink.LinkURL = Convert.ToString(rdr["URL"]);
                tempLink.LinkTitle = Convert.ToString(rdr["Title"]);
                linkList.Add(tempLink);
            }

            con.Close();

            return linkList;
        }

        public static void Add(Link link)
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand addCmd = new SqlCommand();
            addCmd.Connection = con;
            addCmd.CommandText = "INSERT INTO VideoLinks(URL, Title)" +
                "VALUES (@url, @title)";
            addCmd.Parameters.AddWithValue("@url", link.LinkURL);
            addCmd.Parameters.AddWithValue("@title", link.LinkTitle);

            try
            {
                con.Open();
                int rowsAffected = addCmd.ExecuteNonQuery();
            }
            finally
            {
                con.Dispose();
            }
        }
    }
}
