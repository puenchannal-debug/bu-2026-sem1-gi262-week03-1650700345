using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Item
    {
        public string name;
        private int value;
        public virtual void Use() => Debug.Log($"Used {name} (value: {value}).");
    }
}
