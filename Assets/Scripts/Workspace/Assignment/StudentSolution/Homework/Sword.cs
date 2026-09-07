using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Sword : Weapon
    {
        public int bladeLength;
        public void Slash() => Debug.Log($"{name} slashes.");
        public override void Equip() => Debug.Log($"Equipped sword {name}.");
        public override void DealDamage() => Debug.Log($"{name} slashes for {attackPower} damage.");
    }
}
