using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Orc : MeleeEnemy
    {
        public int rageLevel;
        public void Enrage()
        {
            rageLevel++;
            Debug.Log($"{name} is enraged! Rage level: {rageLevel}");
        }
    }
}
