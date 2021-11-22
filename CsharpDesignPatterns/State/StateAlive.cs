using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.State
{
    public class StateAlive : IMeetingState
    {
        public void IsMeetingOn(StateContext context, string room)
        {
            Console.WriteLine($"Meeting in process in room {room}");
        }
    }
}
