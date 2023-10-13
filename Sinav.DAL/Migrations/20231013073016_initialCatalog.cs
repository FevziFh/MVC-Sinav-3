using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sinav.DAL.Migrations
{
    public partial class initialCatalog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Topic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TopicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TopicId = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Article_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Article_Topic_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f7856464-b9f7-463e-a59c-7965a985d1f6", 0, "20aa330b-02a1-45f3-9ad7-52b48d9a2154", "fevzi.hamdemir@mail.com", false, "fevzi", "hamdemir", false, null, null, null, "AQAAAAEAACcQAAAAEEJ8MhTwoaLtRCpw3r3xa4NL2NLAqcWTC9Za8DxGYCVM1nKmz7uKIHKfqWxChLmAnw==", "05300355564", false, "31dc7211-5182-4e7c-80bd-e35aa29376c0", false, null });

            migrationBuilder.InsertData(
                table: "Topic",
                columns: new[] { "Id", "CreateDate", "DeleteDate", "Status", "TopicName", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 13, 10, 30, 16, 186, DateTimeKind.Local).AddTicks(1014), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Java", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2023, 10, 13, 10, 30, 16, 186, DateTimeKind.Local).AddTicks(1025), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "C#", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2023, 10, 13, 10, 30, 16, 186, DateTimeKind.Local).AddTicks(1026), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "MVC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "AppUserId", "Body", "CreateDate", "DeleteDate", "Status", "Title", "TopicId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "f7856464-b9f7-463e-a59c-7965a985d1f6", "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –", new DateTime(2023, 10, 13, 10, 30, 16, 186, DateTimeKind.Local).AddTicks(1167), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "c#-1", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "f7856464-b9f7-463e-a59c-7965a985d1f6", "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –", new DateTime(2023, 10, 13, 10, 30, 16, 186, DateTimeKind.Local).AddTicks(1188), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lorem Ipsum", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "f7856464-b9f7-463e-a59c-7965a985d1f6", "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –", new DateTime(2023, 10, 13, 10, 30, 16, 186, DateTimeKind.Local).AddTicks(1191), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lorem Ipsum", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "f7856464-b9f7-463e-a59c-7965a985d1f6", "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –", new DateTime(2023, 10, 13, 10, 30, 16, 186, DateTimeKind.Local).AddTicks(1193), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lorem Ipsum", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "f7856464-b9f7-463e-a59c-7965a985d1f6", "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –", new DateTime(2023, 10, 13, 10, 30, 16, 186, DateTimeKind.Local).AddTicks(1195), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lorem Ipsum", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "f7856464-b9f7-463e-a59c-7965a985d1f6", "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –", new DateTime(2023, 10, 13, 10, 30, 16, 186, DateTimeKind.Local).AddTicks(1197), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lorem Ipsum", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "f7856464-b9f7-463e-a59c-7965a985d1f6", "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –", new DateTime(2023, 10, 13, 10, 30, 16, 186, DateTimeKind.Local).AddTicks(1198), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lorem Ipsum", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "f7856464-b9f7-463e-a59c-7965a985d1f6", "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –", new DateTime(2023, 10, 13, 10, 30, 16, 186, DateTimeKind.Local).AddTicks(1200), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lorem Ipsum", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "f7856464-b9f7-463e-a59c-7965a985d1f6", "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –", new DateTime(2023, 10, 13, 10, 30, 16, 186, DateTimeKind.Local).AddTicks(1202), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lorem Ipsum", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "f7856464-b9f7-463e-a59c-7965a985d1f6", "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –", new DateTime(2023, 10, 13, 10, 30, 16, 186, DateTimeKind.Local).AddTicks(1204), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lorem Ipsum", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "f7856464-b9f7-463e-a59c-7965a985d1f6", "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –", new DateTime(2023, 10, 13, 10, 30, 16, 186, DateTimeKind.Local).AddTicks(1206), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "c#-1", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "f7856464-b9f7-463e-a59c-7965a985d1f6", "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –", new DateTime(2023, 10, 13, 10, 30, 16, 186, DateTimeKind.Local).AddTicks(1208), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lorem Ipsum", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "f7856464-b9f7-463e-a59c-7965a985d1f6", "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –", new DateTime(2023, 10, 13, 10, 30, 16, 186, DateTimeKind.Local).AddTicks(1210), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lorem Ipsum", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "f7856464-b9f7-463e-a59c-7965a985d1f6", "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –", new DateTime(2023, 10, 13, 10, 30, 16, 186, DateTimeKind.Local).AddTicks(1213), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lorem Ipsum", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "f7856464-b9f7-463e-a59c-7965a985d1f6", "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –", new DateTime(2023, 10, 13, 10, 30, 16, 186, DateTimeKind.Local).AddTicks(1215), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lorem Ipsum", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, "f7856464-b9f7-463e-a59c-7965a985d1f6", "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –", new DateTime(2023, 10, 13, 10, 30, 16, 186, DateTimeKind.Local).AddTicks(1216), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lorem Ipsum", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, "f7856464-b9f7-463e-a59c-7965a985d1f6", "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –", new DateTime(2023, 10, 13, 10, 30, 16, 186, DateTimeKind.Local).AddTicks(1218), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lorem Ipsum", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, "f7856464-b9f7-463e-a59c-7965a985d1f6", "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –", new DateTime(2023, 10, 13, 10, 30, 16, 186, DateTimeKind.Local).AddTicks(1220), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lorem Ipsum", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, "f7856464-b9f7-463e-a59c-7965a985d1f6", "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –", new DateTime(2023, 10, 13, 10, 30, 16, 186, DateTimeKind.Local).AddTicks(1222), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lorem Ipsum", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, "f7856464-b9f7-463e-a59c-7965a985d1f6", "Lorem Ipsum, Çiçero'nun MÖ 45 yılında yazdığı \"de Finibus Bonorum et Malorum –", new DateTime(2023, 10, 13, 10, 30, 16, 186, DateTimeKind.Local).AddTicks(1224), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lorem Ipsum", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Article_AppUserId",
                table: "Article",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Article_TopicId",
                table: "Article",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Article");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Topic");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
