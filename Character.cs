using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public event EventHandler OnCharacterDeath;
    public static List<Character> CharacterList = new List<Character>();

    int MaxHp;
    int MaxSpeed;
    int MaxArmour;

    public Character(int MaxHp, int MaxSpeed, int MaxArmour)
    {
        this.MaxHp = MaxHp;
        this.MaxSpeed = MaxSpeed;
        this.MaxArmour = MaxArmour;

        CharacterList.Add(this);
    }

    int HP;
    float Armour;
    float Speed;
    public bool IsAlive;

    public int hp
    {
        get { if (HP > MaxHp)
                return HP = MaxHp;

            return HP;
        }
        set { HP = value; }
    }

    public float speed
    {
        get
        {
            if (Speed > MaxSpeed)
                return Speed = MaxSpeed;

            return HP;
        }
        set { Speed = value; }
    }

    public float armour
    {
        get
        {
            if (Armour > MaxArmour)
                return Speed = MaxSpeed;

            return HP;
        }
        set { Armour = value; }
    }

    public void CharacterKill()
    {
        OnCharacterDeath(this, EventArgs.Empty);
    }
}
