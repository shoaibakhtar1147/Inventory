﻿using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Data.Common;


namespace CashandCarry
{
    public sealed class DB
    {
        public static string ConnectionString
        {
            get
            {
                return @"Data Source=SHOAIB-PC\SQLEXPRESS;Database=CashCarry;integrated security=true";
            }
        }

        public static int insert(string query)
        {

            string constring = ConnectionString;
            SqlConnection con = new SqlConnection(constring);
            try
            {

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                int rowaffected = cmd.ExecuteNonQuery();
                con.Close();
                return rowaffected;
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        
      
        public static string SelectScalerWithSP(string spName,SqlParameter[]prm)
        {
            string constring = ConnectionString;
            try
            {
                SqlConnection cn = new SqlConnection(constring);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = spName;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                if (prm != null)
                {
                    cmd.Parameters.AddRange(prm);
                }
                cn.Open();
                string value = Convert.ToString(cmd.ExecuteScalar());
                cn.Close();

                return value;
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        public static int ExecuteNonQueryWithSP(string spName, SqlParameter[] prm)
        {
            string constring = ConnectionString;
            //SqlConnection con = new SqlConnection();
            SqlConnection cn = new SqlConnection(constring);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = spName;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                cmd.Parameters.AddRange(prm);
                cn.Open();
                int rowaffected = cmd.ExecuteNonQuery();
                cn.Close();
                return rowaffected;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static DataTable Select(string query)
        {
            string constring = ConnectionString;
            try
            {

                SqlConnection con = new SqlConnection(constring);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adt.Fill(ds);
                DataTable dt = ds.Tables[0];
                return dt;

            }
            catch (Exception)
            {
                return null;
            }

        }
        public static DataTable SelectTableWithSP(string spName,SqlParameter[] prm)
        {
            string constring = ConnectionString;
            try
            {
                SqlConnection cn = new SqlConnection(constring);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = spName;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                if (prm != null)
                {
                    cmd.Parameters.AddRange(prm);
                }
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adt.Fill(ds);
                DataTable dt = ds.Tables[0];
                return dt;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
        

    }
}
