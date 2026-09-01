using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// [Type 1.1] คลาสแม่สืบทอดจาก MonoBehaviour
public class Identity : MonoBehaviour
{
    [Header("Identity")]
    public string Name;
    public int positionX;
    public int positionY;
    public OOPMapGenerator mapGenerator;

    // [Type 1.2] เมธอดแสดงข้อมูลอัตลักษณ์ของวัตถุ
    public void PrintInfo()
    {
        Debug.Log("tell me your " + Name);
    }

    // [Type 1.3] Virtual method เปิดให้คลาสลูกนำไป override พฤติกรรมเมื่อเกิดการชน/มีปฏิสัมพันธ์
    public virtual void Hit()
    {
        // ค่าเริ่มต้นปล่อยว่างไว้ เพื่อให้คลาสลูกนำไปเขียนการทำงานทับตามหน้าที่ของตนเอง
    }
}