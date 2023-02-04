using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainModel
{
    public class file
    {
        private string fileName;
        private string fileType;
        private string fileDescription;
        private int fileID;
        private int fileSize;
        private string fileOwner;
        private DateTime fileDate;
        private string fileUrl;

        
        public bool uploadFile(string fileUrl, string fileName, string fileType, string fileDescription, int fileSize, string fileOwner, DateTime fileDate)
        {
            //check if username and password are correct//
            //if so, upload file//
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