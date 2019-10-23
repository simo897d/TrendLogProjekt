using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrendLogProjekt.Migrations
{
    public partial class Channels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlarmSettings",
                columns: table => new
                {
                    email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlarmSettings", x => x.email);
                });

            migrationBuilder.CreateTable(
                name: "Channel",
                columns: table => new
                {
                    channel_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    timezone = table.Column<DateTime>(nullable: false),
                    lifetime = table.Column<int>(nullable: false),
                    latitude = table.Column<int>(nullable: false),
                    longtitude = table.Column<int>(nullable: false),
                    elevation = table.Column<int>(nullable: false),
                    alarmsettingsemail = table.Column<string>(nullable: true),
                    created = table.Column<DateTime>(nullable: false),
                    updated = table.Column<DateTime>(nullable: false),
                    maxsize = table.Column<int>(nullable: false),
                    pcount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Channel", x => x.channel_id);
                    table.ForeignKey(
                        name: "FK_Channel_AlarmSettings_alarmsettingsemail",
                        column: x => x.alarmsettingsemail,
                        principalTable: "AlarmSettings",
                        principalColumn: "email",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "channels",
                columns: table => new
                {
                    ChannelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    channel_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_channels", x => x.ChannelId);
                    table.ForeignKey(
                        name: "FK_channels_Channel_channel_id",
                        column: x => x.channel_id,
                        principalTable: "Channel",
                        principalColumn: "channel_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Feeds",
                columns: table => new
                {
                    feed_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    label = table.Column<string>(nullable: true),
                    scale = table.Column<int>(nullable: false),
                    alarm = table.Column<int>(nullable: false),
                    enable_alarm = table.Column<int>(nullable: false),
                    alarm_settings = table.Column<string>(nullable: true),
                    channel_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feeds", x => x.feed_id);
                    table.ForeignKey(
                        name: "FK_Feeds_Channel_channel_id",
                        column: x => x.channel_id,
                        principalTable: "Channel",
                        principalColumn: "channel_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Points",
                columns: table => new
                {
                    pointid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    timestamp = table.Column<DateTime>(nullable: false),
                    value = table.Column<int>(nullable: false),
                    Feedsfeed_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Points", x => x.pointid);
                    table.ForeignKey(
                        name: "FK_Points_Feeds_Feedsfeed_id",
                        column: x => x.Feedsfeed_id,
                        principalTable: "Feeds",
                        principalColumn: "feed_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Channel_alarmsettingsemail",
                table: "Channel",
                column: "alarmsettingsemail");

            migrationBuilder.CreateIndex(
                name: "IX_channels_channel_id",
                table: "channels",
                column: "channel_id");

            migrationBuilder.CreateIndex(
                name: "IX_Feeds_channel_id",
                table: "Feeds",
                column: "channel_id");

            migrationBuilder.CreateIndex(
                name: "IX_Points_Feedsfeed_id",
                table: "Points",
                column: "Feedsfeed_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "channels");

            migrationBuilder.DropTable(
                name: "Points");

            migrationBuilder.DropTable(
                name: "Feeds");

            migrationBuilder.DropTable(
                name: "Channel");

            migrationBuilder.DropTable(
                name: "AlarmSettings");
        }
    }
}
