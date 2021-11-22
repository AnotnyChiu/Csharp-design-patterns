using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.State
{
    public class StateContext
    {
        private IMeetingState _currentState;

        // defind a method to set the default state (but not in contructor)
        public void SetState(IMeetingState newState)
        {
            _currentState = newState;
        }

        // and in constructor set the default state using the method
        public StateContext()
        {
            // set default to offline
            SetState(new StateOffLine());
        }

        public void IsMeetingOn(string room)
        {
            // notice! the method here can take itself
            // so when it's state is changed, the outcome of the method will also change
            // and to change the state just call the method SetState.
            _currentState.IsMeetingOn(this, room);
        }
    }
}
