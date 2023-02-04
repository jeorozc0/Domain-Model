using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainModel
{
    public class fileCanvas
    {
        private string fileName;
        private string fileType;
        private string fileDescription;
        private int fileID;
        private int fileSize;
        private string fileOwner;
        private DateTime fileDate;
        private string fileUrl;

        
        public bool uploadFile(string username, string password)
        {

            //check if username and password are correct//
            //if so, upload file//
            string fileUrl = "C:\\";
            string fileName = "test"; 
            string fileType = "txt"; 
            string fileDescription  = "test";
            int fileSize = 1; 
            string fileOwner = "test"; 
            DateTime fileDate = DateTime.Now;
            createFile(fileUrl, fileName, fileType, fileDescription, fileSize, fileOwner, fileDate);
            return true;
        }

        private bool createFile(string fileUrl, string fileName, string fileType, string fileDescription, int fileSize, string fileOwner, DateTime fileDate)
        {
            //check if username and password are correct//
            //if so, edit file//
            return true;
        }
        
        public bool downloadFile(string fileUrl)
        {
            //check if username and password are correct//
            //if so, download file//
            return true;
        }
        
        public bool deleteFile(string fileUrl)
        {
            //check if username and password are correct//
            //if so, delete file//
            return true;
        }

        public bool viewFile(string fileUrl)
        {
            //check if username and password are correct//
            //if so, view file//
            return true;
        }




    }
}