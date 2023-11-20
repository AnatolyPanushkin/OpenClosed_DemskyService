using AbstractFactory;
using AbstractFactory.FactoryMethods;

Сharacter elf= new Сharacter(new ElfFactory());

Сharacter orc = new Сharacter(new OrcFactory());

Сharacter wizard = new Сharacter(new OrcFactory());

elf.Attack();
elf.Move();

Console.ReadLine();

