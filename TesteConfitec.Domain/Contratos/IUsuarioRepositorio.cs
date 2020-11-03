using System;
using System.Collections.Generic;
using System.Text;
using Alisson.QuickBuy.Dominio.Entidades;

namespace TesteConfitec.Dominio.Contratos
{
    public interface IUsuarioRepositorio: IBaseRepositorio<Usuario>
    {
        Usuario Obter(string email, string senha);
        Usuario Obter(string email);
    }
}
