using UnityEngine;

namespace Assignment.StudentSolution
{
    public class MeleeEnemy : Enemy
    {
        public int strength;
        public override void Attack() => Debug.Log($"{name} performs a melee attack for {damage + strength} damage.");
    }
}
