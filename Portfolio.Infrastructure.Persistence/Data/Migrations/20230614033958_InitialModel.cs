using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Portfolio.Infrastructure.Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Aptitude",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
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
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NameEs = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NameEn = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ISO2 = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ISO3 = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
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
                    table.PrimaryKey("PK_Country", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NameEn = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NameEs = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ResumeType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
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
                    table.PrimaryKey("PK_ResumeType", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WorkerProfile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AboutMe = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BirthDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Email = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CountryId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_WorkerProfile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkerProfile_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Certificate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Duration = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IssueDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CertificateNumber = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CertificateUrl = table.Column<string>(type: "longtext", nullable: false)
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
                    table.PrimaryKey("PK_Certificate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Certificate_WorkerProfile_WorkerProfileId",
                        column: x => x.WorkerProfileId,
                        principalTable: "WorkerProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Interest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
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
                name: "LanguagesOnWorkerProfile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_LanguagesOnWorkerProfile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LanguagesOnWorkerProfile_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguagesOnWorkerProfile_WorkerProfile_WorkerProfileId",
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
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClientName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
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
                name: "Resume",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    InstitutionName = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Title = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StartDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FinishDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WorkerProfileId = table.Column<int>(type: "int", nullable: false),
                    ResumeTypeId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Resume", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resume_ResumeType_ResumeTypeId",
                        column: x => x.ResumeTypeId,
                        principalTable: "ResumeType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Resume_WorkerProfile_WorkerProfileId",
                        column: x => x.WorkerProfileId,
                        principalTable: "WorkerProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
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
                    table.PrimaryKey("PK_Service", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Service_WorkerProfile_WorkerProfileId",
                        column: x => x.WorkerProfileId,
                        principalTable: "WorkerProfile",
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

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeleteDate", "DeletedBy", "ISO2", "ISO3", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "NameEn", "NameEs" },
                values: new object[,]
                {
                    { 1, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5355), null, null, "AD", "AND", false, null, null, "Andorra", "Andorra" },
                    { 2, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5371), null, null, "AE", "ARE", false, null, null, "United Arab Emirates", "Emiratos Árabes Unidos" },
                    { 3, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5373), null, null, "AF", "AFG", false, null, null, "Afghanistan", "Afganistán" },
                    { 4, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5376), null, null, "AG", "ATG", false, null, null, "Antigua and Barbuda", "Antigua y Barbuda" },
                    { 5, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5378), null, null, "AI", "AIA", false, null, null, "Anguila", "Anguila" },
                    { 6, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5399), null, null, "AL", "ALB", false, null, null, "Albania", "Albania" },
                    { 7, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5401), null, null, "AM", "ARM", false, null, null, "Armenia", "Armenia" },
                    { 8, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5403), null, null, "AN", "ANT", false, null, null, "Netherlands Antilles", "Antillas Holandesas" },
                    { 9, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5406), null, null, "AO", "AGO", false, null, null, "Angola", "Angola" },
                    { 10, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5408), null, null, "AQ", "ATA", false, null, null, "Antarctica", "Antártida" },
                    { 11, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5414), null, null, "AR", "ARG", false, null, null, "Argentina", "Argentina" },
                    { 12, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5418), null, null, "AS", "ASM", false, null, null, "Samoa American", "Samoa Americana" },
                    { 13, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5420), null, null, "AT", "AUT", false, null, null, "Austria", "Austria" },
                    { 14, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5423), null, null, "AU", "AUS", false, null, null, "Australia", "Australia" },
                    { 15, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5425), null, null, "AW", "ABW", false, null, null, "Aruba", "Aruba" },
                    { 16, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5427), null, null, "AX", "ALA", false, null, null, "Aland Islands", "Islas Aland" },
                    { 17, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5429), null, null, "AZ", "AZE", false, null, null, "Azerbaijan", "Azerbaiyán" },
                    { 18, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5432), null, null, "BA", "BIH", false, null, null, "Bosnia and Herzegovina", "Bosnia y Herzegovina" },
                    { 19, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5434), null, null, "BB", "BRB", false, null, null, "Barbados", "Barbados" },
                    { 20, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5436), null, null, "BD", "BGD", false, null, null, "Bangladesh", "Bangladesh" },
                    { 21, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5438), null, null, "BE", "BEL", false, null, null, "Belgium", "Bélgica" },
                    { 22, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5440), null, null, "BF", "BFA", false, null, null, "Burkina Faso", "Burkina Faso" },
                    { 23, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5442), null, null, "BG", "BGR", false, null, null, "Bulgaria", "Bulgaria" },
                    { 24, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5444), null, null, "BH", "BHR", false, null, null, "Bahrein", "Bahrein" },
                    { 25, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5447), null, null, "BI", "BDI", false, null, null, "Burundi", "Burundi" },
                    { 26, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5449), null, null, "BJ", "BEN", false, null, null, "Benin", "Benín" },
                    { 27, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5451), null, null, "BM", "BMU", false, null, null, "Bermudas", "Bermudas" },
                    { 28, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5453), null, null, "BN", "BRN", false, null, null, "Brunei", "Brunei" },
                    { 29, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5455), null, null, "BO", "BOL", false, null, null, "Bolivia", "Bolivia" },
                    { 30, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5457), null, null, "BR", "BRA", false, null, null, "Brazil", "Brasil" },
                    { 31, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5459), null, null, "BS", "BHS", false, null, null, "Bahamas", "Bahamas" },
                    { 32, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5461), null, null, "BT", "BTN", false, null, null, "Buthan", "Bután" },
                    { 33, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5463), null, null, "BV", "BVT", false, null, null, "Bouvet Island", "Isla Bouvet" },
                    { 34, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5472), null, null, "BW", "BWA", false, null, null, "Botswana", "Botswana" },
                    { 35, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5474), null, null, "BY", "BLR", false, null, null, "Belarus", "Bielorusia" },
                    { 36, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5476), null, null, "BZ", "BLZ", false, null, null, "Belize", "Belice" },
                    { 37, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5478), null, null, "CA", "CAN", false, null, null, "Canada", "Canadá" },
                    { 38, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5480), null, null, "CC", "CCK", false, null, null, "Cocos (Keeling) Islands", "Islas Cocos" },
                    { 39, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5482), null, null, "CD", "COD", false, null, null, "Democratic Republic of the Congo", "Republica Democrática del Congo" },
                    { 40, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5484), null, null, "CF", "CAF", false, null, null, "Central African Republic", "República Centrofricana" },
                    { 41, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5487), null, null, "CG", "COG", false, null, null, "Republia of Congo", "República del Congo" },
                    { 42, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5489), null, null, "CH", "CHE", false, null, null, "Switzerland", "Suiza" },
                    { 43, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5491), null, null, "CI", "CIV", false, null, null, "Ivory Coast", "Costa de Marfil" },
                    { 44, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5493), null, null, "CK", "COK", false, null, null, "Cook Islands", "Islas Cook" },
                    { 45, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5498), null, null, "CL", "CHL", false, null, null, "Chile", "Chile" },
                    { 46, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5504), null, null, "CM", "CMR", false, null, null, "Cameroon", "Camerún" },
                    { 47, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5506), null, null, "CN", "CHN", false, null, null, "China", "China" },
                    { 48, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5508), null, null, "CO", "COL", false, null, null, "Colombia", "Colombia" },
                    { 49, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5510), null, null, "CR", "CRI", false, null, null, "Costa Rica", "Costa Rica" },
                    { 50, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5513), null, null, "CU", "CUB", false, null, null, "Cuba", "Cuba" },
                    { 51, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5515), null, null, "CV", "CPV", false, null, null, "Green Cape", "Cabo Verde" },
                    { 52, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5517), null, null, "CX", "CXR", false, null, null, "Christmas Island", "Isla de Navidad" },
                    { 53, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5519), null, null, "CY", "CYP", false, null, null, "Cyprus", "Chipre" },
                    { 54, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5521), null, null, "CZ", "CZE", false, null, null, "Czech Republic", "República Checa" },
                    { 55, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5524), null, null, "DE", "DEU", false, null, null, "Germany", "Alemania" },
                    { 56, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5526), null, null, "DJ", "DJI", false, null, null, "Djibouti ", "Yibuti" },
                    { 57, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5529), null, null, "DK", "DNK", false, null, null, "Denkmark", "Dinamarca" },
                    { 58, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5531), null, null, "DM", "DMA", false, null, null, "Dominica", "Dominica" },
                    { 59, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5534), null, null, "DO", "DOM", false, null, null, "Dominican Republic", "República Dominicana" },
                    { 60, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5537), null, null, "DZ", "DZA", false, null, null, "Argelia", "Argelia" },
                    { 61, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5539), null, null, "EC", "ECU", false, null, null, "Ecuador", "Ecuador" },
                    { 62, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5542), null, null, "EE", "EST", false, null, null, "Estonia", "Estonia" },
                    { 63, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5544), null, null, "EG", "EGY", false, null, null, "Egypt", "Egipto" },
                    { 64, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5546), null, null, "EH", "ESH", false, null, null, "Western Sahara", "Sahara Occidental" },
                    { 65, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5548), null, null, "ER", "ERI", false, null, null, "Eritrea", "Eritrea" },
                    { 66, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5562), null, null, "ES", "ESP", false, null, null, "Spain", "España" },
                    { 67, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5564), null, null, "ET", "ETH", false, null, null, "Ethiopia", "Etiopía" },
                    { 68, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5570), null, null, "FI", "FIN", false, null, null, "Finland", "Finlandia" },
                    { 69, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5573), null, null, "FJ", "FJI", false, null, null, "Fiji ", "Fiji" },
                    { 70, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5575), null, null, "FK", "FLK", false, null, null, "Falkland Islands", "Islas Malvinas" },
                    { 71, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5578), null, null, "FM", "FSM", false, null, null, " ", "Micronesia" },
                    { 72, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5580), null, null, "FO", "FRO", false, null, null, "Faroe Islands", "Islas Faroe" },
                    { 73, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5582), null, null, "FR", "FRA", false, null, null, "France", "Francia" },
                    { 74, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5585), null, null, "GA", "GAB", false, null, null, "Gabon", "Gabón" },
                    { 75, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5587), null, null, "GB", "GBR", false, null, null, "United Kingdom", "Reino Unido" },
                    { 76, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5589), null, null, "GD", "GRD", false, null, null, "Grenada", "Granada" },
                    { 77, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5591), null, null, "GE", "GEO", false, null, null, "Georgia", "Georgia" },
                    { 78, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5593), null, null, "GF", "GUF", false, null, null, "French Guiana", "Guayana Francesa" },
                    { 79, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5595), null, null, "GG", "GGY", false, null, null, "Guernsey", "Guernsey" },
                    { 80, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5598), null, null, "GH", "GHA", false, null, null, "Ghana", "Ghana" },
                    { 81, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5601), null, null, "GI", "GIB", false, null, null, "Gibraltar", "Gibraltar" },
                    { 82, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5608), null, null, "GL", "GRL", false, null, null, "Greenland", "Groenlandia" },
                    { 83, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5610), null, null, "GM", "GMB", false, null, null, "Gambia", "Gambia" },
                    { 84, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5612), null, null, "GN", "GIN", false, null, null, "Guinea", "Guinea" },
                    { 85, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5615), null, null, "GP", "GLP", false, null, null, "Guadeloupe", "Guadalupe" },
                    { 86, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5617), null, null, "GQ", "GNQ", false, null, null, "Equatorial Guinea", "Guinea Ecuatorial" },
                    { 87, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5620), null, null, "GR", "GRC", false, null, null, "Greece", "Grecia" },
                    { 88, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5622), null, null, "GS", "SGS", false, null, null, "South Georgia and the South Sandwich Islands", "Georgia del Sur y las islas Sandwich" },
                    { 89, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5624), null, null, "GT", "GTM", false, null, null, "Guatemala", "Guatemala" },
                    { 90, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5626), null, null, "GU", "GUM", false, null, null, "Guam", "Guam" },
                    { 91, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5628), null, null, "GW", "GNB", false, null, null, "Guinea-Bissau", "Guinea-Bissau" },
                    { 92, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5630), null, null, "GY", "GUY", false, null, null, "Guyana", "Guyana" },
                    { 93, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5633), null, null, "HK", "HKG", false, null, null, "Hong Kong", "Hong Kong" },
                    { 94, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5635), null, null, "HM", "HMD", false, null, null, "Herd and McDonald Islands", "Islas Heard y McDonald" },
                    { 95, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5637), null, null, "HN", "HND", false, null, null, "Honduras", "Honduras" },
                    { 96, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5639), null, null, "HR", "HRV", false, null, null, "Croatia", "Croacia" },
                    { 97, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5642), null, null, "HT", "HTI", false, null, null, "Haiti", "Haití" },
                    { 98, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5647), null, null, "HU", "HUN", false, null, null, "Hungary", "Hungría" },
                    { 99, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5649), null, null, "ID", "IDN", false, null, null, "Indonesia", "Indonesia" },
                    { 100, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5652), null, null, "IE", "IRL", false, null, null, "Ireland", "Irlanda" },
                    { 101, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5656), null, null, "IL", "ISR", false, null, null, "Israel", "Israel" },
                    { 102, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5659), null, null, "IM", "IMN", false, null, null, "Isle of Man", "Isla de Man" },
                    { 103, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5661), null, null, "IN", "IND", false, null, null, "India", "India" },
                    { 104, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5664), null, null, "IO", "IOT", false, null, null, "British Indian Ocean Territory", "Terrirorio Británico del Océano Índico" },
                    { 105, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5666), null, null, "IQ", "IRQ", false, null, null, "Iraq", "Irak" },
                    { 106, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5668), null, null, "IR", "IRN", false, null, null, "Iran", "Irán" },
                    { 107, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5670), null, null, "IS", "ISL", false, null, null, "Iceland", "Islandia" },
                    { 108, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5672), null, null, "IT", "ITA", false, null, null, "Italy", "Italia" },
                    { 109, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5674), null, null, "JE", "JEY", false, null, null, "Jersey", "Jersey" },
                    { 110, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5676), null, null, "JM", "JAM", false, null, null, "Jamaica", "Jamaica" },
                    { 111, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5678), null, null, "JO", "JOR", false, null, null, "Jordan", "Jordania" },
                    { 112, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5682), null, null, "JP", "JPN", false, null, null, "Japan", "Japón" },
                    { 113, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5685), null, null, "KE", "KEN", false, null, null, "Kenya", "Kenia" },
                    { 114, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5687), null, null, "KG", "KGZ", false, null, null, "Kyrgyzstan", "Kirguistán" },
                    { 115, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5690), null, null, "KH", "KHM", false, null, null, "Cambodia", "Camboya" },
                    { 116, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5692), null, null, "KI", "KIR", false, null, null, "Kiribati", "Kiribati" },
                    { 117, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5695), null, null, "KM", "COM", false, null, null, "Comoros", "Comoras" },
                    { 118, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5697), null, null, "KN", "KNA", false, null, null, "Saint Kitts and Nevis", "San Cristóbal y Nieves" },
                    { 119, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5699), null, null, "KP", "PRK", false, null, null, "Democratic People's Republic of Korea", "República Democrática de Corea" },
                    { 120, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5701), null, null, "KR", "KOR", false, null, null, "South Korea", "República de Corea" },
                    { 121, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5703), null, null, "KW", "KWT", false, null, null, "Kuwait", "Kuwait" },
                    { 122, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5705), null, null, "KY", "CYM", false, null, null, " ", "Islas Caimán" },
                    { 123, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5707), null, null, "KZ", "KAZ", false, null, null, " ", "Kasajistán" },
                    { 124, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5710), null, null, "LA", "LAO", false, null, null, " ", "Laos" },
                    { 125, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5712), null, null, "LB", "LBN", false, null, null, " ", "Líbano" },
                    { 126, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5722), null, null, "LC", "LCA", false, null, null, " ", "Santa Lucía" },
                    { 127, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5724), null, null, "LI", "LIE", false, null, null, " ", "Liechtenstein" },
                    { 128, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5727), null, null, "LK", "LKA", false, null, null, " ", "Sri Lanka" },
                    { 129, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5734), null, null, "LR", "LBR", false, null, null, " ", "Liberia" },
                    { 130, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5736), null, null, "LS", "LSO", false, null, null, " ", "Lesotho" },
                    { 131, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5739), null, null, "LT", "LTU", false, null, null, " ", "Lituana" },
                    { 132, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5742), null, null, "LU", "LUX", false, null, null, " ", "Luxembur " },
                    { 133, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5744), null, null, "LV", "LVA", false, null, null, " ", "Letonia" },
                    { 134, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5746), null, null, "LY", "LBY", false, null, null, " ", "Libia" },
                    { 135, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5748), null, null, "MA", "MAR", false, null, null, " ", "Marruecos" },
                    { 136, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5750), null, null, "MC", "MCO", false, null, null, " ", "Mónaco" },
                    { 137, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5753), null, null, "MD", "MDA", false, null, null, " ", "Moldavia" },
                    { 138, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5756), null, null, "ME", "MNE", false, null, null, " ", "Montenegro" },
                    { 139, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5758), null, null, "MG", "MDG", false, null, null, " ", "Madagascar" },
                    { 140, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5760), null, null, "MH", "MHL", false, null, null, " ", "Islas Marschall" },
                    { 141, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5764), null, null, "MK", "MKD", false, null, null, " ", "Macedonia" },
                    { 142, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5771), null, null, "ML", "MLI", false, null, null, " ", "Malí" },
                    { 143, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5773), null, null, "MM", "MMR", false, null, null, " ", "Myanmar" },
                    { 144, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5775), null, null, "MN", "MNG", false, null, null, " ", "Mon lia" },
                    { 145, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5778), null, null, "MO", "MAC", false, null, null, " ", "Macao" },
                    { 146, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5780), null, null, "MP", "MNP", false, null, null, " ", "Islas Marianas del Norte" },
                    { 147, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5782), null, null, "MQ", "MTQ", false, null, null, " ", "Martinica" },
                    { 148, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5784), null, null, "MR", "MRT", false, null, null, " ", "Mauritania" },
                    { 149, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5786), null, null, "MS", "MSR", false, null, null, " ", "Montserrat" },
                    { 150, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5789), null, null, "MT", "MLT", false, null, null, " ", "Malta" },
                    { 151, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5791), null, null, "MU", "MUS", false, null, null, " ", "Mauricio" },
                    { 152, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5793), null, null, "MV", "MDV", false, null, null, " ", "Maldivas" },
                    { 153, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5795), null, null, "MW", "MWI", false, null, null, " ", "Malawi" },
                    { 154, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5797), null, null, "MX", "MEX", false, null, null, " ", "México" },
                    { 155, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5799), null, null, "MY", "MYS", false, null, null, " ", "Malasia" },
                    { 156, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5801), null, null, "MZ", "MOZ", false, null, null, " ", "Mozambique" },
                    { 157, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5803), null, null, "NA", "NAM", false, null, null, " ", "Namibia" },
                    { 158, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5806), null, null, "NC", "NCL", false, null, null, " ", "Nueva Caledonia" },
                    { 159, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5808), null, null, "NE", "NER", false, null, null, " ", "Níger" },
                    { 160, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5810), null, null, "NF", "NFK", false, null, null, " ", "Isla Norfolk" },
                    { 161, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5812), null, null, "NG", "NGA", false, null, null, " ", "Nigeria" },
                    { 162, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5814), null, null, "NI", "NIC", false, null, null, " ", "Nicaragua" },
                    { 163, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5817), null, null, "NL", "NLD", false, null, null, " ", "Países Bajos" },
                    { 164, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5819), null, null, "NO", "NOR", false, null, null, " ", "Noruega" },
                    { 165, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5822), null, null, "NP", "NPL", false, null, null, " ", "Nepal" },
                    { 166, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5824), null, null, "NR", "NRU", false, null, null, " ", "Naurú" },
                    { 167, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5826), null, null, "NU", "NIU", false, null, null, " ", "Niue" },
                    { 168, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5828), null, null, "NZ", "NZL", false, null, null, " ", "Nueva Zelanda" },
                    { 169, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5831), null, null, "OM", "OMN", false, null, null, " ", "Omán" },
                    { 170, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5833), null, null, "PA", "PAN", false, null, null, " ", "Panamá" },
                    { 171, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5835), null, null, "PE", "PER", false, null, null, " ", "Perú" },
                    { 172, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5839), null, null, "PF", "PYF", false, null, null, " ", "Polinesia Francesa" },
                    { 173, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5841), null, null, "PG", "PNG", false, null, null, " ", "Papúa-Nueva Guinea" },
                    { 174, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5843), null, null, "PH", "PHL", false, null, null, " ", "Filipinas" },
                    { 175, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5846), null, null, "PK", "PAK", false, null, null, " ", "Pakistán" },
                    { 176, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5848), null, null, "PL", "POL", false, null, null, " ", "Polonia" },
                    { 177, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5850), null, null, "PM", "SPM", false, null, null, " ", "San Pedro y Miquelón" },
                    { 178, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5852), null, null, "PN", "PCN", false, null, null, " ", "Pitcairn" },
                    { 179, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5855), null, null, "PR", "PRI", false, null, null, " ", "Puerto Rico" },
                    { 180, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5857), null, null, "PS", "PSE", false, null, null, " ", "Estado de Palestina" },
                    { 181, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5859), null, null, "PT", "PRT", false, null, null, " ", "Portugal" },
                    { 182, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5862), null, null, "PW", "PLW", false, null, null, " ", "Palau" },
                    { 183, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5865), null, null, "PY", "PRY", false, null, null, " ", "Paraguay" },
                    { 184, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5867), null, null, "QA", "QAT", false, null, null, " ", "Qatar" },
                    { 185, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5870), null, null, "RE", "REU", false, null, null, " ", "Reunión" },
                    { 186, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5885), null, null, "RO", "ROM", false, null, null, " ", "Rumania" },
                    { 187, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5888), null, null, "RS", "SRB", false, null, null, " ", "Serbia" },
                    { 188, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5890), null, null, "RU", "RUS", false, null, null, " ", "Rusia" },
                    { 189, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5892), null, null, "RW", "RWA", false, null, null, " ", "Ruanda" },
                    { 190, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5895), null, null, "SA", "SAU", false, null, null, " ", "Arabia Saudita" },
                    { 191, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5897), null, null, "SB", "SLB", false, null, null, " ", "Islas Salomón" },
                    { 192, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5899), null, null, "SC", "SYC", false, null, null, " ", "Seychelles" },
                    { 193, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5901), null, null, "SD", "SDN", false, null, null, " ", "Sudán" },
                    { 194, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5902), null, null, "SE", "SWE", false, null, null, " ", "Suecia" },
                    { 195, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5905), null, null, "SG", "SGP", false, null, null, " ", "Singapur" },
                    { 196, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5907), null, null, "SH", "SHN", false, null, null, " ", "Santa Helena" },
                    { 197, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5909), null, null, "SI", "SVN", false, null, null, " ", "Eslovenia" },
                    { 198, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5911), null, null, "SJ", "SJM", false, null, null, " ", "Svalbard y Jan Mayen" },
                    { 199, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5914), null, null, "SK", "SVK", false, null, null, " ", "Eslovaquia" },
                    { 200, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5919), null, null, "SL", "SLE", false, null, null, " ", "Sierra Leona" },
                    { 201, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5921), null, null, "SM", "SMR", false, null, null, " ", "San Marino" },
                    { 202, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5923), null, null, "SN", "SEN", false, null, null, " ", "Senegal" },
                    { 203, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5925), null, null, "SO", "SOM", false, null, null, " ", "Somalia" },
                    { 204, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5927), null, null, "SR", "SUR", false, null, null, " ", "Surinam" },
                    { 205, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5929), null, null, "ST", "STP", false, null, null, " ", "Santo Tomé y Príncipe" },
                    { 206, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5931), null, null, "SV", "SLV", false, null, null, " ", "El Salvador" },
                    { 207, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5933), null, null, "SY", "SYR", false, null, null, " ", "Siria" },
                    { 208, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5935), null, null, "SZ", "SWZ", false, null, null, " ", "Swazilandia" },
                    { 209, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5938), null, null, "TC", "TCA", false, null, null, " ", "Isla Turks y Caicos" },
                    { 210, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5940), null, null, "TD", "TCD", false, null, null, " ", "Chad" },
                    { 211, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5942), null, null, "TF", "ATF", false, null, null, " ", "Territorios Franceses del Sur" },
                    { 212, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5944), null, null, "TG", "TGO", false, null, null, " ", "Togo" },
                    { 213, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5947), null, null, "TH", "THA", false, null, null, " ", "Tailandia" },
                    { 214, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5949), null, null, "TJ", "TJK", false, null, null, " ", "Tajikistán" },
                    { 215, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5951), null, null, "TK", "TKL", false, null, null, " ", "Tokelau" },
                    { 216, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5953), null, null, "TL", "TKM", false, null, null, " ", "Timor Este" },
                    { 217, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5956), null, null, "TM", "TUN", false, null, null, " ", "Turkmenistán" },
                    { 218, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5958), null, null, "TN", "TON", false, null, null, " ", "Tunicia" },
                    { 219, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5961), null, null, "TO", "TMP", false, null, null, " ", "Tonga" },
                    { 220, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5963), null, null, "TR", "TUR", false, null, null, " ", "Turquía" },
                    { 221, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5966), null, null, "TT", "TTO", false, null, null, " ", "Trinidad y Toba " },
                    { 222, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5968), null, null, "TV", "TUV", false, null, null, " ", "Tuvalú" },
                    { 223, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5971), null, null, "TW", "TWN", false, null, null, " ", "Taiwán" },
                    { 224, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5973), null, null, "TZ", "TZA", false, null, null, " ", "Tanzania" },
                    { 225, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5975), null, null, "UA", "UKR", false, null, null, " ", "Ucrania" },
                    { 226, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5978), null, null, "UG", "UGA", false, null, null, " ", "Uganda" },
                    { 227, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5980), null, null, "UM", "UMI", false, null, null, " ", "Islas Menores de Estados Unidos" },
                    { 228, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5983), null, null, "US", "USA", false, null, null, " ", "Estados Unidos" },
                    { 229, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5985), null, null, "UY", "URY", false, null, null, " ", "Uruguay" },
                    { 230, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5988), null, null, "UZ", "UZB", false, null, null, " ", "Uzbekistán" },
                    { 231, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5990), null, null, "VA", "VAT", false, null, null, " ", "El Vaticano" },
                    { 232, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5993), null, null, "VC", "VCT", false, null, null, " ", "San Vicente y Granadinas" },
                    { 233, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5995), null, null, "VE", "VEN", false, null, null, " ", "Venezuela" },
                    { 234, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5997), null, null, "VG", "VGB", false, null, null, " ", "Islas Vírgenes Británicas" },
                    { 235, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(5999), null, null, "VI", "VIR", false, null, null, " ", "Islas Vírgenes de Estados Unidos" },
                    { 236, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(6002), null, null, "VN", "VNM", false, null, null, " ", "Vietnam" },
                    { 237, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(6004), null, null, "VU", "VUT", false, null, null, " ", "Vanuatu" },
                    { 238, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(6007), null, null, "WF", "WLF", false, null, null, " ", "Wallis y Futuna" },
                    { 239, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(6009), null, null, "WS", "WSM", false, null, null, " ", "Samoa" },
                    { 240, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(6011), null, null, "YE", "YEM", false, null, null, " ", "Yemén" },
                    { 241, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(6013), null, null, "YT", "MYT", false, null, null, " ", "Mayotte" },
                    { 242, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(6015), null, null, "ZA", "ZAF", false, null, null, " ", "Suráfrica" },
                    { 243, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(6017), null, null, "ZM", "ZMB", false, null, null, " ", "Zambia" },
                    { 244, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(6020), null, null, "ZW", "ZWE", false, null, null, " ", "Zimbabwe" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeleteDate", "DeletedBy", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "NameEn", "NameEs" },
                values: new object[,]
                {
                    { 1, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(7392), null, null, false, null, null, "Spanish", "Español" },
                    { 2, "system", new DateTime(2023, 6, 13, 22, 39, 57, 759, DateTimeKind.Local).AddTicks(7396), null, null, false, null, null, "English", "Inglés" }
                });

            migrationBuilder.InsertData(
                table: "ResumeType",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeleteDate", "DeletedBy", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, null, null, null, null, false, null, null, "WorkExperience" },
                    { 2, null, null, null, null, false, null, null, "Education" }
                });

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
                name: "IX_Certificate_WorkerProfileId",
                table: "Certificate",
                column: "WorkerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Interest_WorkerProfileId",
                table: "Interest",
                column: "WorkerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguagesOnWorkerProfile_LanguageId",
                table: "LanguagesOnWorkerProfile",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguagesOnWorkerProfile_WorkerProfileId",
                table: "LanguagesOnWorkerProfile",
                column: "WorkerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Multimedia_ProjectId",
                table: "Multimedia",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_WorkerProfileId",
                table: "Project",
                column: "WorkerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Resume_ResumeTypeId",
                table: "Resume",
                column: "ResumeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Resume_WorkerProfileId",
                table: "Resume",
                column: "WorkerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_WorkerProfileId",
                table: "Service",
                column: "WorkerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkerProfile_CountryId",
                table: "WorkerProfile",
                column: "CountryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AptitudeOnProject");

            migrationBuilder.DropTable(
                name: "AptitudeOnResume");

            migrationBuilder.DropTable(
                name: "Certificate");

            migrationBuilder.DropTable(
                name: "Interest");

            migrationBuilder.DropTable(
                name: "LanguagesOnWorkerProfile");

            migrationBuilder.DropTable(
                name: "Multimedia");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "Aptitude");

            migrationBuilder.DropTable(
                name: "Resume");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "ResumeType");

            migrationBuilder.DropTable(
                name: "WorkerProfile");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
