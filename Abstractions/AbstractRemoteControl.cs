using BridgeDesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPatterns.Abstractions
{
    public abstract class AbstractRemoteControl
    {
        protected ILEDTV ledTv;
        //public AbstractRemoteControl(ILEDTV lEDTV)
        //{
        //    this.ledTv = lEDTV;
        //}
        public abstract void SwitchOn();
        public abstract void SwitchOff();
        public abstract void SetChannel(int channelNumber);
    }
}
