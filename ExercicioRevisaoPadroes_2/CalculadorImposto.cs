﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRevisaoPadroes_2
{
    public interface CalculadorImposto
    {
        double CalcularImposto(Produto umProduto, Usuario umUsuario);
    }
}
