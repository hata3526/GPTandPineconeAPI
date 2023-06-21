using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cgptWebAPITest.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BotCharacter",
                columns: table => new
                {
                    PK = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedByID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedByID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedByID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BotCharacter", x => x.PK);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    PK = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedByID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedByID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedByID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.PK);
                });

            migrationBuilder.CreateTable(
                name: "Conversation",
                columns: table => new
                {
                    PK = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FKUser = table.Column<long>(type: "bigint", nullable: false),
                    FKBotCharacter = table.Column<long>(type: "bigint", nullable: false),
                    StartedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedByID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedByID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedByID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conversation", x => x.PK);
                    table.ForeignKey(
                        name: "FK_Conversation_BotCharacter_FKBotCharacter",
                        column: x => x.FKBotCharacter,
                        principalTable: "BotCharacter",
                        principalColumn: "PK",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Conversation_User_FKUser",
                        column: x => x.FKUser,
                        principalTable: "User",
                        principalColumn: "PK",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    PK = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FKUser = table.Column<long>(type: "bigint", nullable: false),
                    FKSession = table.Column<long>(type: "bigint", nullable: false),
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedByID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedByID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedByID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.PK);
                    table.ForeignKey(
                        name: "FK_Message_Conversation_FKSession",
                        column: x => x.FKSession,
                        principalTable: "Conversation",
                        principalColumn: "PK",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Message_User_FKUser",
                        column: x => x.FKUser,
                        principalTable: "User",
                        principalColumn: "PK",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Conversation_FKBotCharacter",
                table: "Conversation",
                column: "FKBotCharacter");

            migrationBuilder.CreateIndex(
                name: "IX_Conversation_FKUser",
                table: "Conversation",
                column: "FKUser");

            migrationBuilder.CreateIndex(
                name: "IX_Message_FKSession",
                table: "Message",
                column: "FKSession");

            migrationBuilder.CreateIndex(
                name: "IX_Message_FKUser",
                table: "Message",
                column: "FKUser");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "Conversation");

            migrationBuilder.DropTable(
                name: "BotCharacter");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
