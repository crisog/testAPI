using Microsoft.EntityFrameworkCore.Migrations;

namespace Practica2.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gasto_Ingreso_IngresoAsociadoID",
                table: "Gasto");

            migrationBuilder.DropForeignKey(
                name: "FK_Gasto_Procedencia_ProcedenciaID",
                table: "Gasto");

            migrationBuilder.DropForeignKey(
                name: "FK_Gasto_Usuarios_UsuarioId",
                table: "Gasto");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingreso_Procedencia_ProcedenciaID",
                table: "Ingreso");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingreso_Usuarios_UsuarioId",
                table: "Ingreso");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Procedencia",
                table: "Procedencia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ingreso",
                table: "Ingreso");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gasto",
                table: "Gasto");

            migrationBuilder.RenameTable(
                name: "Procedencia",
                newName: "Procedencias");

            migrationBuilder.RenameTable(
                name: "Ingreso",
                newName: "Ingresos");

            migrationBuilder.RenameTable(
                name: "Gasto",
                newName: "Gastos");

            migrationBuilder.RenameIndex(
                name: "IX_Ingreso_UsuarioId",
                table: "Ingresos",
                newName: "IX_Ingresos_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Ingreso_ProcedenciaID",
                table: "Ingresos",
                newName: "IX_Ingresos_ProcedenciaID");

            migrationBuilder.RenameIndex(
                name: "IX_Gasto_UsuarioId",
                table: "Gastos",
                newName: "IX_Gastos_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Gasto_ProcedenciaID",
                table: "Gastos",
                newName: "IX_Gastos_ProcedenciaID");

            migrationBuilder.RenameIndex(
                name: "IX_Gasto_IngresoAsociadoID",
                table: "Gastos",
                newName: "IX_Gastos_IngresoAsociadoID");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Procedencias",
                table: "Procedencias",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ingresos",
                table: "Ingresos",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gastos",
                table: "Gastos",
                column: "ID");

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
                name: "FK_Gastos_Usuarios_UsuarioId",
                table: "Gastos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ingresos_Procedencias_ProcedenciaID",
                table: "Ingresos",
                column: "ProcedenciaID",
                principalTable: "Procedencias",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ingresos_Usuarios_UsuarioId",
                table: "Ingresos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gastos_Ingresos_IngresoAsociadoID",
                table: "Gastos");

            migrationBuilder.DropForeignKey(
                name: "FK_Gastos_Procedencias_ProcedenciaID",
                table: "Gastos");

            migrationBuilder.DropForeignKey(
                name: "FK_Gastos_Usuarios_UsuarioId",
                table: "Gastos");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingresos_Procedencias_ProcedenciaID",
                table: "Ingresos");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingresos_Usuarios_UsuarioId",
                table: "Ingresos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Procedencias",
                table: "Procedencias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ingresos",
                table: "Ingresos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gastos",
                table: "Gastos");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Procedencias",
                newName: "Procedencia");

            migrationBuilder.RenameTable(
                name: "Ingresos",
                newName: "Ingreso");

            migrationBuilder.RenameTable(
                name: "Gastos",
                newName: "Gasto");

            migrationBuilder.RenameIndex(
                name: "IX_Ingresos_UsuarioId",
                table: "Ingreso",
                newName: "IX_Ingreso_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Ingresos_ProcedenciaID",
                table: "Ingreso",
                newName: "IX_Ingreso_ProcedenciaID");

            migrationBuilder.RenameIndex(
                name: "IX_Gastos_UsuarioId",
                table: "Gasto",
                newName: "IX_Gasto_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Gastos_ProcedenciaID",
                table: "Gasto",
                newName: "IX_Gasto_ProcedenciaID");

            migrationBuilder.RenameIndex(
                name: "IX_Gastos_IngresoAsociadoID",
                table: "Gasto",
                newName: "IX_Gasto_IngresoAsociadoID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Procedencia",
                table: "Procedencia",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ingreso",
                table: "Ingreso",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gasto",
                table: "Gasto",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Gasto_Ingreso_IngresoAsociadoID",
                table: "Gasto",
                column: "IngresoAsociadoID",
                principalTable: "Ingreso",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Gasto_Procedencia_ProcedenciaID",
                table: "Gasto",
                column: "ProcedenciaID",
                principalTable: "Procedencia",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Gasto_Usuarios_UsuarioId",
                table: "Gasto",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ingreso_Procedencia_ProcedenciaID",
                table: "Ingreso",
                column: "ProcedenciaID",
                principalTable: "Procedencia",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ingreso_Usuarios_UsuarioId",
                table: "Ingreso",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
