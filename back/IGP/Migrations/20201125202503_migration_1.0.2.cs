using Microsoft.EntityFrameworkCore.Migrations;

namespace IGP.Migrations
{
    public partial class migration_102 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cargo",
                columns: new[] { "CargoID", "Nombre" },
                values: new object[,]
                {
                    { 1, "Gerente" },
                    { 2, "Vendedor" },
                    { 3, "Coordinador" },
                    { 4, "SubGerente" }
                });

            migrationBuilder.InsertData(
                table: "Empleado",
                columns: new[] { "EmpleadoID", "Apellido", "CargoID", "DocIdentidad", "Nombre" },
                values: new object[,]
                {
                    { 1, "Calambas", 1, 1061732742.0, "Manuel" },
                    { 3, "Bedoya", 2, 1054765323.0, "Arturo" },
                    { 4, "Calambas", 3, 34323432.0, "Alejandra" },
                    { 2, "Giraldo", 4, 34319349.0, "Martha" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Empleado",
                keyColumn: "EmpleadoID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Empleado",
                keyColumn: "EmpleadoID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Empleado",
                keyColumn: "EmpleadoID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Empleado",
                keyColumn: "EmpleadoID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cargo",
                keyColumn: "CargoID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cargo",
                keyColumn: "CargoID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cargo",
                keyColumn: "CargoID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cargo",
                keyColumn: "CargoID",
                keyValue: 4);
        }
    }
}
