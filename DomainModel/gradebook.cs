using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainModel
{
    public class gradebook
    {
        private int id;
        private string user;
        private string courseName;
        private int grade;
        private string assignmentName;
        private string comments;
        private int newGrade;

        
        public int viewGrades(string username, string password)
        {
            //check if username and password are correct//
            //if so, view grades//
            return grade;
        }
        
        public string viewComments(string username, string password)
        {
            //check if username and password are correct//
            //if so, view comments//
            return comments;
        }
        
        public int editGrades(string username, string password)
        {
            //check if username and password are correct//
            //if so, edit grades//
            return newGrade;
        }
    }
}