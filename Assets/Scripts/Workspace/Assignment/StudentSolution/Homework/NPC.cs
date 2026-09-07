using UnityEngine;

namespace Assignment.StudentSolution
{
    public class NPC : Entity
    {
        public string dialogue;
        private bool isFriendly;
        public virtual void Interact() => Debug.Log(isFriendly ? dialogue : $"{name} does not want to talk.");
    }
}
