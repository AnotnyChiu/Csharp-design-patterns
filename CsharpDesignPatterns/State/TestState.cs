using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.State
{
    public static class TestState
    {
        public static void StateMain()
        {
            StateContext context = new StateContext();
            context.IsMeetingOn("Room 9F");
            // here the meeting should be at offline state

            // change the state
            context.SetState(new StateAlive());
            context.IsMeetingOn("Room 9F");
        }
    }
}
