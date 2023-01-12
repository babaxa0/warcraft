public class Fight 
{
    Footman footman = new Footman();
    Wizard wizard = new Wizard();

    public Fight()
    {
        Console.WriteLine(
            "q - Атака CФа " + "\n"
            + "w - Атака Троля" + "\n"
            + "e - Использовать способность СФа (сквозь броню) " + "\n"
            + "r - Использовать способность Троля (сквозь броню) " + "\n"
            + "a - Восстановление хп СФу " + "\n"
            + "up_footman - Улучшения Троля " + "\n"
            + "up_wizard - Улучшения СФа");

        while (footman.health > 0 && wizard.health > 0)
        {
            string space = Console.ReadLine();

            if (space == "up_footman")
            {
                footman.lvl_unit += 1;

                footman.damage += 10;
                footman.armor += 10;
                footman.spell += 10;
                footman.unbreaking_weapon += 3;

                Console.WriteLine($"LVL - {footman.lvl_unit}");
                Console.WriteLine($"Урон увеличен на 10 - {footman.damage}");
                Console.WriteLine($"Броня увеличена на 10 - {footman.armor}");
                Console.WriteLine($"Урон от способности увеличен на 10 - {footman.spell}");
                Console.WriteLine($"Прочность оружия увеличена на 3 - {footman.unbreaking_weapon}");
            }

            if (space == "up_wizard")
            {
                wizard.lvl_unit += 1;

                wizard.damage += 10;
                wizard.armor += 10;
                wizard.spell += 10;
                wizard.unbreaking_weapon += 3;

                Console.WriteLine($"LVL - {wizard.lvl_unit}");
                Console.WriteLine($"Урон увеличен на 10 - {wizard.damage}");
                Console.WriteLine($"Броня увеличена на 10 - {wizard.armor}");
                Console.WriteLine($"Урон от способности увеличен на 10 - {wizard.spell}");
                Console.WriteLine($"Прочность оружия увеличена на 3 - {wizard.unbreaking_weapon}");
            }

            if (space == "q")
            {
                footman.health -= wizard.damage;
                footman.Print();
            }

            //if (space == "q")
            //{
            //    wizard.unbreaking_weapon -= 1;
            //    if (wizard.damage >= footman.armor)
            //    {
            //        footman.health -= (wizard.damage - footman.armor);
            //        footman.armor = 0;
            //        if (footman.health < 0)
            //        {
            //            footman.health = 0;
            //        }
            //    }
            //    else if (wizard.damage < footman.armor)
            //    {
            //        footman.armor -= wizard.damage;
            //        if (footman.health < 0)
            //        {
            //            footman.health = 0;
            //        }
            //    }
            //    if (wizard.unbreaking_weapon == 0)
            //    {
            //        Console.WriteLine("Оружие СФа Сломано");
            //        wizard.health = 0;
            //    }
            //    InfFootman(footman);
            //}
            if (space == "w")
            {
                if (footman.damage >= wizard.armor)
                {
                    footman.unbreaking_weapon -= 1;
                    wizard.health -= (footman.damage - wizard.armor);
                    wizard.armor = 0;
                    if (wizard.health < 0)
                    {
                        wizard.health = 0;
                    }
                }
                else if (footman.damage < wizard.armor)
                {
                    wizard.armor -= wizard.damage;
                    if (wizard.health < 0)
                    {
                        wizard.health = 0;
                    }
                }
                if (footman.unbreaking_weapon == 0)
                {
                    Console.WriteLine("Оружие Троля Сломано");
                    footman.health = 0;
                }
                wizard.Print();
            }

            if (space == "e" && wizard.mp >= 50)
            {
                wizard.unbreaking_weapon -= 2;
                footman.health -= wizard.spell;
                wizard.mp -= 50;
                if (footman.health <= 0)
                {
                    footman.health = 0;
                }
                if (wizard.mp < 0)
                {
                    wizard.mp = 0;
                    Console.WriteLine("Недостаточно маны");
                }
                if (wizard.unbreaking_weapon == 0)
                {
                    Console.WriteLine("Оружие СФа Сломано");
                    wizard.health = 0;
                }
                footman.Print();
            }

            if (space == "r" && wizard.mp > 50)
            {
                footman.unbreaking_weapon -= 2;
                wizard.health -= footman.spell;
                wizard.Print();
            }

            if (space == "a" && wizard.mp >= 50)
            {
                wizard.unbreaking_weapon -= 1;
                wizard.mp -= 50;
                if (wizard.health < 0)
                {
                    wizard.health = 0;
                }
                if (wizard.mp < 0)
                {
                    wizard.mp = 0;
                }
                if (wizard.health >= 50)
                {
                    wizard.health = 100;
                }
                if (wizard.health < 50)
                {
                    wizard.health += wizard.hpregen;
                }
                if (wizard.unbreaking_weapon == 0)
                {
                    Console.WriteLine("Оружие СФа Сломано");
                    wizard.health = 0;
                }
                wizard.Print();
            }

            if (footman.health <= 0)
            {
                Console.WriteLine("Победа СФа. Бой окончен");
            }
            if (wizard.health <= 0)
            {
                Console.WriteLine("Победа Троля. Бой окончен");
            }
        }
    }
}