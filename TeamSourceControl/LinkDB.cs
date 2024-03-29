﻿using System;
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

            string query = "SELECT LinkId , URL, Title " +
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
                tempLink.LinkTitle = Convert.ToString(rdr["Title"]);
                tempLink.LinkURL = Convert.ToString(rdr["URL"]);
                tempLink.LinkId = Convert.ToInt32(rdr["LinkId"]);
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
            addCmd.CommandText = "INSERT INTO VideoLinks(Title, URL)" +
                "VALUES (@title, @url)";
            addCmd.Parameters.AddWithValue("@title", link.LinkTitle);
            addCmd.Parameters.AddWithValue("@url", link.LinkURL);

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

        public static void Update(Link l)
        {
            SqlConnection con = DBHelper.GetConnection();
            SqlCommand updateCmd = new SqlCommand();
            updateCmd.Connection = con;
            updateCmd.CommandText = "UPDATE VideoLinks " +
                "SET Title = @title, " +
                "URL = @url " +
                "WHERE LinkId = @lid";
            updateCmd.Parameters.AddWithValue("@title", l.LinkTitle);
            updateCmd.Parameters.AddWithValue("@url", l.LinkURL);
            updateCmd.Parameters.AddWithValue("@lid", l.LinkId);

            try
            {
                con.Open();
                int affectedrows = updateCmd.ExecuteNonQuery();
            }
            finally 
            {

                con.Dispose();
            }
        }

        public static bool Delete(string title)
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand delCmd = new SqlCommand();
            delCmd.Connection = con;
            delCmd.CommandText = "DELETE FROM VideoLinks WHERE Title = @title";
            delCmd.Parameters.AddWithValue("@title", title);

            try
            {
                con.Open();
                int rowsAffected = delCmd.ExecuteNonQuery();
                return (rowsAffected == 1) ? true : false;
            }
            finally
            {
                con.Dispose();
            }
        }
    }
}
