using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Staff : Weapon
    {
        public int magicPower;
        public void CastSpell() => Debug.Log($"{name} casts a spell with {magicPower} magic power.");
        public override void Equip() => Debug.Log($"Equipped staff {name}.");
        public override void DealDamage() => Debug.Log($"{name} deals {attackPower + magicPower} magic damage.");
    }
}
