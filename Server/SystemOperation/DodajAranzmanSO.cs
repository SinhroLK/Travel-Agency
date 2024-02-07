using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.SystemOperation
{
    public class DodajAranzmanSO : SystemOperationBase
    {
        private readonly Aranzman a;
        public Aranzman Result
        {
            get; set;
        }
        public DodajAranzmanSO(Aranzman p)
        {
            this.a = p;
        }
        protected override void ExecuteConcreteOperation()
        {
            Result = broker.Kreiraj(a) as Aranzman;
            // MessageBox.Show($"{Result.AranzmanId}");
            foreach(ProlaznoMesto p in Result.prolaznaMesta)
            {
                p.Aranzman.AranzmanId = Result.AranzmanId;
                broker.Kreiraj(p);
            }
        }
    }
}
