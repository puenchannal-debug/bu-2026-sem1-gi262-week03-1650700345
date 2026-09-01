using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// OOPWall aka "Demon Wall"
// [Type 3.1.1] สืบทอดจาก Identity (ลบตัวแปรพิกัดและชื่อที่ซ้ำซ้อนออก)
public class OOPWall : Identity
{
    // [Type 3.1.2] คุณสมบัติเฉพาะของกำแพงปิศาจ
    public int Damage;
    public bool IsIceWall;

    // [Type 3.1.3] สุ่มโอกาส 20% ที่จะเป็นกำแพงน้ำแข็ง (เปลี่ยนสีเป็นสีฟ้า)
    private void Start()
    {
        IsIceWall = Random.Range(0, 100) < 20 ? true : false;
        if (IsIceWall)
        {
            GetComponent<SpriteRenderer>().color = Color.blue;
        }
    }

    // [Type 3.1.4] การเขียนทับ (Override) ฟังก์ชัน Hit เพื่อสร้างความเสียหาย/แช่แข็งผู้เล่น
    public override void Hit()
    {
        if (IsIceWall)
        {
            mapGenerator.player.TakeDamage(Damage, IsIceWall);
        }
        else
        {
            mapGenerator.player.TakeDamage(Damage);
        }

        // เคลียร์ข้อมูลตำแหน่งบนตารางแผนที่ และทำลาย GameObject กำแพงทิ้ง
        mapGenerator.mapdata[positionX, positionY] = mapGenerator.empty;
        Destroy(gameObject);
    }
}