using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Enemy : Entity
    {
        public int damage;
        protected int aiLevel;

        public virtual void Attack() => Debug.Log($"{name} attacks for {damage} damage.");
        protected virtual void Patrol() => Debug.Log($"{name} is patrolling.");
    }
}
