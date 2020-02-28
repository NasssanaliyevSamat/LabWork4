using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LectureRazor.Services
{
    public interface IFileService
    {
        string Send();

    }

    public class EmailSender : IFileService
    {
        public string Send()
        {
            return " message is sent by email";
        }
    }

    public class SmsSender : IFileService
    {
        public string Send()
        {
            return " sms is sent by sms";
        }
    }

}
