using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Mage : RangeEnemy
    {
        public int mana;
        public override void Attack() => Debug.Log($"{name} attacks with magic.");
        public void CastSpell()
        {
            if (mana <= 0) { Debug.Log($"{name} does not have enough mana."); return; }
            mana--;
            Debug.Log($"{name} casts a spell.");
        }
    }
}
