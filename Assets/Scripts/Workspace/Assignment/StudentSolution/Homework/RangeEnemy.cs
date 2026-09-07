using UnityEngine;

namespace Assignment.StudentSolution
{
    public class RangeEnemy : Enemy
    {
        public int range;
        public override void Attack() => Debug.Log($"{name} performs a ranged attack from {range} units away.");
    }
}
