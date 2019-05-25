using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aeroportos.Context.Migrations
{
    public partial class InicioBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbAeroportos");

            migrationBuilder.CreateTable(
                name: "PAIS",
                schema: "dbAeroportos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GUID = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    DATA_CRIACAO = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    DATA_MODIFICACAO = table.Column<DateTime>(nullable: true),
                    DATA_EXCLUSAO = table.Column<DateTime>(nullable: true),
                    EXCLUIDO = table.Column<bool>(nullable: false),
                    SIGLA = table.Column<string>(maxLength: 5, nullable: false),
                    DESCRICAO = table.Column<string>(maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PAIS", x => x.ID);
                    table.UniqueConstraint("AK_PAIS_GUID", x => x.GUID);
                    table.UniqueConstraint("AK_PAIS_SIGLA", x => x.SIGLA);
                });

            migrationBuilder.CreateTable(
                name: "TIPO_AEROPORTO",
                schema: "dbAeroportos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GUID = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    DATA_CRIACAO = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    DATA_MODIFICACAO = table.Column<DateTime>(nullable: true),
                    DATA_EXCLUSAO = table.Column<DateTime>(nullable: true),
                    EXCLUIDO = table.Column<bool>(nullable: false),
                    SIGLA = table.Column<string>(maxLength: 5, nullable: false),
                    DESCRICAO = table.Column<string>(maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPO_AEROPORTO", x => x.ID);
                    table.UniqueConstraint("AK_TIPO_AEROPORTO_GUID", x => x.GUID);
                    table.UniqueConstraint("AK_TIPO_AEROPORTO_SIGLA", x => x.SIGLA);
                });

            migrationBuilder.CreateTable(
                name: "ESTADO",
                schema: "dbAeroportos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GUID = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    DATA_CRIACAO = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    DATA_MODIFICACAO = table.Column<DateTime>(nullable: true),
                    DATA_EXCLUSAO = table.Column<DateTime>(nullable: true),
                    EXCLUIDO = table.Column<bool>(nullable: false),
                    SIGLA = table.Column<string>(maxLength: 5, nullable: false),
                    DESCRICAO = table.Column<string>(maxLength: 5, nullable: false),
                    PAIS_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESTADO", x => x.ID);
                    table.UniqueConstraint("AK_ESTADO_GUID", x => x.GUID);
                    table.UniqueConstraint("AK_ESTADO_SIGLA", x => x.SIGLA);
                    table.ForeignKey(
                        name: "FK_ESTADO_PAIS_PAIS_ID",
                        column: x => x.PAIS_ID,
                        principalSchema: "dbAeroportos",
                        principalTable: "PAIS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CIDADE",
                schema: "dbAeroportos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GUID = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    DATA_CRIACAO = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    DATA_MODIFICACAO = table.Column<DateTime>(nullable: true),
                    DATA_EXCLUSAO = table.Column<DateTime>(nullable: true),
                    EXCLUIDO = table.Column<bool>(nullable: false),
                    SIGLA = table.Column<string>(maxLength: 5, nullable: false),
                    DESCRICAO = table.Column<string>(maxLength: 5, nullable: false),
                    ESTADO_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIDADE", x => x.ID);
                    table.UniqueConstraint("AK_CIDADE_GUID", x => x.GUID);
                    table.ForeignKey(
                        name: "FK_CIDADE_ESTADO_ESTADO_ID",
                        column: x => x.ESTADO_ID,
                        principalSchema: "dbAeroportos",
                        principalTable: "ESTADO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ENDERECO",
                schema: "dbAeroportos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GUID = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    DATA_CRIACAO = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    DATA_MODIFICACAO = table.Column<DateTime>(nullable: true),
                    DATA_EXCLUSAO = table.Column<DateTime>(nullable: true),
                    EXCLUIDO = table.Column<bool>(nullable: false),
                    CEP = table.Column<string>(maxLength: 8, nullable: false),
                    LOGRADOURO = table.Column<string>(maxLength: 100, nullable: false),
                    NUMERO = table.Column<int>(nullable: false),
                    COMPLEMENTO = table.Column<string>(maxLength: 50, nullable: true),
                    BAIRRO = table.Column<string>(maxLength: 50, nullable: false),
                    CIDADE_ID = table.Column<int>(nullable: false),
                    AEROPORTO_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENDERECO", x => x.ID);
                    table.UniqueConstraint("AK_ENDERECO_GUID", x => x.GUID);
                    table.ForeignKey(
                        name: "FK_ENDERECO_CIDADE_CIDADE_ID",
                        column: x => x.CIDADE_ID,
                        principalSchema: "dbAeroportos",
                        principalTable: "CIDADE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AEROPORTO",
                schema: "dbAeroportos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GUID = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    DATA_CRIACAO = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    DATA_MODIFICACAO = table.Column<DateTime>(nullable: true),
                    DATA_EXCLUSAO = table.Column<DateTime>(nullable: true),
                    EXCLUIDO = table.Column<bool>(nullable: false),
                    CODIGO_ICAO = table.Column<string>(maxLength: 5, nullable: false),
                    NOME = table.Column<string>(maxLength: 100, nullable: false),
                    DESCRICAO = table.Column<string>(maxLength: 500, nullable: false),
                    TIPO_AEROPORTO_ID = table.Column<int>(nullable: false),
                    ENDERECO_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AEROPORTO", x => x.ID);
                    table.UniqueConstraint("AK_AEROPORTO_CODIGO_ICAO", x => x.CODIGO_ICAO);
                    table.UniqueConstraint("AK_AEROPORTO_GUID", x => x.GUID);
                    table.ForeignKey(
                        name: "FK_AEROPORTO_ENDERECO_ENDERECO_ID",
                        column: x => x.ENDERECO_ID,
                        principalSchema: "dbAeroportos",
                        principalTable: "ENDERECO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AEROPORTO_TIPO_AEROPORTO_TIPO_AEROPORTO_ID",
                        column: x => x.TIPO_AEROPORTO_ID,
                        principalSchema: "dbAeroportos",
                        principalTable: "TIPO_AEROPORTO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AEROPORTO_ENDERECO_ID",
                schema: "dbAeroportos",
                table: "AEROPORTO",
                column: "ENDERECO_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AEROPORTO_TIPO_AEROPORTO_ID",
                schema: "dbAeroportos",
                table: "AEROPORTO",
                column: "TIPO_AEROPORTO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CIDADE_ESTADO_ID",
                schema: "dbAeroportos",
                table: "CIDADE",
                column: "ESTADO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ENDERECO_CIDADE_ID",
                schema: "dbAeroportos",
                table: "ENDERECO",
                column: "CIDADE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ESTADO_PAIS_ID",
                schema: "dbAeroportos",
                table: "ESTADO",
                column: "PAIS_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AEROPORTO",
                schema: "dbAeroportos");

            migrationBuilder.DropTable(
                name: "ENDERECO",
                schema: "dbAeroportos");

            migrationBuilder.DropTable(
                name: "TIPO_AEROPORTO",
                schema: "dbAeroportos");

            migrationBuilder.DropTable(
                name: "CIDADE",
                schema: "dbAeroportos");

            migrationBuilder.DropTable(
                name: "ESTADO",
                schema: "dbAeroportos");

            migrationBuilder.DropTable(
                name: "PAIS",
                schema: "dbAeroportos");
        }
    }
}
