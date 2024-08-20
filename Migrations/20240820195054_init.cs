using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CircleConnect.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Communities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Location = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsPrivate = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Communities", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CommunityCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CommunityId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunityCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommunityCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommunityCategories_Communities_CommunityId",
                        column: x => x.CommunityId,
                        principalTable: "Communities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Location = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CommunityId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Communities_CommunityId",
                        column: x => x.CommunityId,
                        principalTable: "Communities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Events_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "JoinedCommunities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    isAdmin = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    isCreator = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CommunityId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoinedCommunities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JoinedCommunities_Communities_CommunityId",
                        column: x => x.CommunityId,
                        principalTable: "Communities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JoinedCommunities_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CommunityId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_Communities_CommunityId",
                        column: x => x.CommunityId,
                        principalTable: "Communities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Messages_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsRead = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EventParticipants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    isAdmin = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventParticipants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventParticipants_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventParticipants_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 20, 19, 50, 53, 637, DateTimeKind.Utc).AddTicks(6898), "General technology ideas", "Technology" },
                    { 2, new DateTime(2024, 8, 20, 19, 50, 53, 637, DateTimeKind.Utc).AddTicks(6900), "Blockchain knowledge and ideas", "Blockchain" },
                    { 3, new DateTime(2024, 8, 20, 19, 50, 53, 637, DateTimeKind.Utc).AddTicks(6900), "Bussiness ideas to investors", "Bussiness" }
                });

            migrationBuilder.InsertData(
                table: "Communities",
                columns: new[] { "Id", "CreatedAt", "Description", "IsPrivate", "Location", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 20, 19, 50, 53, 637, DateTimeKind.Utc).AddTicks(6999), "A community for technology enthusiasts to discuss the latest trends.", 0, "San Francisco", "Tech Enthusiasts" },
                    { 2, new DateTime(2024, 8, 20, 19, 50, 53, 637, DateTimeKind.Utc).AddTicks(7000), "A group of book lovers sharing and discussing their favorite books.", 1, "New York", "Book Club" },
                    { 3, new DateTime(2024, 8, 20, 19, 50, 53, 637, DateTimeKind.Utc).AddTicks(7001), "A community for people passionate about fitness and a healthy lifestyle.", 0, "Los Angeles", "Fitness and Health" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Password", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 20, 19, 50, 53, 637, DateTimeKind.Utc).AddTicks(6662), "hako12@circle.com", "a58f45g88jf85", "hako12" },
                    { 2, new DateTime(2024, 8, 20, 19, 50, 53, 637, DateTimeKind.Utc).AddTicks(6665), "fako15@circle.com", "b58f45g88jf85", "fako15" },
                    { 3, new DateTime(2024, 8, 20, 19, 50, 53, 637, DateTimeKind.Utc).AddTicks(6665), "cako22@circle.com", "c58f45g88jf85", "cako22" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "CommunityId", "CreatedAt", "Date", "Description", "Location", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2024, 8, 20, 19, 50, 53, 637, DateTimeKind.Utc).AddTicks(7096), new DateTime(2024, 9, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), "An event for tech enthusiasts to network and share knowledge.", "Tech Park, Room 302", "Tech Community Meetup", 1 },
                    { 2, 1, new DateTime(2024, 8, 20, 19, 50, 53, 637, DateTimeKind.Utc).AddTicks(7101), new DateTime(2024, 10, 10, 14, 0, 0, 0, DateTimeKind.Unspecified), "A hands-on workshop on AI and Machine Learning trends.", "Innovation Hub, Room 210", "AI and Machine Learning Workshop", 2 },
                    { 3, 2, new DateTime(2024, 8, 20, 19, 50, 53, 637, DateTimeKind.Utc).AddTicks(7102), new DateTime(2024, 11, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), "A platform for startups to pitch their ideas to investors.", "Business Center, Main Hall", "Startup Pitch Day", 3 }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "CommunityId", "Content", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, 2, "Hi, i am Kagan!", new DateTime(2024, 8, 20, 19, 50, 53, 637, DateTimeKind.Utc).AddTicks(7202), 1 },
                    { 2, 1, "I am a Junior Software Developer.", new DateTime(2024, 8, 20, 19, 50, 53, 637, DateTimeKind.Utc).AddTicks(7203), 3 },
                    { 3, 3, "I am passionate about technologies and love to learn new things.", new DateTime(2024, 8, 20, 19, 50, 53, 637, DateTimeKind.Utc).AddTicks(7204), 2 }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Content", "CreatedAt", "IsRead", "Type", "UserId" },
                values: new object[,]
                {
                    { 1, "Ankara Techno Meeting", new DateTime(2024, 8, 20, 19, 50, 53, 637, DateTimeKind.Utc).AddTicks(7298), true, "Meeting", 1 },
                    { 2, "Sabanci Event", new DateTime(2024, 8, 20, 19, 50, 53, 637, DateTimeKind.Utc).AddTicks(7300), true, "Event", 3 },
                    { 3, "Book Worms Istanbul", new DateTime(2024, 8, 20, 19, 50, 53, 637, DateTimeKind.Utc).AddTicks(7345), false, "Event", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommunityCategories_CategoryId",
                table: "CommunityCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CommunityCategories_CommunityId",
                table: "CommunityCategories",
                column: "CommunityId");

            migrationBuilder.CreateIndex(
                name: "IX_EventParticipants_EventId",
                table: "EventParticipants",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventParticipants_UserId",
                table: "EventParticipants",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_CommunityId",
                table: "Events",
                column: "CommunityId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_UserId",
                table: "Events",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_JoinedCommunities_CommunityId",
                table: "JoinedCommunities",
                column: "CommunityId");

            migrationBuilder.CreateIndex(
                name: "IX_JoinedCommunities_UserId",
                table: "JoinedCommunities",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_CommunityId",
                table: "Messages",
                column: "CommunityId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserId",
                table: "Messages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommunityCategories");

            migrationBuilder.DropTable(
                name: "EventParticipants");

            migrationBuilder.DropTable(
                name: "JoinedCommunities");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Communities");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
