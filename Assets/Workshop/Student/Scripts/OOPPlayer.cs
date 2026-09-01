using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

// [Type 4.1.1] สืบทอดจาก Character (ลบตัวแปรพิกัดและชื่อที่ซ้ำซ้อนออก)
public class OOPPlayer : Character
{
    // [Type 4.1.2] ตัวแปรอ้างอิง InputAction สำหรับการเคลื่อนที่
    private InputAction moveAction;

    // [Type 4.1.3] ผูก Input Action และเรียกใช้งานเมธอดของคลาสแม่ใน Start
    public void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        PrintInfo();
        GetRemainEnergy();
    }

    // [Type 4.1.4] อ่านค่า Vector2 จาก Input System แล้วส่งต่อให้ Move ทำงาน
    public void Update()
    {
        Vector2 direction = moveAction.ReadValue<Vector2>();
        Move(direction);
    }

    // [Type 4.1.5] เมธอดโจมตีใส่ศัตรู
    public void Attack(OOPEnemy _enemy)
    {
        _enemy.energy -= AttackPoint;
        Debug.Log(_enemy.name + " is energy " + _enemy.energy);
    }

    // [Type 4.1.6] Override CheckDead ของคลาสแม่ พร้อมเพิ่มข้อความแจ้งเตือน
    protected override void CheckDead()
    {
        base.CheckDead(); // เรียกตรรกะการทำลายอ็อบเจกต์เดิมของคลาสแม่
        if (energy <= 0)
        {
            Debug.Log("Player is Dead");
        }
    }
}
