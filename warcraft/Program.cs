Footman footman = new Footman();
footman.Print();
Console.WriteLine();

Wizard wizard = new Wizard();
wizard.Print();
Console.WriteLine();

footman.Attack(wizard);
wizard.Attack(footman);

Fight fight = new Fight();