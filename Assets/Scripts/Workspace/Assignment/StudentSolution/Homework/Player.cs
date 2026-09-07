using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Player : Entity
    {
        public int score;
        private Item[] items = new Item[0];

        public void CollectItem(Item item)
        {
            if (item == null) return;
            System.Array.Resize(ref items, items.Length + 1);
            items[items.Length - 1] = item;
            score++;
            Debug.Log($"{name} collected {item.name}");
        }

        protected void LevelUp()
        {
            health += 10;
            Debug.Log($"{name} leveled up!");
        }
    }
}
