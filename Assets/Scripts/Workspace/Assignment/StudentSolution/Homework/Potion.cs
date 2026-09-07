using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Potion : Item
    {
        public int healingAmount;
        public override void Use() => Debug.Log($"Used {name} and restored {healingAmount} health.");
    }
}
