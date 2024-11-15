using Game1125;
var player = new Player("Hero");
var room = new Room(player);

while (!player.IsDead)
{
    room = new Room(player);
    room.RunBattle();
}
Console.WriteLine("Конец игры");