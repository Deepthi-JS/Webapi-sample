using Sample.Constants;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using System.Web;

namespace Sample.Services
{
    public class GetAddress
    {
        public List<String> GetCountries()
        {
            Querystring objcons = new Querystring();

            string Query = objcons.GetCountries;
            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

                using (SqlConnection cnn = new SqlConnection(connStr))
                {
                    cnn.Open();
                    var x = cnn.Query<String>(Query);
                    cnn.Close();
                    return x.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public List<String> GetState(string country_name)
        {
            Querystring objcons = new Querystring();
            var dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("country_name", country_name);

            string Query = objcons.GetStates;
            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

                using (SqlConnection cnn = new SqlConnection(connStr))
                {
                    cnn.Open();
                    var x = cnn.Query<String>(Query, dynamicParameters);
                    cnn.Close();
                    return x.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<String> GetCities(string state_name)
        {
            Querystring objcons = new Querystring();
            var dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("state_name", state_name);

            string Query = objcons.GetCities;
            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

                using (SqlConnection cnn = new SqlConnection(connStr))
                {
                    cnn.Open();
                    var x = cnn.Query<String>(Query, dynamicParameters);
                    cnn.Close();
                    return x.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<String> GetArea(string city_name)
        {
            Querystring objcons = new Querystring();
            var dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("city_name", city_name);

            string Query = objcons.GetLocation;
            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

                using (SqlConnection cnn = new SqlConnection(connStr))
                {
                    cnn.Open();
                    var x = cnn.Query<String>(Query, dynamicParameters);
                    cnn.Close();
                    return x.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}