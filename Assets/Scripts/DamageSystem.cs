using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSystem 
{
    int damage_AK47 = 20;
    int damage_DessertEagle = 15;
    int damage_RocketLauncher = 100;

    public int Damage_AK47
    {
        get { return damage_AK47; }
        set { damage_AK47 = value; }
    }

    public int Damage_DessertEagle
    {
        get { return damage_DessertEagle; }
        set { damage_DessertEagle = value;}
    }

    public int Damage_RocketLauncher
    {
        get { return damage_RocketLauncher; }
        set { damage_RocketLauncher = value; }
    }
}
