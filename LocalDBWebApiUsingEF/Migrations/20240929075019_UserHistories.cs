using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataTierWebServer.Migrations
{
    /// <inheritdoc />
    public partial class UserHistories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctNo",
                keyValue: 1u);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctNo",
                keyValue: 2u);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctNo",
                keyValue: 3u);

            migrationBuilder.CreateTable(
                name: "UserHistories",
                columns: table => new
                {
                    transaction = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HistoryString = table.Column<string>(type: "TEXT", nullable: true),
                    AccountAcctNo = table.Column<int>(type: "INTEGER", nullable: true)
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
                    { 1, "1 Street Suburb", 25u, 1000, "john.doe@email.com", "John", "Doe" },
                    { 2, "2 Street Suburb", 30u, 2000, "jane.doe@email.com", "Jane", "Doe" },
                    { 3, "3 Street Suburb", 35u, 3000, "mike.smith@email.com", "Mike", "Smith" }
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

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctNo",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctNo",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctNo",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AcctNo", "Address", "Age", "Balance", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1u, "1 Street Suburb", 25u, 1000, "john.doe@email.com", "John", "Doe" },
                    { 2u, "2 Street Suburb", 30u, 2000, "jane.doe@email.com", "Jane", "Doe" },
                    { 3u, "3 Street Suburb", 35u, 3000, "mike.smith@email.com", "Mike", "Smith" }
                });
        }
    }
}
