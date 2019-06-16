using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Practica2.Migrations
{
    public partial class Initial00 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gastos_Ingresos_IngresoAsociadoID",
                table: "Gastos");

            migrationBuilder.DropForeignKey(
                name: "FK_Gastos_Procedencias_ProcedenciaID",
                table: "Gastos");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingresos_Procedencias_ProcedenciaID",
                table: "Ingresos");

            migrationBuilder.DropTable(
                name: "Procedencias");

            migrationBuilder.DropIndex(
                name: "IX_Ingresos_ProcedenciaID",
                table: "Ingresos");

            migrationBuilder.DropIndex(
                name: "IX_Gastos_IngresoAsociadoID",
                table: "Gastos");

            migrationBuilder.DropIndex(
                name: "IX_Gastos_ProcedenciaID",
                table: "Gastos");

            migrationBuilder.DropColumn(
                name: "ProcedenciaID",
                table: "Ingresos");

            migrationBuilder.DropColumn(
                name: "ProcedenciaID",
                table: "Gastos");

            migrationBuilder.RenameColumn(
                name: "IngresoAsociadoID",
                table: "Gastos",
                newName: "IngresoAsociadoId");

            migrationBuilder.AlterColumn<string>(
                name: "IngresoAsociadoId",
                table: "Gastos",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IngresoAsociadoId",
                table: "Gastos",
                newName: "IngresoAsociadoID");

            migrationBuilder.AddColumn<int>(
                name: "ProcedenciaID",
                table: "Ingresos",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IngresoAsociadoID",
                table: "Gastos",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProcedenciaID",
                table: "Gastos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Procedencias",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedencias", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingresos_ProcedenciaID",
                table: "Ingresos",
                column: "ProcedenciaID");

            migrationBuilder.CreateIndex(
                name: "IX_Gastos_IngresoAsociadoID",
                table: "Gastos",
                column: "IngresoAsociadoID");

            migrationBuilder.CreateIndex(
                name: "IX_Gastos_ProcedenciaID",
                table: "Gastos",
                column: "ProcedenciaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Gastos_Ingresos_IngresoAsociadoID",
                table: "Gastos",
                column: "IngresoAsociadoID",
                principalTable: "Ingresos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Gastos_Procedencias_ProcedenciaID",
                table: "Gastos",
                column: "ProcedenciaID",
                principalTable: "Procedencias",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ingresos_Procedencias_ProcedenciaID",
                table: "Ingresos",
                column: "ProcedenciaID",
                principalTable: "Procedencias",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
