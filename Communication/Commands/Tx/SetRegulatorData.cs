using System;
using System.Collections.Generic;
using System.Text;

namespace KFly.Communication
{
    class SetRegulatorData : KFlyCommand
    {
        private RegulatorData _data;

        public SetRegulatorData(RegulatorData data) : base(Command.SetRegulatorData)
        {
            _data = data;
        }

        protected override List<Byte> GetData()
        {
            return _data.ToBytes();
        }
    }
}
