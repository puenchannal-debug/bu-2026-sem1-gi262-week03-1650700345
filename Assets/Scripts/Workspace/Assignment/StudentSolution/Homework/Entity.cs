using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Entity
    {
        public string name;
        private Vector3 position;
        protected int health;

        public virtual void Update()
        {
            Debug.Log($"{name} is at {position}");
        }

        protected virtual void TakeDamage(int damage)
        {
            health -= damage;
            Debug.Log($"{name} took {damage} damage. Health: {health}");
        }

        private void Move(Vector3 direction)
        {
            position += direction;
        }
    }
}
