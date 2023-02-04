using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainModel
{
    public class inbox
    {
        private string bodyMessage;
        private string userSender;
        private string userReceiver;
        private datetime messageDate;
        private int messageID;
        private File attachment;

        
        public bool sendMessage(string username, string password)
        {
            //check if username and password are correct//
            //if so, send message//
            return true;
        }
        
        private bool deleteMessage(string username, string password)
        {
            //check if username and password are correct//
            //if so, delete message//
            return true;
        }
        
        public bool viewMessage(string username, string password)
        {
            //check if username and password are correct//
            //if so, view message//
            return true;
        }
        
        public bool viewAttachment(string username, string password)
        {
            //check if username and password are correct//
            //if so, view attachment//
            file attachment = new file();
            file.viewFile(username, password);
            return true;
        }
        
        private bool downloadAttachment(string username, string password)
        {
            //check if username and password are correct//
            //if so, download attachment//
            file attachment = new file();
            file.downloadFile(username, password);
            return true;
        }
        
        public bool respondToEmail(string username, string password)
        {
            //check if username and password are correct//
            //if so, respond to email//
            return true;
        }
        
        private bool archiveMessage(string username, string password)
        {
            //check if username and password are correct//
            //if so, archive message//
            return true;
        }
    }
}