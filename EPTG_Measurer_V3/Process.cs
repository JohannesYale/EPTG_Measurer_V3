using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPTG_Measurer_V3
    {
    using System;
    using System.Collections.Generic;

    public enum ProcessState
        {
        GetImageFolder,
        Condyles,
        TrochleaGrove,
        Endoint,
        TransitionPoint,
        Angles,
        Finished
        }

    public enum Command
        {
        Begin,
        Restart,
        Confirm,
        Drawn,
        Done,
        }

    public class Process
        {
        public event EventHandler StateChanged;
        class StateTransition
            {
            readonly ProcessState CurrentState;
            readonly Command Command;

            public StateTransition(ProcessState currentState, Command command)
                {
                CurrentState = currentState;
                Command = command;
                }

            public override int GetHashCode()
                {
                return 17 + 31 * CurrentState.GetHashCode() + 31 * Command.GetHashCode();
                }

            public override bool Equals(object obj)
                {
                StateTransition other = obj as StateTransition;
                return other != null && this.CurrentState == other.CurrentState && this.Command == other.Command;
                }
            }

        Dictionary<StateTransition, ProcessState> transitions;
        public ProcessState CurrentState { get; set; }

        public Process()
            {
            CurrentState = ProcessState.GetImageFolder;
            transitions = new Dictionary<StateTransition, ProcessState>
            {
                { new StateTransition(ProcessState.GetImageFolder, Command.Begin), ProcessState.Condyles },
                { new StateTransition(ProcessState.Condyles, Command.Confirm), ProcessState.TrochleaGrove },
                { new StateTransition(ProcessState.TrochleaGrove, Command.Confirm), ProcessState.Endoint },
                { new StateTransition(ProcessState.Endoint, Command.Confirm), ProcessState.TransitionPoint },
                { new StateTransition(ProcessState.TransitionPoint, Command.Confirm), ProcessState.Angles },
                { new StateTransition(ProcessState.TrochleaGrove, Command.Restart), ProcessState.Condyles },
                { new StateTransition(ProcessState.Endoint, Command.Restart), ProcessState.Condyles },
                { new StateTransition(ProcessState.TransitionPoint, Command.Restart), ProcessState.Condyles },
                { new StateTransition(ProcessState.Angles, Command.Confirm), ProcessState.Condyles },
                { new StateTransition(ProcessState.Angles, Command.Done), ProcessState.Finished }
            };
            }

        public ProcessState GetNext(Command command)
            {
            StateTransition transition = new StateTransition(CurrentState, command);
            ProcessState nextState;
            if (!transitions.TryGetValue(transition, out nextState))
                throw new Exception("Invalid transition: " + CurrentState + " -> " + command);
            return nextState;
            }

        public ProcessState MoveNext(Command command)
            {
            CurrentState = GetNext(command);
            StateChanged.Invoke(this, new EventArgs());
            return CurrentState;
            }
        }
    }

