using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainModel
{
    public class assignment
    {
        private string name;
        private string description;
        private DateTime dueDate;
        private DateTime dateAssigned;
        private int grade;
        private string comments;

        
        public bool viewAssignmentDetails(string username, string password)
        {
            //check if username and password are correct//
            //if so, view assignment details//
            return true;
        }
        
        public bool viewAssignmentGrade(string username, string password)
        {
            //check if username and password are correct//
            //if so, view assignment grade//
            grade = gradebook.viewGrades(username, password);
            return grade;
        }
        
        private bool leaveComment(string username, string password)
        {
            //check if username and password are correct//
            //if so, leave comment//
            return comments;
        }
        
        public bool uploadAssignment(string username, string password)
        {
            //check if username and password are correct//
            //if so, upload assignment//
            file file = new file();
            file.uploadFile(username, password);
            return true;
        }
        
    }
}