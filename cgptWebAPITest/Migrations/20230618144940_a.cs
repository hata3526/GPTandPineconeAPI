using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cgptWebAPITest.Migrations
{
    /// <inheritdoc />
    public partial class a : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conversation_User_UserId",
                table: "Conversation");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_Conversation_ConversationId",
                table: "Message");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_User_SenderId",
                table: "Message");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Message",
                table: "Message");

            migrationBuilder.DropIndex(
                name: "IX_Message_ConversationId",
                table: "Message");

            migrationBuilder.DropIndex(
                name: "IX_Message_SenderId",
                table: "Message");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Conversation",
                table: "Conversation");

            migrationBuilder.DropIndex(
                name: "IX_Conversation_UserId",
                table: "Conversation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BotCharacter",
                table: "BotCharacter");

            migrationBuilder.DropColumn(
                name: "ConversationId",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "SenderId",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Conversation");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "User",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "User",
                newName: "UpdatedByName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Message",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Conversation",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BotCharacter",
                newName: "ID");

            migrationBuilder.AlterColumn<Guid>(
                name: "ID",
                table: "User",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<long>(
                name: "PK",
                table: "User",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByID",
                table: "User",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByName",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "User",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedByID",
                table: "User",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedByName",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "User",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedByID",
                table: "User",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "User",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ID",
                table: "Message",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<long>(
                name: "PK",
                table: "Message",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByID",
                table: "Message",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByName",
                table: "Message",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Message",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedByID",
                table: "Message",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedByName",
                table: "Message",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Message",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FKSession",
                table: "Message",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "FKUser",
                table: "Message",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedByID",
                table: "Message",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedByName",
                table: "Message",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "Message",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ID",
                table: "Conversation",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<long>(
                name: "PK",
                table: "Conversation",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByID",
                table: "Conversation",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByName",
                table: "Conversation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Conversation",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedByID",
                table: "Conversation",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedByName",
                table: "Conversation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Conversation",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndedOn",
                table: "Conversation",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FKBotCharacter",
                table: "Conversation",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "FKUser",
                table: "Conversation",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartedOn",
                table: "Conversation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedByID",
                table: "Conversation",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedByName",
                table: "Conversation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "Conversation",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ID",
                table: "BotCharacter",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<long>(
                name: "PK",
                table: "BotCharacter",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByID",
                table: "BotCharacter",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByName",
                table: "BotCharacter",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "BotCharacter",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedByID",
                table: "BotCharacter",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedByName",
                table: "BotCharacter",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "BotCharacter",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedByID",
                table: "BotCharacter",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedByName",
                table: "BotCharacter",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "BotCharacter",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "PK");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Message",
                table: "Message",
                column: "PK");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Conversation",
                table: "Conversation",
                column: "PK");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BotCharacter",
                table: "BotCharacter",
                column: "PK");

            migrationBuilder.CreateIndex(
                name: "IX_Message_FKSession",
                table: "Message",
                column: "FKSession");

            migrationBuilder.CreateIndex(
                name: "IX_Message_FKUser",
                table: "Message",
                column: "FKUser");

            migrationBuilder.CreateIndex(
                name: "IX_Conversation_FKBotCharacter",
                table: "Conversation",
                column: "FKBotCharacter");

            migrationBuilder.CreateIndex(
                name: "IX_Conversation_FKUser",
                table: "Conversation",
                column: "FKUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Conversation_BotCharacter_FKBotCharacter",
                table: "Conversation",
                column: "FKBotCharacter",
                principalTable: "BotCharacter",
                principalColumn: "PK",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Conversation_User_FKUser",
                table: "Conversation",
                column: "FKUser",
                principalTable: "User",
                principalColumn: "PK",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Conversation_FKSession",
                table: "Message",
                column: "FKSession",
                principalTable: "Conversation",
                principalColumn: "PK",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Message_User_FKUser",
                table: "Message",
                column: "FKUser",
                principalTable: "User",
                principalColumn: "PK",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conversation_BotCharacter_FKBotCharacter",
                table: "Conversation");

            migrationBuilder.DropForeignKey(
                name: "FK_Conversation_User_FKUser",
                table: "Conversation");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_Conversation_FKSession",
                table: "Message");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_User_FKUser",
                table: "Message");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Message",
                table: "Message");

            migrationBuilder.DropIndex(
                name: "IX_Message_FKSession",
                table: "Message");

            migrationBuilder.DropIndex(
                name: "IX_Message_FKUser",
                table: "Message");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Conversation",
                table: "Conversation");

            migrationBuilder.DropIndex(
                name: "IX_Conversation_FKBotCharacter",
                table: "Conversation");

            migrationBuilder.DropIndex(
                name: "IX_Conversation_FKUser",
                table: "Conversation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BotCharacter",
                table: "BotCharacter");

            migrationBuilder.DropColumn(
                name: "PK",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CreatedByID",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CreatedByName",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "User");

            migrationBuilder.DropColumn(
                name: "DeletedByID",
                table: "User");

            migrationBuilder.DropColumn(
                name: "DeletedByName",
                table: "User");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UpdatedByID",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "User");

            migrationBuilder.DropColumn(
                name: "PK",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "CreatedByID",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "CreatedByName",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "DeletedByID",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "DeletedByName",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "FKSession",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "FKUser",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "UpdatedByID",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "UpdatedByName",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "PK",
                table: "Conversation");

            migrationBuilder.DropColumn(
                name: "CreatedByID",
                table: "Conversation");

            migrationBuilder.DropColumn(
                name: "CreatedByName",
                table: "Conversation");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Conversation");

            migrationBuilder.DropColumn(
                name: "DeletedByID",
                table: "Conversation");

            migrationBuilder.DropColumn(
                name: "DeletedByName",
                table: "Conversation");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Conversation");

            migrationBuilder.DropColumn(
                name: "EndedOn",
                table: "Conversation");

            migrationBuilder.DropColumn(
                name: "FKBotCharacter",
                table: "Conversation");

            migrationBuilder.DropColumn(
                name: "FKUser",
                table: "Conversation");

            migrationBuilder.DropColumn(
                name: "StartedOn",
                table: "Conversation");

            migrationBuilder.DropColumn(
                name: "UpdatedByID",
                table: "Conversation");

            migrationBuilder.DropColumn(
                name: "UpdatedByName",
                table: "Conversation");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Conversation");

            migrationBuilder.DropColumn(
                name: "PK",
                table: "BotCharacter");

            migrationBuilder.DropColumn(
                name: "CreatedByID",
                table: "BotCharacter");

            migrationBuilder.DropColumn(
                name: "CreatedByName",
                table: "BotCharacter");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "BotCharacter");

            migrationBuilder.DropColumn(
                name: "DeletedByID",
                table: "BotCharacter");

            migrationBuilder.DropColumn(
                name: "DeletedByName",
                table: "BotCharacter");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "BotCharacter");

            migrationBuilder.DropColumn(
                name: "UpdatedByID",
                table: "BotCharacter");

            migrationBuilder.DropColumn(
                name: "UpdatedByName",
                table: "BotCharacter");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "BotCharacter");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "User",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UpdatedByName",
                table: "User",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Message",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Conversation",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "BotCharacter",
                newName: "Id");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "User",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Message",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ConversationId",
                table: "Message",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SenderId",
                table: "Message",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Conversation",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Conversation",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "BotCharacter",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Message",
                table: "Message",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Conversation",
                table: "Conversation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BotCharacter",
                table: "BotCharacter",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Message_ConversationId",
                table: "Message",
                column: "ConversationId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_SenderId",
                table: "Message",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Conversation_UserId",
                table: "Conversation",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Conversation_User_UserId",
                table: "Conversation",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Conversation_ConversationId",
                table: "Message",
                column: "ConversationId",
                principalTable: "Conversation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Message_User_SenderId",
                table: "Message",
                column: "SenderId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
