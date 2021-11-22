using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.State
{
    public interface IMeetingState
    {
        void IsMeetingOn(StateContext context, string room);
    }
}
