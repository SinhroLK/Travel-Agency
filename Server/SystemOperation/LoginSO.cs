using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    public class LoginSO : SystemOperationBase
    {
        private readonly Admin user;
        public Admin Result { get; set; }

        public LoginSO(Admin user)
        {
            this.user = user;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.Login(user);
        }
    }
}
