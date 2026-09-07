using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Bow : Weapon
    {
        public int range;
        public void Shoot() => Debug.Log($"{name} shoots an arrow.");
        public override void Equip() => Debug.Log($"Equipped bow {name}.");
        public override void DealDamage() => Debug.Log($"{name} shoots for {attackPower} damage.");
    }
}
