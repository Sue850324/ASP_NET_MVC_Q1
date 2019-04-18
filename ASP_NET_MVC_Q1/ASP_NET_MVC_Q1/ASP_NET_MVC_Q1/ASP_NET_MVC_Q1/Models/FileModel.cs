using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP_NET_MVC_Q1.Models{
    public class FileModel
    {
        [Required(ErrorMessage = "*此為必填欄位!")]
        public string fileName { set; get; }
    }
}
