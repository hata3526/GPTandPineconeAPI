using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cgptWebAPITest.Migrations
{
    /// <inheritdoc />
    public partial class aaa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Text",
                table: "Message",
                newName: "Content");

            migrationBuilder.AddColumn<long>(
                name: "FKBotCharacter",
                table: "Message",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Message_FKBotCharacter",
                table: "Message",
                column: "FKBotCharacter");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_BotCharacter_FKBotCharacter",
                table: "Message",
                column: "FKBotCharacter",
                principalTable: "BotCharacter",
                principalColumn: "PK",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_BotCharacter_FKBotCharacter",
                table: "Message");

            migrationBuilder.DropIndex(
                name: "IX_Message_FKBotCharacter",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "FKBotCharacter",
                table: "Message");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Message",
                newName: "Text");
        }
    }
}
