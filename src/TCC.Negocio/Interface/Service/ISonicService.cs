﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Negocio.Entidade;

namespace TCC.Negocio.Interface.Service
{
    public interface ISonicService
    {
        void CadastrarRegistro(CatalogoPodcast catalogoPodcast);
        IEnumerable<CatalogoPodcast> Consultar(string termo);
    }
}
