using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Infrastructure.Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProjectEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aptitude",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aptitude", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Interest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WorkerProfileId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Interest_WorkerProfile_WorkerProfileId",
                        column: x => x.WorkerProfileId,
                        principalTable: "WorkerProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<int>(type: "int", nullable: false),
                    WorkerProfileId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Language_WorkerProfile_WorkerProfileId",
                        column: x => x.WorkerProfileId,
                        principalTable: "WorkerProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClientName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StartDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FinishDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Url = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Testimonial = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WorkerProfileId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Project_WorkerProfile_WorkerProfileId",
                        column: x => x.WorkerProfileId,
                        principalTable: "WorkerProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AptitudeOnResume",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AptitudeId = table.Column<int>(type: "int", nullable: false),
                    ResumeId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptitudeOnResume", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AptitudeOnResume_Aptitude_AptitudeId",
                        column: x => x.AptitudeId,
                        principalTable: "Aptitude",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AptitudeOnResume_Resume_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resume",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AptitudeOnProject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AptitudeId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptitudeOnProject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AptitudeOnProject_Aptitude_AptitudeId",
                        column: x => x.AptitudeId,
                        principalTable: "Aptitude",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AptitudeOnProject_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Multimedia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Url = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Multimedia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Multimedia_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9103));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 7, 21, 20, 20, 305, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.CreateIndex(
                name: "IX_AptitudeOnProject_AptitudeId",
                table: "AptitudeOnProject",
                column: "AptitudeId");

            migrationBuilder.CreateIndex(
                name: "IX_AptitudeOnProject_ProjectId",
                table: "AptitudeOnProject",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_AptitudeOnResume_AptitudeId",
                table: "AptitudeOnResume",
                column: "AptitudeId");

            migrationBuilder.CreateIndex(
                name: "IX_AptitudeOnResume_ResumeId",
                table: "AptitudeOnResume",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Interest_WorkerProfileId",
                table: "Interest",
                column: "WorkerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Language_WorkerProfileId",
                table: "Language",
                column: "WorkerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Multimedia_ProjectId",
                table: "Multimedia",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_WorkerProfileId",
                table: "Project",
                column: "WorkerProfileId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AptitudeOnProject");

            migrationBuilder.DropTable(
                name: "AptitudeOnResume");

            migrationBuilder.DropTable(
                name: "Interest");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "Multimedia");

            migrationBuilder.DropTable(
                name: "Aptitude");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7527));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7836));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8033));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8402));
        }
    }
}
