using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP_NET_MVC_Q1.Models { 
    public class UserModel
    {
        [Required(ErrorMessage = "*此為必填欄位!")]
        [StringLength(20,MinimumLength =2,ErrorMessage ="至少需要2個字元")]
        public string name { set; get; }

        [Required(ErrorMessage = "請輸入手機號碼")]
        [RegularExpression(@"^\d{4}\-?\d{3}\-?\d{3}$",ErrorMessage="需為09xx-xxx-xxx")]
        public string phone { set; get; }

        [EmailAddress(ErrorMessage = "格式錯誤")]
        [Required(ErrorMessage ="請輸入Email")]      
        public string email { set; get; }

    }
}
