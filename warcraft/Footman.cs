using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

public class Footman : Unit
{
    public delegate void RageActivation();
    public Footman() : base("Троль", 100, 15, 35, 15, 0, 50, 15, 10, 1)
    {
        name = "Троль";
        health = 100;
        damage = 15;
        walking_speed = 35;
        spell = 15;
        hpregen = 0;
        mp = 50;
        armor = 15;
        unbreaking_weapon = 10;
        lvl_unit = 1;

        int health40 = health * 40 / 100;
        if (health <= health40)
        {
            RageActivation rage = new(Rage);
            rage();
            Console.WriteLine("Rage activated");
        }
    }

    public void Print()
    {
        Console.WriteLine(
            "LVL - " + lvl_unit + "\n" +
            "Имя - " + name + "\n" + 
            "ХП = " + health + "\n" + 
            "Урон = " + damage + "\n" +
            "Скорость передвижения = " + walking_speed + "\n" + 
            "Урон от способности = " + spell + " (50 маны)" + "\n" + 
            "Мана = " + mp + "\n" + 
            "Броня - " + armor + "\n" + 
            "Прочность оружия = " + unbreaking_weapon
            );
    }
    public void Rage()
    {
        damage += 20;
        armor += 10;
    }
    public void Attack(Unit unit)
    {
        unit.health -= unit.damage;
        if (unit.health < 0)
        {
            health = 0;
        }
    }
}