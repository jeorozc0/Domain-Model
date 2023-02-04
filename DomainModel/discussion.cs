using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainModel
{
    public class discussion:assignment
    {
        private string title;
        private string description;
        private string comments;
        private string course;
        private string id;


        
        public bool viewComments(string username, string password)
        {
            //check if username and password are correct//
            //if so, view comments//
            return comments;
        }

        
        public bool leaveComment(string username, string password)
        {
            //check if username and password are correct//
            //if so, leave comment//
            return comments;
        }



    }
}