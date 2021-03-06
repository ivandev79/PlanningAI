using System.Collections.Generic;
using JetBrains.Annotations;
using PlanningAi.Planning;

namespace PlanningAi.Agents
{
    [PublicAPI]
    public interface IAgentGoal
    {
        string GoalName { get; }
        float GetGoalWeight(DomainState currentState);
        void OnActivation(ref DomainState currentState, ref DomainState goalState);
    }
}