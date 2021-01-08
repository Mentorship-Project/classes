using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public event EventHandler OnCharacterDeath;
    public static List<Character> CharacterList = new List<Character>();

    int MaxHp;
    int MaxSpeed;
    int MaxArmour;

    int HP;
    float Armour;
    float Speed;
    public bool IsAlive;

    public int hp
    {
        get { return HP; }
        set { HP = value > MaxHp ? value : HP = MaxHp; }
    }

    public float speed
    {
        get {return Speed;}
        set { Speed = value > MaxSpeed ? value : Speed = MaxSpeed; }
    }
     
    public float armour
    {
        get {return Armour;}
        set { Armour = value > MaxArmour ? value : Armour = MaxArmour; }
    }

    public void CharacterKill()
    {
        OnCharacterDeath(this, EventArgs.Empty);
    }

    public void Spawn(int CurrentHP, float CurrentArmor, float CurrentSpeed, int MaxHp, int MaxSpeed, int MaxArmour, GameObject gameObject, Vector3 Position, Quaternion Rotation)
    {
        HP = CurrentHP;
        Armour = CurrentArmor;
        Speed = CurrentSpeed;

        this.MaxHp = MaxHp;
        this.MaxSpeed = MaxSpeed;
        this.MaxArmour = MaxArmour;

        Instantiate(gameObject, Position, Rotation);
        CharacterList.Add(this);
    }

    protected void Set(int CurrentHP, float CurrentArmor, float CurrentSpeed, int MaxHp, int MaxSpeed, int MaxArmour)
    {
        HP = CurrentHP;
        Armour = CurrentArmor;
        Speed = CurrentSpeed;

        this.MaxHp = MaxHp;
        this.MaxSpeed = MaxSpeed;
        this.MaxArmour = MaxArmour;

        CharacterList.Add(this);
    }

}
