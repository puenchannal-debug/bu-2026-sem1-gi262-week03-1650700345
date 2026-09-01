using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// [Type 3.3.1] สืบทอดจาก Identity
public class OOPExit : Identity
{
    // [Type 3.3.2] การอ้างอิงถึง GameObject หน้าต่าง UI ชัยชนะ (YouWin Panel)
    public GameObject YouWin;

    // [Type 3.3.3] การเขียนทับ (Override) ฟังก์ชัน Hit เพื่อจบเกมและแสดง UI ชัยชนะ
    public override void Hit()
    {
        mapGenerator.player.enabled = false; // ปิดการควบคุมผู้เล่น
        if (YouWin != null)
        {
            YouWin.SetActive(true); // เปิด UI YouWin
        }
        Debug.Log("You win");
    }
}
