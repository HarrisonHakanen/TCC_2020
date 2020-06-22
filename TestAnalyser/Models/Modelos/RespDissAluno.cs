using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestAnalyser.Models.Modelos
{
    public class RespDissAluno
    {

        //[Key]
        public int resp_diss_id { get; set; }
        
        public int diss_id { get; set; }
        
        public string resp_aluno { get; set; }
        
    }
}