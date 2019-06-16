using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Practica2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Procedencia",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedencia", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingreso",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Monto = table.Column<double>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    ProcedenciaID = table.Column<int>(nullable: true),
                    TipoTransaccion = table.Column<int>(nullable: false),
                    FechaRegistro = table.Column<string>(nullable: true),
                    FechaEstimada = table.Column<string>(nullable: true),
                    UsuarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingreso", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ingreso_Procedencia_ProcedenciaID",
                        column: x => x.ProcedenciaID,
                        principalTable: "Procedencia",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ingreso_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Gasto",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Monto = table.Column<double>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    ProcedenciaID = table.Column<int>(nullable: true),
                    TipoTransaccion = table.Column<int>(nullable: false),
                    FechaRegistro = table.Column<string>(nullable: true),
                    IngresoAsociadoID = table.Column<string>(nullable: true),
                    UsuarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gasto", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Gasto_Ingreso_IngresoAsociadoID",
                        column: x => x.IngresoAsociadoID,
                        principalTable: "Ingreso",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Gasto_Procedencia_ProcedenciaID",
                        column: x => x.ProcedenciaID,
                        principalTable: "Procedencia",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Gasto_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gasto_IngresoAsociadoID",
                table: "Gasto",
                column: "IngresoAsociadoID");

            migrationBuilder.CreateIndex(
                name: "IX_Gasto_ProcedenciaID",
                table: "Gasto",
                column: "ProcedenciaID");

            migrationBuilder.CreateIndex(
                name: "IX_Gasto_UsuarioId",
                table: "Gasto",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingreso_ProcedenciaID",
                table: "Ingreso",
                column: "ProcedenciaID");

            migrationBuilder.CreateIndex(
                name: "IX_Ingreso_UsuarioId",
                table: "Ingreso",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gasto");

            migrationBuilder.DropTable(
                name: "Ingreso");

            migrationBuilder.DropTable(
                name: "Procedencia");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
