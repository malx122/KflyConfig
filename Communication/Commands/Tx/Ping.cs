using System;
using System.Collections.Generic;
using System.Text;

namespace KFly.Communication
{
    public class Ping : KFlyCommand
    {
        public Ping() : base(Command.Ping)
        {
        }
    }
}
