using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAPI.Migrations
{
    /// <inheritdoc />
    public partial class secondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_SaleOrder_SaleOrderId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleOrder_Users_UserId",
                table: "SaleOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SaleOrder",
                table: "SaleOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_SaleOrderId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Product");

            migrationBuilder.RenameTable(
                name: "SaleOrder",
                newName: "SaleOrders");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_SaleOrder_UserId",
                table: "SaleOrders",
                newName: "IX_SaleOrders_UserId");

            migrationBuilder.RenameColumn(
                name: "SaleOrderId",
                table: "Products",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Products",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaleOrders",
                table: "SaleOrders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SaleOrders_Users_UserId",
                table: "SaleOrders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleOrders_Users_UserId",
                table: "SaleOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SaleOrders",
                table: "SaleOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "SaleOrders",
                newName: "SaleOrder");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameIndex(
                name: "IX_SaleOrders_UserId",
                table: "SaleOrder",
                newName: "IX_SaleOrder_UserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Product",
                newName: "SaleOrderId");

            migrationBuilder.AlterColumn<int>(
                name: "SaleOrderId",
                table: "Product",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Product",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaleOrder",
                table: "SaleOrder",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SaleOrderId",
                table: "Product",
                column: "SaleOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_SaleOrder_SaleOrderId",
                table: "Product",
                column: "SaleOrderId",
                principalTable: "SaleOrder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleOrder_Users_UserId",
                table: "SaleOrder",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
