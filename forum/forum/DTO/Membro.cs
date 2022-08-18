using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO
{
    public class Membro
    {
        private int idMembro;
        private string nomeMembro, nickMembro, emailMembro, senhaMembro;

        public int IdMembro { get => idMembro; set => idMembro = value; }
        public string NomeMembro { get => nomeMembro; set => nomeMembro = value; }
        public string NickMembro { get => nickMembro; set => nickMembro = value; }
        public string EmailMembro { get => emailMembro; set => emailMembro = value; }
        public string SenhaMembro { get => senhaMembro; set => senhaMembro = value; }




    }
}