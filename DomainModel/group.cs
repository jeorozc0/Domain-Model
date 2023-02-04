using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainModel
{
    public class group
    {
        private string groupName;
        private string groupMembers;
        assignment groupAssignment;

        public bool viewGroup(string username, string password)
        {
            //check if username and password are correct//
            //if so, view group//
            return true;
        }

        public bool viewGroupAssignment(string username, string password)
        {
            //check if username and password are correct//
            //if so, view group assignment//
            groupAssignment.viewAssignmentDetails(username, password);
            return true;
        }

        
        private bool leaveGroup(string username, string password)
        {
            //check if username and password are correct//
            //if so, leave group//
            return true;
        }
        
        
        private bool joinGroup(string username, string password)
        {
            //check if username and password are correct//
            //if so, join group//
            return true;
        }




    }
}