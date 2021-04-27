using System;
using System.Collections.Generic;
using System.Linq;

using Abstra_oGen_rica.Models;
using Microsoft.EntityFrameworkCore;
namespace Abstra_oGen_rica.Database
{
     interface ICrudAluno
    {
        List<IGrouping<string, TbAluno>> AgruparPorTurma();
    }
}