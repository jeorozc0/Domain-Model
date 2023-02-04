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
        private int grades;
        private string comments;

        
        public bool viewAssignmentDetails(string username, string password)
        {
            //check if username and password are correct//
            //if so, view assignment details//
            return true;
        }
        
        public int viewAssignmentGrade(string username, string password)
        {
            //check if username and password are correct//
            //if so, view assignment grade//
            gradebook grade = new gradebook();
            grade.viewGrades(username, password);
            return grades;
        }
        
        private string leaveComment(string username, string password)
        {
            //check if username and password are correct//
            //if so, leave comment//
            return comments;
        }
        
        public bool uploadAssignment(string username, string password)
        {
            //check if username and password are correct//
            //if so, upload assignment//
            fileCanvas file = new fileCanvas();
            file.uploadFile(username, password);
            return true;
        }
        
    }
}