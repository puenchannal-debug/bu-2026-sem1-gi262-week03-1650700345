using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Troll : MeleeEnemy
    {
        public int regenerationRate;
        public void Regenerate()
        {
            health += regenerationRate;
            Debug.Log($"{name} regenerated {regenerationRate} health.");
        }
    }
}
