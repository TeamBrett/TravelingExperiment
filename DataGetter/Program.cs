using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace DataGetter
{
    class Program
    {
        private static string dbConnectionString = "Server=localhost;Database=Test;Trusted_Connection=True;MultipleActiveResultSets=true";
        private static SqlConnection connection;

        static void Main(string[] args) {
            using (connection = new SqlConnection(dbConnectionString)) {
                Console.WriteLine("Which player would you like?");

                var id = int.Parse(Console.ReadLine());
                var player = GetPlayerTheEasierWay(id);
                if (player == null) {
                    Console.WriteLine("nope, can't find that player");
                    return;
                }

                Console.WriteLine(player.Name + " is a " + player.Gender.Name);

                Console.WriteLine("New player name: ");

                var player2 = new Player();
                player2.Name = Console.ReadLine();

                Console.WriteLine("new Player gender: ");
                player2.GenderId = short.Parse(Console.ReadLine());
                AddPlayer(player2);

                Console.WriteLine("player 2 id: " + player2.Id);
                Console.ReadLine();
            }
        }

        private static void AddPlayer(Player player) {
            var id = connection.QuerySingle<int>($@"

insert into {nameof(Player)}(name, genderid)
values(@playername, @genderid)

select scope_identity();

",
new {
    playername = player.Name,
    player.GenderId
});

            player.Id = id;
        }

        private static Player GetPlayerTheEasierWay(int id) {
            return connection.Query<Player, Option, Player>($@"
SELECT 
  p.id            as {nameof(Player.Id)}
, p.name          as {nameof(Player.Name)}
, p.genderid      as {nameof(Player.GenderId)}
, g.id
, g.name
, g.displayindex
FROM dbo.Player p
join dbo.gender g on p.GenderId = g.Id
WHERE p.id = @id
",
                (player, option) => {
                    player.Gender = option;
                    return player;
                }, new { id }).First();
        }

        private static Player GetPlayerTheHardWay(int id) {
            using (var sqlConnection1 = new SqlConnection("Server=localhost;Database=Test;Trusted_Connection=True;MultipleActiveResultSets=true")) {
                using (var cmd = new SqlCommand() {
                    CommandText = @"
SELECT 
    id
  , name as PlayerName
  , genderid
FROM dbo.Player
WHERE id = @id
",
                    CommandType = CommandType.Text,
                    Connection = sqlConnection1
                }) {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    sqlConnection1.Open();

                    using (var reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            var player = new Player();
                            player.Id = (int)reader[0];
                            player.Name = (string)reader[1];
                            player.GenderId = (short)reader[2];

                            return player;
                        }

                        return null;
                    }
                }
            }
        }
    }

    class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short GenderId { get; set; }
        public Option Gender { get; set; }
    }

    class Option
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public int DisplayIndex { get; set; }
    }
}
