using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestAnalyser.Models.Modelos
{
    public class Dissertativa
    {

        //[Key]
        public int diss_id { get; set; }
        
        public string diss_questao { get; set; }
        
        public string diss_respostaCerta { get; set; }
        
        public RespDissAluno diss_repostaAluno { get; set; }
        
    }
}