using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TEMA_MEDII_ROCA_RARES_GEORGE.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ServicesType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicesType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ServiceAppointment",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceID = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceAppointment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ServiceAppointment_Service_ServiceID",
                        column: x => x.ServiceID,
                        principalTable: "Service",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ServiceDetail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceID = table.Column<int>(type: "int", nullable: false),
                    ServiceTypeIDs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServicesTypeID = table.Column<int>(type: "int", nullable: false),
                    PaymentCash = table.Column<bool>(type: "bit", nullable: false),
                    PaymentCard = table.Column<bool>(type: "bit", nullable: false),
                    WaitingZone = table.Column<bool>(type: "bit", nullable: false),
                    LuniStartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LuniEndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LuniClosed = table.Column<bool>(type: "bit", nullable: false),
                    MartiStartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MartiEndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MartiClosed = table.Column<bool>(type: "bit", nullable: false),
                    MiercuriStartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MiercuriEndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MiercuriClosed = table.Column<bool>(type: "bit", nullable: false),
                    JoiStartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    JoiEndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    JoiClosed = table.Column<bool>(type: "bit", nullable: false),
                    VineriStartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VineriEndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VineriClosed = table.Column<bool>(type: "bit", nullable: false),
                    SambataStartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SambataEndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SambataClosed = table.Column<bool>(type: "bit", nullable: false),
                    DuminicaStartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DuminicaEndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DuminicaClosed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceDetail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ServiceDetail_Service_ServiceID",
                        column: x => x.ServiceID,
                        principalTable: "Service",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceDetail_ServicesType_ServicesTypeID",
                        column: x => x.ServicesTypeID,
                        principalTable: "ServicesType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ServiceAppointment_ServiceID",
                table: "ServiceAppointment",
                column: "ServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceDetail_ServiceID",
                table: "ServiceDetail",
                column: "ServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceDetail_ServicesTypeID",
                table: "ServiceDetail",
                column: "ServicesTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServiceAppointment");

            migrationBuilder.DropTable(
                name: "ServiceDetail");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "ServicesType");
        }
    }
}
