using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// [Type 2.1] สืบทอดคุณสมบัติจาก Identity แทน MonoBehaviour
public class Character : Identity
{
    // [Type 2.2] ตัวแปรเฉพาะของตัวละครและการห่อหุ้มสถานะภายใน (Encapsulation)
    [Header("Character")]
    public int energy;
    public int AttackPoint;

    protected bool isAlive;
    protected bool isFreeze;

    // [Type 2.3] เมธอดช่วยเหลือระดับ protected เพื่อแสดงพลังงานคงเหลือ
    protected void GetRemainEnergy()
    {
        Debug.Log(Name + " : " + energy);
    }

    #region Combat & Overloading
    // [Type 2.4] Overloaded TakeDamage เวอร์ชันปกติ (รับความเสียหายอย่างเดียว)
    public virtual void TakeDamage(int Damage)
    {
        energy -= Damage;
        Debug.Log(Name + " Current Energy : " + energy);
        CheckDead();
    }

    // [Type 2.5] Overloaded TakeDamage เวอร์ชันพิเศษ (รับความเสียหาย + ติดสถานะแช่แข็ง)
    public virtual void TakeDamage(int Damage, bool freeze)
    {
        energy -= Damage;
        isFreeze = freeze;
        GetComponent<SpriteRenderer>().color = Color.blue;
        Debug.Log(Name + " Current Energy : " + energy);
        Debug.Log("you is Freeze");
        CheckDead();
    }

    // [Type 2.6] Overloaded Heal เวอร์ชัน 1 พารามิเตอร์ (ส่งต่อให้เวอร์ชัน 2 พารามิเตอร์ทำงานแทนตามหลัก DRY)
    public void Heal(int healPoint)
    {
        Heal(healPoint, false);
    }

    // [Type 2.7] Overloaded Heal เวอร์ชัน 2 พารามิเตอร์ (รองรับการคูณสองกรณีได้โบนัส)
    public void Heal(int healPoint, bool Bonuse)
    {
        energy += healPoint * (Bonuse ? 2 : 1);
        Debug.Log("Current Energy : " + energy);
    }

    // [Type 2.8] ตรวจสอบว่าพลังงานหมดหรือไม่ เพื่อทำลายอ็อบเจกต์
    protected virtual void CheckDead()
    {
        if (energy <= 0)
        {
            Destroy(gameObject);
        }
    }
    #endregion

    #region Map Helper Queries
    // [Type 2.9] ฟังก์ชันสืบค้นข้อมูลช่องตารางจาก mapGenerator
    public bool HasPlacement(int x, int y)
    {
        var mapData = mapGenerator.GetMapData(x, y);
        return mapData != mapGenerator.empty;
    }

    public bool IsDemonWalls(int x, int y)
    {
        var mapData = mapGenerator.GetMapData(x, y);
        return mapData == mapGenerator.demonWall;
    }

    public bool IsPotion(int x, int y)
    {
        var mapData = mapGenerator.GetMapData(x, y);
        return mapData == mapGenerator.potion;
    }

    public bool IsPotionBonus(int x, int y)
    {
        var mapData = mapGenerator.GetMapData(x, y);
        return mapData == mapGenerator.potion;
    }

    public bool IsExit(int x, int y)
    {
        var mapData = mapGenerator.GetMapData(x, y);
        return mapData == mapGenerator.exit;
    }
    #endregion

    #region Movement & Interaction Dispatch
    // [Type 2.10] เมธอดการเคลื่อนที่และการประมวลผลการชนบนกริด
    public virtual void Move(Vector2 direction)
    {
        // 1. กลไกแช่แข็ง: สละ 1 เทิร์นเพื่อละลายน้ำแข็งกลับเป็นสีขาว แล้วหยุดการเดินในรอบนี้
        if (isFreeze == true)
        {
            GetComponent<SpriteRenderer>().color = Color.white;
            isFreeze = false;
            return;
        }

        int toX = (int)(positionX + direction.x);
        int toY = (int)(positionY + direction.y);

        // 2. ตรวจสอบว่าช่องปลายทางมีวัตถุขวางอยู่หรือไม่
        if (HasPlacement(toX, toY))
        {
            if (IsDemonWalls(toX, toY))
            {
                // ชนกำแพงปิศาจ: สั่งกำแพงทำงานผ่าน Hit() โดยตัวละครไม่ขยับตำแหน่ง
                mapGenerator.walls[toX, toY].Hit();
            }
            else if (IsPotion(toX, toY))
            {
                // เดินชนยา: สั่งยาทำงานผ่าน Hit() และเดินเข้าทับตำแหน่งยา
                mapGenerator.potions[toX, toY].Hit();
                positionX = toX;
                positionY = toY;
                transform.position = new Vector3(positionX, positionY, 0);
            }
            else if (IsPotionBonus(toX, toY))
            {
                // เดินชนยาโบนัส
                mapGenerator.potions[toX, toY].Hit();
                positionX = toX;
                positionY = toY;
                transform.position = new Vector3(positionX, positionY, 0);
            }
            else if (IsExit(toX, toY))
            {
                // เดินเข้าประตูทางออก
                mapGenerator.Exit.Hit();
                positionX = toX;
                positionY = toY;
                transform.position = new Vector3(positionX, positionY, 0);
            }
        }
        else
        {
            // 3. กรณีเดินลงพื้นว่าง: อัปเดตพิกัด และเสียพลังงานก้าวละ 1 หน่วย
            positionX = toX;
            positionY = toY;
            transform.position = new Vector3(positionX, positionY, 0);
            TakeDamage(1);
        }
    }
    #endregion
}