using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static mod4_103022300052.FanLaptop;

namespace mod4_103022300052
{

    public class FanLaptop
    {
        public enum State { Quiet, Balanced, Performanced, Turbo }
        public enum Mode { ModeUp, ModeDown, TurboShorcut }

        public class transition
        {
            public State prevState;
            public State nextState;
            public Mode mode;
            public transition(State prevState, State nextState, Mode mode)
            {
                this.prevState = prevState;
                this.nextState = nextState;
                this.mode = mode;
            }
        }
        public State currentState = State.Quiet;
        public State getNextState(State prevState, Mode mode)
        {
            State state = prevState;
            for (int i = 0; i < transitions.Length; i++)
            {
                if (transitions[i].prevState == prevState && transitions[i].mode == mode)
                {
                    return transitions[i].nextState;
                }
            }
            return prevState;
        }

        public void activateMode(Mode mode)
        {
            Console.Write("Fan: " + currentState);
            State nextState = getNextState(currentState, mode);
            currentState = nextState;
           Console.WriteLine(" Berubah menjadi " + currentState);
        }

        public FanLaptop()
        {

        }

        public FanLaptop(State prevState, State nextState, Mode mode)
        {

        }

        transition[] transitions =
        {
            new transition(State.Quiet, State.Balanced, Mode.ModeUp ),
            new transition(State.Balanced, State.Performanced, Mode.ModeUp ),
            new transition(State.Performanced, State.Turbo, Mode.ModeUp ),
            new transition(State.Turbo, State.Quiet, Mode.TurboShorcut ),
            new transition(State.Quiet, State.Turbo, Mode.TurboShorcut ),
            new transition(State.Turbo, State.Performanced, Mode.ModeDown ),
            new transition(State.Performanced, State.Balanced, Mode.ModeDown ),
            new transition(State.Balanced, State.Quiet, Mode.ModeDown ),



        };
  
    }
}
        
