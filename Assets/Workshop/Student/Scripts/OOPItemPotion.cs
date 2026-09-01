using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// [Type 3.2.1] สืบทอดจาก Identity
public class OOPItemPotion : Identity
{
    // [Type 3.2.2] คุณสมบัติของยาฟื้นฟู
    public int healPoint = 10;
    public bool isBonues;

    // [Type 3.2.3] สุ่มโอกาส 20% ที่จะเป็นยาโบนัส (เปลี่ยนสีเป็นสีฟ้า)
    private void Start()
    {
        isBonues = Random.Range(0, 100) < 20 ? true : false;
        if (isBonues)
        {
            GetComponent<SpriteRenderer>().color = Color.blue;
        }
    }

    // [Type 3.2.4] การเขียนทับ (Override) ฟังก์ชัน Hit เพื่อเพิ่มพลังงานให้ผู้เล่น
    public override void Hit()
    {
        if (isBonues)
        {
            mapGenerator.player.Heal(healPoint, isBonues);
            Debug.Log("You got " + Name + " Bonues : " + (healPoint * 2));
        }
        else
        {
            mapGenerator.player.Heal(healPoint);
            Debug.Log("You got " + Name + " : " + healPoint);
        }

        // เคลียร์ข้อมูลตำแหน่งบนตารางแผนที่ และทำลายไอเทมทิ้ง
        mapGenerator.mapdata[positionX, positionY] = mapGenerator.empty;
        Destroy(gameObject);
    }
}