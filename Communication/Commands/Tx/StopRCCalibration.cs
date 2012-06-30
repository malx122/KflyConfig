using System;
using System.Collections.Generic;
using System.Text;

namespace KFly.Communication
{
    public class StopRCCalibration : KFlyCommand
    {
        public StopRCCalibration() : base(Command.StopRCCalibration)
        {
        }
    }
}
