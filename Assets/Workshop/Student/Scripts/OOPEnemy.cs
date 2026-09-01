using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// [Type 4.2.1] สืบทอดจาก Character
public class OOPEnemy : Character
{
    // [Type 4.2.2] แสดงพลังงานคงเหลือเมื่อเริ่มเกม
    public void Start()
    {
        GetRemainEnergy();
    }

    // [Type 4.2.3] เมธอดโจมตีใส่ผู้เล่น
    public void Attack(OOPPlayer _player)
    {
        _player.energy -= AttackPoint;
        Debug.Log("player is energy " + _player.energy);
    }
}
