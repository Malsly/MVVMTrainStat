using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryUoW.Migrations
{
    public partial class Ticket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PassangerId = table.Column<int>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    VanIdId = table.Column<int>(nullable: true),
                    TrainIdId = table.Column<int>(nullable: true),
                    SeatIdId = table.Column<int>(nullable: true),
                    PlaceArrival = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ticket_Passanger_PassangerId",
                        column: x => x.PassangerId,
                        principalTable: "Passanger",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ticket_Seat_SeatIdId",
                        column: x => x.SeatIdId,
                        principalTable: "Seat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ticket_Train_TrainIdId",
                        column: x => x.TrainIdId,
                        principalTable: "Train",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ticket_Van_VanIdId",
                        column: x => x.VanIdId,
                        principalTable: "Van",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_PassangerId",
                table: "Ticket",
                column: "PassangerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_SeatIdId",
                table: "Ticket",
                column: "SeatIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_TrainIdId",
                table: "Ticket",
                column: "TrainIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_VanIdId",
                table: "Ticket",
                column: "VanIdId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticket");
        }
    }
}
