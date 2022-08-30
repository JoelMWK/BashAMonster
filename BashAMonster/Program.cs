player Eric = new();
mutant Cowman = new();

string action;

Console.WriteLine($"Your hp is {Eric.hp}");
Console.WriteLine($"The enemys hp is {Cowman.hp}");

Console.WriteLine("Press: A) Attack B) Dodge");

action = Console.ReadLine();
action = action.ToLower();

if(action == "a"){
    Cowman.hp -=Eric.damage;
    Eric.hp -=Cowman.damage;
    Console.WriteLine($"You attack {Cowman.name} and did {Eric.damage}");
    Console.WriteLine($"{Cowman.name} has {Cowman.hp} left");
    Console.WriteLine($"{Cowman.name} also managed to hit you");
    Console.WriteLine($"Your hp is now {Eric.hp}");
}
else if(action == "b"){
Console.WriteLine($"You dodged and {Cowman.name} missed the attack");
}
else Console.WriteLine("You are dumb!");

Console.WriteLine("Press any key to exit!");

Console.ReadLine();
