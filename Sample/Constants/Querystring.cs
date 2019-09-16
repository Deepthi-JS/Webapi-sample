using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample.Constants
{
    public class Querystring
    {
        public string GetCountries = "SELECT country_name FROM datamask.dbo.country_master";
        public string GetStates = @"SELECT state_name FROM datamask.dbo.state_master SM 
        inner join datamask.dbo.country_master CM  on SM.country_id = CM.country_id where CM.country_name = @country_name";
        public string GetCities = @"SELECT city_name FROM datamask.dbo.city_master CM
        inner join datamask.dbo.state_master SM  on CM.state_id = SM.state_id where SM.state_name = @state_name";
        public string GetLocation = @"SELECT Name FROM datamask.dbo.Area_master AM
        inner join datamask.dbo.city_master CM  on AM.city_id= CM.City_id where CM.city_name = @city_name;";
    }
}