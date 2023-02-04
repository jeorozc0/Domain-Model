using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainModel
{
    public class calendar
    {
        private DateTime date;
        private string events;
        private string course;
        private string assignment;
        private string description;

        public bool viewCalendar(string username, string password)
        {
            //check if username and password are correct//
            //if so, view calendar//
            return true;
        }
        public bool viewEvents(string username, string password)
        {
            //check if username and password are correct//
            //if so, view events//
            return true;
        }
    }
}