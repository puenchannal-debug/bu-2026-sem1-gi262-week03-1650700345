using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Weapon : Equipment
    {
        public int attackPower;
        public virtual void DealDamage() => Debug.Log($"{name} deals {attackPower} damage.");
    }
}
