using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

public class Unit
{
    public int health;
    public int damage;
    public int mp;
    public int strength;
    public int dexterity;
    public int intelligence;
    public int constitution;


    public Unit(int health, int damage, int mp, int strength, int dexterity, int intelligence, int constitution)
    {
        this.health = health;
        this.damage = damage;
        this.mp = mp;
        this.strength = strength;
        this.dexterity = dexterity;
        this.intelligence = intelligence;
        this.constitution = constitution;
    }
}