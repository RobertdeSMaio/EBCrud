using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_.Domains.ModelViews
{
    public struct Home //add mensagem para a API
    {
        public string Mensagem {get => "Bem-vindo a API";}
        public string Doc {get => "/swagger";}
    }
}