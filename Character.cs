using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public event EventHandler OnCharacterDeath;
    public static List<Character> CharacterList = new List<Character>();

    float MaxHp, MaxSpeed, MaxArmour;
    float HP, Armour, Speed;

    public bool IsAlive;

    public float hp
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

    public void TakeDmg(float DamageAmount)
    {
        //Enter the damage here for example HP -= DamageAmount / (Armour / 4);
        Debug.LogError("Please insert the Damage in the TakeDmg method in Character class (TakeDmg method incomplete!)");

        if (HP <= 0)
        {
            OnCharacterDeath(this, EventArgs.Empty);
            IsAlive = false;
        }
    }

    public void Spawn(float CurrentHP, float CurrentArmor, float CurrentSpeed, int MaxHp, int MaxSpeed, int MaxArmour, GameObject gameObject, Vector3 Position, Quaternion Rotation)
    {
        HP = CurrentHP;
        Armour = CurrentArmor;
        Speed = CurrentSpeed;

        this.MaxHp = MaxHp;
        this.MaxSpeed = MaxSpeed;
        this.MaxArmour = MaxArmour;
        IsAlive = HP > 0 ? true : false;

        Instantiate(gameObject, Position, Rotation);
        CharacterList.Add(this);
    }

    protected void Set(float CurrentHP, float CurrentArmor, float CurrentSpeed, int MaxHp, int MaxSpeed, int MaxArmour)
    {
        HP = CurrentHP;
        Armour = CurrentArmor;
        Speed = CurrentSpeed;

        this.MaxHp = MaxHp;
        this.MaxSpeed = MaxSpeed;
        this.MaxArmour = MaxArmour;
        IsAlive = HP > 0 ? true : false;

        CharacterList.Add(this);
    }

}
