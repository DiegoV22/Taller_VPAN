using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taller_VPAN.Migrations
{
    /// <inheritdoc />
    public partial class Taller1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Motor",
                columns: table => new
                {
                    IdMotor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoMotor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CaballosFuerza = table.Column<int>(type: "int", nullable: false),
                    AnioFabricacion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motor", x => x.IdMotor);
                });

            migrationBuilder.CreateTable(
                name: "Auto",
                columns: table => new
                {
                    IdA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumPuertas = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Anio = table.Column<int>(type: "int", nullable: false),
                    IdMotor = table.Column<int>(type: "int", nullable: false),
                    MotorIdMotor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auto", x => x.IdA);
                    table.ForeignKey(
                        name: "FK_Auto_Motor_MotorIdMotor",
                        column: x => x.MotorIdMotor,
                        principalTable: "Motor",
                        principalColumn: "IdMotor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Propietario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<int>(type: "int", nullable: false),
                    EsEcuatoriano = table.Column<bool>(type: "bit", nullable: false),
                    IdA = table.Column<int>(type: "int", nullable: false),
                    AutoIdA = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propietario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Propietario_Auto_AutoIdA",
                        column: x => x.AutoIdA,
                        principalTable: "Auto",
                        principalColumn: "IdA",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Auto_MotorIdMotor",
                table: "Auto",
                column: "MotorIdMotor");

            migrationBuilder.CreateIndex(
                name: "IX_Propietario_AutoIdA",
                table: "Propietario",
                column: "AutoIdA");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Propietario");

            migrationBuilder.DropTable(
                name: "Auto");

            migrationBuilder.DropTable(
                name: "Motor");
        }
    }
}
