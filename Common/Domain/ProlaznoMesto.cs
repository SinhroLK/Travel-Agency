using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class ProlaznoMesto : IEntity
    {
        public Aranzman Aranzman { get; set; }
        public Mesto Mesto { get; set; }
        public int Satnica { get; set; }
        public bool Prenociste { get; set; }

        public string TableName => "ProlaznoMesto";
        public string Values => $"'{Aranzman.AranzmanId}', '{Mesto.MestoId}', '{Satnica}', '{(Prenociste ? 1 : 0)}'";
    }
}
