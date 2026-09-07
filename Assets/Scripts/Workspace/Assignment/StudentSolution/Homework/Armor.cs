using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Armor : Equipment
    {
        public int defense;
        public override void Equip() => Debug.Log($"Equipped armor {name} with {defense} defense.");
    }
}
