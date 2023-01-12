using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

public class Wizard : Unit
{
    public Wizard() : base("Троль", 100, 30, 35, 15, 0, 50, 15, 10, 1)
    {
        name = "СФ";
        health = 100;
        damage = 30;
        walking_speed = 35;
        spell = 20;
        hpregen = 50;
        mp = 200;
        armor = 10;
        unbreaking_weapon = 3;
        lvl_unit = 10;
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
    public void Attack(Unit unit)
    {
        unit.health -= unit.damage;
        if (unit.health <= 0)
        {
            health = 0;
        }
    }
}