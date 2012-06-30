using System;
using System.Collections.Generic;
using System.Text;

namespace KFly.Communication
{
    public class StartRCCalibration : KFlyCommand
    {
        public StartRCCalibration() : base(Command.StartRCCalibration)
        {
        }
    }
}
