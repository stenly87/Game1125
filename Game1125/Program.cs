using Game1125;
var player = new Player("Hero");

while (!player.IsDead)
{
    var room = new Room(player);
    room.RunBattle();
}
Console.WriteLine("Конец игры");