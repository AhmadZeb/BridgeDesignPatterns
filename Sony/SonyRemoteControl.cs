using BridgeDesignPatterns.Abstractions;
using BridgeDesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPatterns.Sony
{
    public class SonyRemoteControl : AbstractRemoteControl
    {
        //public SonyRemoteControl(ILEDTV ledTv): base(ledTv) { }
        public SonyRemoteControl(ILEDTV ledTv)         
        {
            this.ledTv = ledTv;
        }     
        public override void SetChannel(int channelNumber)
        {
            ledTv.SetChannel(channelNumber);
        }

        public override void SwitchOff()
        {
           ledTv.SwitchOff();
        }

        public override void SwitchOn()
        {
            ledTv?.SwitchOn();  
        }
    }
}
