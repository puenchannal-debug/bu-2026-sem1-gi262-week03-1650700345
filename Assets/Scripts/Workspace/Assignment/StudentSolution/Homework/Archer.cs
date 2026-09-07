using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Archer : RangeEnemy
    {
        public int accuracy;
        public override void Attack() => Debug.Log($"{name} shoots with {accuracy}% accuracy.");
        public void AimAndShoot() => Debug.Log($"{name} aims and shoots.");
    }
}
