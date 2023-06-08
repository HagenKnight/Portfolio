using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Infrastructure.Identity.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProjectEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a62397d8-ce0d-4dfe-a2ff-684f581b2488",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2628642-71e2-4acf-b095-8ac057e62cad", "AQAAAAIAAYagAAAAEL295xMblFwIE2rIaU/24f2x3xDIHB1e+7qN1CsI3matsKACuiMGJzs5SBUPYomxJQ==", "267abaec-9a24-4284-8348-68d4b2bc6de7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d10fb303-28e4-4e13-a678-7dc5f3a134ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1da9bc3-6a85-435f-bd42-be5ecb92c7dc", "AQAAAAIAAYagAAAAEMmLjkAZVvakU7cptsObocmn2YFoz/lWqB6hRF/Vx8aOs4yPU4EDTrUhD5L3hLOkog==", "496a398d-4607-492c-a7cc-d0d6f11764f7" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a62397d8-ce0d-4dfe-a2ff-684f581b2488",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fbcce583-cac1-4101-9e11-a2350261ef6d", "AQAAAAIAAYagAAAAEIxoXMUMIgbpzuJCA7FB2ix0/1em17+oszgzBuSt9be7mlS+248/CC19R+yGaN/+jQ==", "3333e887-da07-4429-9d3d-d7adcfb1d489" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d10fb303-28e4-4e13-a678-7dc5f3a134ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "124ceda1-38a1-4064-bf7a-44a59ebf114e", "AQAAAAIAAYagAAAAEO/1uq1JI2MO85NFnOJH3Xdg8vX+5be8cyWDWf76OTGYObJ8BKExFi7uJl2AM6p+Rg==", "60f918a9-e29a-4e13-97cc-7716588e6acf" });
        }
    }
}
