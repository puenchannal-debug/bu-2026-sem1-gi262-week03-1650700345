using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Equipment : Item
    {
        public virtual void Equip() => Debug.Log($"Equipped {name}.");
    }
}
