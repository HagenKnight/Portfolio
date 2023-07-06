using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Infrastructure.Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixOnAptitude : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "Aptitude");

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "AptitudeOnResume",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "AptitudeOnProject",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8113));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8495));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 875, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 876, DateTimeKind.Local).AddTicks(1799));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 21, 19, 20, 13, 876, DateTimeKind.Local).AddTicks(1806));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "AptitudeOnResume");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "AptitudeOnProject");

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "Aptitude",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5598));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5797));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5801));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5885));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5892));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5895));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5968));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(7396));
        }
    }
}
