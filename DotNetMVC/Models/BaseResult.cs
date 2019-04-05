using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstDatabaseProject.Models
{
    public class BaseResult
    {
        public bool IsSuccess { get; set; }

        public object Data { get; set; }

        public string Message { get; set; }

        public int ErrorCode { get; set; }
    }
}