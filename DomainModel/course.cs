using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainModel
{
    public class course
    {
        private string courseName;
        private string courseCode;
        private string courseDescription;
        private string courseTeacher;
        private int courseID;
        private DateTime startDate;
        private DateTime endDate;

        
        public bool viewCourse(string username, string password, int courseID)
        {
            //check if username and password are correct//
            //if so, view course//
            return true;
        }
        
        public bool enrollInCourse(string username, string password, int courseID)
        {
            //check if username and password are correct//
            //if so, enroll in course//
            return true;
        }
        
        public bool viewSyllabus(string username, string password)
        {
            //check if username and password are correct//
            //if so, view syllabus//
            return true;
        }
        
        public bool viewAssignments(string username, string password)
        {
            //check if username and password are correct//
            //if so, view assignments//
            assignment assignment = new assignment();
            assignment.viewAssignmentDetails(username, password);
            return true;
        }
        
        public bool viewGrades(string username, string password)
        {
            //check if username and password are correct//
            //if so, view grades//
            gradebook gradebook = new gradebook();
            return true;
        }
        
        public bool viewStudents(string username, string password)
        {
            //check if username and password are correct//
            //if so, view students//
            student student = new student();
            student.viewStudentDetails(username);
            return true;
        }
        
        public bool viewModules(string username, string password)
        {
            //check if username and password are correct//
            //if so, view modules//
            return true;
        }
        public bool viewMaterials(string username, string password)
        {
            //check if username and password are correct//
            //if so, view materials//
            return true;
        }
        public bool viewFile(string username, string password, string fileUrl)
        {
            fileCanvas file = new fileCanvas();
            file.downloadFile(fileUrl);
        

            return true;
        }
    }
}