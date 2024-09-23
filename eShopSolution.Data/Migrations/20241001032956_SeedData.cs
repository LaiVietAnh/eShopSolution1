using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eShopSolution.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryTranslations_Category_CategoryId",
                table: "CategoryTranslations");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInCategories_Category_CategoryId",
                table: "ProductInCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "SeoAlias",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "ID");

            migrationBuilder.InsertData(
                table: "AppConfigs",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "HomeDescription", "This is description of eShopSolution" },
                    { "HomeKeyword", "This is keyword of eShopSolution" },
                    { "HomeTitle", "This is home page of eShopSolution" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "IsShowOnHome", "ParentID", "SortOrder", "Status" },
                values: new object[,]
                {
                    { 1, true, null, 1, 1 },
                    { 2, true, null, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "IsDefault", "Name" },
                values: new object[,]
                {
                    { "en-US", true, "English" },
                    { "vi-VN", true, "Tieng Viet" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateCreated", "OriginalPrice", "Price" },
                values: new object[] { 1, new DateTime(2024, 10, 1, 10, 29, 55, 956, DateTimeKind.Local).AddTicks(5013), 100000m, 200000m });

            migrationBuilder.InsertData(
                table: "CategoryTranslations",
                columns: new[] { "Id", "CategoryId", "LanguageId", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 1, 1, "vi-VN", "Áo nam", "ao-nam", "Sản phẩm áo thời trang nam", "Sản phẩm áo thời trang nam" },
                    { 2, 1, "en-US", "Men Shirt", "men-shirt", "The shirt product for men", "The shirt product for men" },
                    { 3, 2, "vi-VN", "Áo nữ", "ao-nam", "Sản phẩm áo thời trang nữ", "Sản phẩm áo thời trang nữ" },
                    { 4, 2, "en-US", "Women Shirt", "women-shirt", "The shirt product for women", "The shirt product for women" }
                });

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "ProductTranslations",
                columns: new[] { "Id", "Description", "Details", "LanguageId", "Name", "ProductId", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 1, "Mô tả sản phẩm", "Mô tả sản phẩm", "vi-VN", "Áo nam", 1, "ao-nam", "Sản phẩm áo thời trang nam", "Sản phẩm áo thời trang nam" },
                    { 2, "Description of product", "Description of product", "en-US", "Men Shirt", 1, "men-shirt", "The shirt product for men", "The shirt product for men" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryTranslations_Categories_CategoryId",
                table: "CategoryTranslations",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInCategories_Categories_CategoryId",
                table: "ProductInCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryTranslations_Categories_CategoryId",
                table: "CategoryTranslations");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInCategories_Categories_CategoryId",
                table: "ProductInCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeDescription");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeKeyword");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeTitle");

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "en-US");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "vi-VN");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.AddColumn<string>(
                name: "SeoAlias",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryTranslations_Category_CategoryId",
                table: "CategoryTranslations",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInCategories_Category_CategoryId",
                table: "ProductInCategories",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
