﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Communication
{
    public enum Operation
    {
        Login,
        VratiMesta,
        KreirajMesto,
        VratiVodice,
        KreirajVodica,
        NadjiVodice,
        ObrisiVodica,
        KreirajSadrzaj,
        KreirajAranzman,
        VratiAranzmane,
        ObrisiAranzman,
        IzmeniAranzman,
        VratiTermine,
        KreirajTermin,
        ObrisiTermin,
        IzmeniTermin,
        Logout,
        VratiProlaznaMesta
    }
}
