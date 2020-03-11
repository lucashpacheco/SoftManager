using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace SoftManager.Models
{
    public class Register
    {
        [DisplayName("id")]
        public int? id { get; set; }
        [DisplayName("codigo")]
        public int codigo { get; set; }
        [DisplayName("nome")]
        public string nome { get; set; }
        [DisplayName("descricao")]
        public string descricao { get; set; }
        [DisplayName("valorentrada")]
        public float valorentrada { get; set; }
        [DisplayName("valorsaida")]
        public float valorsaida { get; set; }
        [DisplayName("qtd")]
        public int qtd { get; set; }
        [DisplayName("minimoqtd")]
        public int minimoqtd { get; set; }
        [DisplayName("desconto")]
        public float desconto { get; set; }
        //[DisplayName("valorsaida")]
       // public string valorsaida { get; set; }
    }
}
