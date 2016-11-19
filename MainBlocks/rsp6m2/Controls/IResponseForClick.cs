using System;
using System.Collections.Generic;
using System.Text;

namespace rsp6m2.Controls
{
    public interface IResponseForClick
    {
        
        event SomeEventDelegate ValueChanged;
        void OnValueChanged(SomeEventArgs e);

    }
    public delegate void SomeEventDelegate(SomeEventArgs e);
    public class SomeEventArgs : EventArgs
    {
        //public int newValue;
        public String SenderName;
        public SomeEventArgs(String SenderName)
        {
            //this.newValue = value;
            this.SenderName = SenderName;
        }
    }

    public class SomeEventArgsTumbler:SomeEventArgs
    {
        public Position tumblerPosition;
        public SomeEventArgsTumbler(String SenderName, Position pos):base(SenderName)
        {
            tumblerPosition = pos;
        }
    }

    public class SomeEventArgsTumblerRound : SomeEventArgs
    {
        public int tumblerPosition;
        public SomeEventArgsTumblerRound(String SenderName, int pos) : base(SenderName)
        {
            tumblerPosition = pos;
        }
    }
}
