using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataTierWebServer.Migrations
{
    /// <inheritdoc />
    public partial class InialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AcctNo = table.Column<uint>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<uint>(type: "INTEGER", nullable: false),
                    Balance = table.Column<int>(type: "INTEGER", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AcctNo);
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FName = table.Column<string>(type: "TEXT", nullable: true),
                    LName = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Username = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<uint>(type: "INTEGER", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    ProfilePictureUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserHistories",
                columns: table => new
                {
                    transaction = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HistoryString = table.Column<string>(type: "TEXT", nullable: true),
                    AccountAcctNo = table.Column<uint>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserHistories", x => x.transaction);
                    table.ForeignKey(
                        name: "FK_UserHistories_Accounts_AccountAcctNo",
                        column: x => x.AccountAcctNo,
                        principalTable: "Accounts",
                        principalColumn: "AcctNo");
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AcctNo", "Address", "Age", "Balance", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1733u, "547 Amy Kim St.", 91u, 71586, "Linda.Edwards58@gmail.com", "Linda", "Edwards" },
                    { 1880u, "486 Nicholas Morales St.", 57u, 86011, "Debra.Carter401@gmail.com", "Debra", "Carter" },
                    { 2293u, "327 Kenneth Wood St.", 56u, 37258, "Dorothy.Jones130@gmail.com", "Dorothy", "Jones" },
                    { 2909u, "342 Dennis Martinez St.", 75u, 39638, "Donna.Lee728@gmail.com", "Donna", "Lee" },
                    { 3810u, "148 Paul Gutierrez St.", 20u, 37595, "Gregory.King47@gmail.com", "Gregory", "King" },
                    { 5067u, "746 Donald Phillips St.", 31u, 36371, "Margaret.James459@gmail.com", "Margaret", "James" },
                    { 8359u, "111 Betty Allen St.", 63u, 30452, "Ashley.Davis583@gmail.com", "Ashley", "Davis" },
                    { 8364u, "761 Donna Brooks St.", 25u, 22679, "Jonathan.Hill304@gmail.com", "Jonathan", "Hill" },
                    { 9087u, "240 Rebecca Reed St.", 85u, 46501, "Thomas.Ramirez791@gmail.com", "Thomas", "Ramirez" },
                    { 9484u, "385 Gary Rogers St.", 61u, 17140, "Melissa.Harris729@gmail.com", "Melissa", "Harris" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Address", "Age", "Email", "FName", "LName", "Password", "PhoneNumber", "ProfilePictureUrl", "Username" },
                values: new object[,]
                {
                    { 1, "148 Paul Gutierrez St.", 20u, "Gregory.King47@gmail.com", "Gregory", "King", "dC3CVIJPEcJb", "+9618062538", null, "Gregory.King597" },
                    { 2, "385 Gary Rogers St.", 61u, "Melissa.Harris729@gmail.com", "Melissa", "Harris", "9nkenIBd3ZM8", "+9616332483", null, "Melissa.Harris213" },
                    { 3, "746 Donald Phillips St.", 31u, "Margaret.James459@gmail.com", "Margaret", "James", "ivVyfXIPH4xY", "+9614292723", null, "Margaret.James225" },
                    { 4, "761 Donna Brooks St.", 25u, "Jonathan.Hill304@gmail.com", "Jonathan", "Hill", "TUU84hXUwvWr", "+9611196142", null, "Jonathan.Hill664" },
                    { 5, "486 Nicholas Morales St.", 57u, "Debra.Carter401@gmail.com", "Debra", "Carter", "skcPSEgTewzp", "+9613995673", null, "Debra.Carter108" },
                    { 6, "111 Betty Allen St.", 63u, "Ashley.Davis583@gmail.com", "Ashley", "Davis", "lDyAvsOwwCHM", "+9612583346", null, "Ashley.Davis790" },
                    { 7, "240 Rebecca Reed St.", 85u, "Thomas.Ramirez791@gmail.com", "Thomas", "Ramirez", "JYvqzv2ifsRE", "+9616091021", null, "Thomas.Ramirez608" },
                    { 8, "327 Kenneth Wood St.", 56u, "Dorothy.Jones130@gmail.com", "Dorothy", "Jones", "Q9MhpXVrUi0R", "+9617567114", null, "Dorothy.Jones874" },
                    { 9, "342 Dennis Martinez St.", 75u, "Donna.Lee728@gmail.com", "Donna", "Lee", "02ZIAi5aOYWl", "+9613221345", null, "Donna.Lee811" },
                    { 10, "547 Amy Kim St.", 91u, "Linda.Edwards58@gmail.com", "Linda", "Edwards", "fjySQUlH9epg", "+9616948348", null, "Linda.Edwards892" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserHistories_AccountAcctNo",
                table: "UserHistories",
                column: "AccountAcctNo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserHistories");

            migrationBuilder.DropTable(
                name: "UserProfiles");

            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
