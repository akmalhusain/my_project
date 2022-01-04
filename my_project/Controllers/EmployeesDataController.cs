using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace my_project.Controllers
{
    public class EmployeesDataController : ApiController
    {

        public string[] myEmployees = { "akmal", "ajmal", "sadiya", "foziya", "srk", "aayat" };
       
        public string[] GetEmployees()
        {
            return myEmployees;
        }
        public string GetEmployeesByIndex( int id)
        {
            return myEmployees[id];
        }

    }
}
