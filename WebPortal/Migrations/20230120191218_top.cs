using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebPortal.Migrations
{
    /// <inheritdoc />
    public partial class top : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    usuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuarioNome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    usuarioSobrenome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    usuarioTelefone = table.Column<int>(type: "int", nullable: false),
                    usuarioEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    usuarioSenha = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    usuarioConfirmarSenha = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    usuarioDataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.usuarioId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "usuario");
        }
    }
}
