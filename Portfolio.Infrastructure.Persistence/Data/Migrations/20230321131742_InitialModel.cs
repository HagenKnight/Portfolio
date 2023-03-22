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
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NameEs = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NameEn = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ISO2 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ISO3 = table.Column<string>(type: "longtext", nullable: false)
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
                name: "ResumeType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
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
                    FirstName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AboutMe = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BirthDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "longtext", nullable: false)
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
                    Title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Duration = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IssueDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CertificateNumber = table.Column<string>(type: "longtext", nullable: false)
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
                name: "Resume",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    InstitutionName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Title = table.Column<string>(type: "longtext", nullable: false)
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
                    Name = table.Column<string>(type: "longtext", nullable: false)
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

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeleteDate", "DeletedBy", "ISO2", "ISO3", "IsDeleted", "LastModifiedBy", "LastModifiedDate", "NameEn", "NameEs" },
                values: new object[,]
                {
                    { 1, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7210), null, null, "AD", "AND", false, null, null, "Andorra", "Andorra" },
                    { 2, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7238), null, null, "AE", "ARE", false, null, null, "United Arab Emirates", "Emiratos Árabes Unidos" },
                    { 3, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7243), null, null, "AF", "AFG", false, null, null, "Afghanistan", "Afganistán" },
                    { 4, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7248), null, null, "AG", "ATG", false, null, null, "Antigua and Barbuda", "Antigua y Barbuda" },
                    { 5, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7253), null, null, "AI", "AIA", false, null, null, "Anguila", "Anguila" },
                    { 6, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7257), null, null, "AL", "ALB", false, null, null, "Albania", "Albania" },
                    { 7, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7262), null, null, "AM", "ARM", false, null, null, "Armenia", "Armenia" },
                    { 8, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7266), null, null, "AN", "ANT", false, null, null, "Netherlands Antilles", "Antillas Holandesas" },
                    { 9, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7271), null, null, "AO", "AGO", false, null, null, "Angola", "Angola" },
                    { 10, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7276), null, null, "AQ", "ATA", false, null, null, "Antarctica", "Antártida" },
                    { 11, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7280), null, null, "AR", "ARG", false, null, null, "Argentina", "Argentina" },
                    { 12, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7285), null, null, "AS", "ASM", false, null, null, "Samoa American", "Samoa Americana" },
                    { 13, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7290), null, null, "AT", "AUT", false, null, null, "Austria", "Austria" },
                    { 14, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7294), null, null, "AU", "AUS", false, null, null, "Australia", "Australia" },
                    { 15, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7299), null, null, "AW", "ABW", false, null, null, "Aruba", "Aruba" },
                    { 16, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7304), null, null, "AX", "ALA", false, null, null, "Aland Islands", "Islas Aland" },
                    { 17, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7308), null, null, "AZ", "AZE", false, null, null, "Azerbaijan", "Azerbaiyán" },
                    { 18, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7313), null, null, "BA", "BIH", false, null, null, "Bosnia and Herzegovina", "Bosnia y Herzegovina" },
                    { 19, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7317), null, null, "BB", "BRB", false, null, null, "Barbados", "Barbados" },
                    { 20, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7322), null, null, "BD", "BGD", false, null, null, "Bangladesh", "Bangladesh" },
                    { 21, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7326), null, null, "BE", "BEL", false, null, null, "Belgium", "Bélgica" },
                    { 22, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7331), null, null, "BF", "BFA", false, null, null, "Burkina Faso", "Burkina Faso" },
                    { 23, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7335), null, null, "BG", "BGR", false, null, null, "Bulgaria", "Bulgaria" },
                    { 24, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7340), null, null, "BH", "BHR", false, null, null, "Bahrein", "Bahrein" },
                    { 25, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7345), null, null, "BI", "BDI", false, null, null, "Burundi", "Burundi" },
                    { 26, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7349), null, null, "BJ", "BEN", false, null, null, "Benin", "Benín" },
                    { 27, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7354), null, null, "BM", "BMU", false, null, null, "Bermudas", "Bermudas" },
                    { 28, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7359), null, null, "BN", "BRN", false, null, null, "Brunei", "Brunei" },
                    { 29, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7363), null, null, "BO", "BOL", false, null, null, "Bolivia", "Bolivia" },
                    { 30, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7368), null, null, "BR", "BRA", false, null, null, "Brazil", "Brasil" },
                    { 31, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7373), null, null, "BS", "BHS", false, null, null, "Bahamas", "Bahamas" },
                    { 32, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7377), null, null, "BT", "BTN", false, null, null, "Buthan", "Bután" },
                    { 33, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7382), null, null, "BV", "BVT", false, null, null, "Bouvet Island", "Isla Bouvet" },
                    { 34, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7386), null, null, "BW", "BWA", false, null, null, "Botswana", "Botswana" },
                    { 35, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7391), null, null, "BY", "BLR", false, null, null, "Belarus", "Bielorusia" },
                    { 36, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7396), null, null, "BZ", "BLZ", false, null, null, "Belize", "Belice" },
                    { 37, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7400), null, null, "CA", "CAN", false, null, null, "Canada", "Canadá" },
                    { 38, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7405), null, null, "CC", "CCK", false, null, null, "Cocos (Keeling) Islands", "Islas Cocos" },
                    { 39, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7409), null, null, "CD", "COD", false, null, null, "Democratic Republic of the Congo", "Republica Democrática del Congo" },
                    { 40, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7414), null, null, "CF", "CAF", false, null, null, "Central African Republic", "República Centrofricana" },
                    { 41, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7418), null, null, "CG", "COG", false, null, null, "Republia of Congo", "República del Congo" },
                    { 42, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7423), null, null, "CH", "CHE", false, null, null, "Switzerland", "Suiza" },
                    { 43, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7427), null, null, "CI", "CIV", false, null, null, "Ivory Coast", "Costa de Marfil" },
                    { 44, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7432), null, null, "CK", "COK", false, null, null, "Cook Islands", "Islas Cook" },
                    { 45, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7436), null, null, "CL", "CHL", false, null, null, "Chile", "Chile" },
                    { 46, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7441), null, null, "CM", "CMR", false, null, null, "Cameroon", "Camerún" },
                    { 47, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7446), null, null, "CN", "CHN", false, null, null, "China", "China" },
                    { 48, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7451), null, null, "CO", "COL", false, null, null, "Colombia", "Colombia" },
                    { 49, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7455), null, null, "CR", "CRI", false, null, null, "Costa Rica", "Costa Rica" },
                    { 50, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7460), null, null, "CU", "CUB", false, null, null, "Cuba", "Cuba" },
                    { 51, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7464), null, null, "CV", "CPV", false, null, null, "Green Cape", "Cabo Verde" },
                    { 52, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7469), null, null, "CX", "CXR", false, null, null, "Christmas Island", "Isla de Navidad" },
                    { 53, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7473), null, null, "CY", "CYP", false, null, null, "Cyprus", "Chipre" },
                    { 54, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7478), null, null, "CZ", "CZE", false, null, null, "Czech Republic", "República Checa" },
                    { 55, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7483), null, null, "DE", "DEU", false, null, null, "Germany", "Alemania" },
                    { 56, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7488), null, null, "DJ", "DJI", false, null, null, "Djibouti ", "Yibuti" },
                    { 57, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7508), null, null, "DK", "DNK", false, null, null, "Denkmark", "Dinamarca" },
                    { 58, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7513), null, null, "DM", "DMA", false, null, null, "Dominica", "Dominica" },
                    { 59, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7518), null, null, "DO", "DOM", false, null, null, "Dominican Republic", "República Dominicana" },
                    { 60, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7522), null, null, "DZ", "DZA", false, null, null, "Argelia", "Argelia" },
                    { 61, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7527), null, null, "EC", "ECU", false, null, null, "Ecuador", "Ecuador" },
                    { 62, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7531), null, null, "EE", "EST", false, null, null, "Estonia", "Estonia" },
                    { 63, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7536), null, null, "EG", "EGY", false, null, null, "Egypt", "Egipto" },
                    { 64, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7541), null, null, "EH", "ESH", false, null, null, "Western Sahara", "Sahara Occidental" },
                    { 65, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7545), null, null, "ER", "ERI", false, null, null, "Eritrea", "Eritrea" },
                    { 66, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7550), null, null, "ES", "ESP", false, null, null, "Spain", "España" },
                    { 67, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7555), null, null, "ET", "ETH", false, null, null, "Ethiopia", "Etiopía" },
                    { 68, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7559), null, null, "FI", "FIN", false, null, null, "Finland", "Finlandia" },
                    { 69, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7564), null, null, "FJ", "FJI", false, null, null, "Fiji ", "Fiji" },
                    { 70, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7568), null, null, "FK", "FLK", false, null, null, "Falkland Islands", "Islas Malvinas" },
                    { 71, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7573), null, null, "FM", "FSM", false, null, null, " ", "Micronesia" },
                    { 72, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7577), null, null, "FO", "FRO", false, null, null, "Faroe Islands", "Islas Faroe" },
                    { 73, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7582), null, null, "FR", "FRA", false, null, null, "France", "Francia" },
                    { 74, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7586), null, null, "GA", "GAB", false, null, null, "Gabon", "Gabón" },
                    { 75, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7591), null, null, "GB", "GBR", false, null, null, "United Kingdom", "Reino Unido" },
                    { 76, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7596), null, null, "GD", "GRD", false, null, null, "Grenada", "Granada" },
                    { 77, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7600), null, null, "GE", "GEO", false, null, null, "Georgia", "Georgia" },
                    { 78, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7605), null, null, "GF", "GUF", false, null, null, "French Guiana", "Guayana Francesa" },
                    { 79, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7609), null, null, "GG", "GGY", false, null, null, "Guernsey", "Guernsey" },
                    { 80, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7614), null, null, "GH", "GHA", false, null, null, "Ghana", "Ghana" },
                    { 81, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7618), null, null, "GI", "GIB", false, null, null, "Gibraltar", "Gibraltar" },
                    { 82, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7623), null, null, "GL", "GRL", false, null, null, "Greenland", "Groenlandia" },
                    { 83, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7627), null, null, "GM", "GMB", false, null, null, "Gambia", "Gambia" },
                    { 84, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7632), null, null, "GN", "GIN", false, null, null, "Guinea", "Guinea" },
                    { 85, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7637), null, null, "GP", "GLP", false, null, null, "Guadeloupe", "Guadalupe" },
                    { 86, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7641), null, null, "GQ", "GNQ", false, null, null, "Equatorial Guinea", "Guinea Ecuatorial" },
                    { 87, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7645), null, null, "GR", "GRC", false, null, null, "Greece", "Grecia" },
                    { 88, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7650), null, null, "GS", "SGS", false, null, null, "South Georgia and the South Sandwich Islands", "Georgia del Sur y las islas Sandwich" },
                    { 89, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7655), null, null, "GT", "GTM", false, null, null, "Guatemala", "Guatemala" },
                    { 90, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7659), null, null, "GU", "GUM", false, null, null, "Guam", "Guam" },
                    { 91, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7664), null, null, "GW", "GNB", false, null, null, "Guinea-Bissau", "Guinea-Bissau" },
                    { 92, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7669), null, null, "GY", "GUY", false, null, null, "Guyana", "Guyana" },
                    { 93, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7673), null, null, "HK", "HKG", false, null, null, "Hong Kong", "Hong Kong" },
                    { 94, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7678), null, null, "HM", "HMD", false, null, null, "Herd and McDonald Islands", "Islas Heard y McDonald" },
                    { 95, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7682), null, null, "HN", "HND", false, null, null, "Honduras", "Honduras" },
                    { 96, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7687), null, null, "HR", "HRV", false, null, null, "Croatia", "Croacia" },
                    { 97, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7691), null, null, "HT", "HTI", false, null, null, "Haiti", "Haití" },
                    { 98, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7696), null, null, "HU", "HUN", false, null, null, "Hungary", "Hungría" },
                    { 99, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7701), null, null, "ID", "IDN", false, null, null, "Indonesia", "Indonesia" },
                    { 100, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7706), null, null, "IE", "IRL", false, null, null, "Ireland", "Irlanda" },
                    { 101, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7710), null, null, "IL", "ISR", false, null, null, "Israel", "Israel" },
                    { 102, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7715), null, null, "IM", "IMN", false, null, null, "Isle of Man", "Isla de Man" },
                    { 103, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7719), null, null, "IN", "IND", false, null, null, "India", "India" },
                    { 104, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7724), null, null, "IO", "IOT", false, null, null, "British Indian Ocean Territory", "Terrirorio Británico del Océano Índico" },
                    { 105, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7728), null, null, "IQ", "IRQ", false, null, null, "Iraq", "Irak" },
                    { 106, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7733), null, null, "IR", "IRN", false, null, null, "Iran", "Irán" },
                    { 107, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7738), null, null, "IS", "ISL", false, null, null, "Iceland", "Islandia" },
                    { 108, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7742), null, null, "IT", "ITA", false, null, null, "Italy", "Italia" },
                    { 109, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7747), null, null, "JE", "JEY", false, null, null, "Jersey", "Jersey" },
                    { 110, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7751), null, null, "JM", "JAM", false, null, null, "Jamaica", "Jamaica" },
                    { 111, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7756), null, null, "JO", "JOR", false, null, null, "Jordan", "Jordania" },
                    { 112, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7761), null, null, "JP", "JPN", false, null, null, "Japan", "Japón" },
                    { 113, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7765), null, null, "KE", "KEN", false, null, null, "Kenya", "Kenia" },
                    { 114, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7770), null, null, "KG", "KGZ", false, null, null, "Kyrgyzstan", "Kirguistán" },
                    { 115, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7774), null, null, "KH", "KHM", false, null, null, "Cambodia", "Camboya" },
                    { 116, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7779), null, null, "KI", "KIR", false, null, null, "Kiribati", "Kiribati" },
                    { 117, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7794), null, null, "KM", "COM", false, null, null, "Comoros", "Comoras" },
                    { 118, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7799), null, null, "KN", "KNA", false, null, null, "Saint Kitts and Nevis", "San Cristóbal y Nieves" },
                    { 119, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7803), null, null, "KP", "PRK", false, null, null, "Democratic People's Republic of Korea", "República Democrática de Corea" },
                    { 120, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7808), null, null, "KR", "KOR", false, null, null, "South Korea", "República de Corea" },
                    { 121, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7812), null, null, "KW", "KWT", false, null, null, "Kuwait", "Kuwait" },
                    { 122, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7817), null, null, "KY", "CYM", false, null, null, " ", "Islas Caimán" },
                    { 123, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7822), null, null, "KZ", "KAZ", false, null, null, " ", "Kasajistán" },
                    { 124, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7827), null, null, "LA", "LAO", false, null, null, " ", "Laos" },
                    { 125, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7831), null, null, "LB", "LBN", false, null, null, " ", "Líbano" },
                    { 126, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7836), null, null, "LC", "LCA", false, null, null, " ", "Santa Lucía" },
                    { 127, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7840), null, null, "LI", "LIE", false, null, null, " ", "Liechtenstein" },
                    { 128, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7845), null, null, "LK", "LKA", false, null, null, " ", "Sri Lanka" },
                    { 129, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7849), null, null, "LR", "LBR", false, null, null, " ", "Liberia" },
                    { 130, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7854), null, null, "LS", "LSO", false, null, null, " ", "Lesotho" },
                    { 131, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7859), null, null, "LT", "LTU", false, null, null, " ", "Lituana" },
                    { 132, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7863), null, null, "LU", "LUX", false, null, null, " ", "Luxembur " },
                    { 133, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7868), null, null, "LV", "LVA", false, null, null, " ", "Letonia" },
                    { 134, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7872), null, null, "LY", "LBY", false, null, null, " ", "Libia" },
                    { 135, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7877), null, null, "MA", "MAR", false, null, null, " ", "Marruecos" },
                    { 136, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7881), null, null, "MC", "MCO", false, null, null, " ", "Mónaco" },
                    { 137, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7886), null, null, "MD", "MDA", false, null, null, " ", "Moldavia" },
                    { 138, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7890), null, null, "ME", "MNE", false, null, null, " ", "Montenegro" },
                    { 139, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7895), null, null, "MG", "MDG", false, null, null, " ", "Madagascar" },
                    { 140, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7899), null, null, "MH", "MHL", false, null, null, " ", "Islas Marschall" },
                    { 141, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7904), null, null, "MK", "MKD", false, null, null, " ", "Macedonia" },
                    { 142, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7909), null, null, "ML", "MLI", false, null, null, " ", "Malí" },
                    { 143, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7913), null, null, "MM", "MMR", false, null, null, " ", "Myanmar" },
                    { 144, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7918), null, null, "MN", "MNG", false, null, null, " ", "Mon lia" },
                    { 145, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7922), null, null, "MO", "MAC", false, null, null, " ", "Macao" },
                    { 146, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7927), null, null, "MP", "MNP", false, null, null, " ", "Islas Marianas del Norte" },
                    { 147, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7932), null, null, "MQ", "MTQ", false, null, null, " ", "Martinica" },
                    { 148, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7936), null, null, "MR", "MRT", false, null, null, " ", "Mauritania" },
                    { 149, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7941), null, null, "MS", "MSR", false, null, null, " ", "Montserrat" },
                    { 150, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7946), null, null, "MT", "MLT", false, null, null, " ", "Malta" },
                    { 151, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7950), null, null, "MU", "MUS", false, null, null, " ", "Mauricio" },
                    { 152, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7955), null, null, "MV", "MDV", false, null, null, " ", "Maldivas" },
                    { 153, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7960), null, null, "MW", "MWI", false, null, null, " ", "Malawi" },
                    { 154, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7964), null, null, "MX", "MEX", false, null, null, " ", "México" },
                    { 155, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7969), null, null, "MY", "MYS", false, null, null, " ", "Malasia" },
                    { 156, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7973), null, null, "MZ", "MOZ", false, null, null, " ", "Mozambique" },
                    { 157, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7978), null, null, "NA", "NAM", false, null, null, " ", "Namibia" },
                    { 158, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7983), null, null, "NC", "NCL", false, null, null, " ", "Nueva Caledonia" },
                    { 159, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7987), null, null, "NE", "NER", false, null, null, " ", "Níger" },
                    { 160, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7992), null, null, "NF", "NFK", false, null, null, " ", "Isla Norfolk" },
                    { 161, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(7996), null, null, "NG", "NGA", false, null, null, " ", "Nigeria" },
                    { 162, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8001), null, null, "NI", "NIC", false, null, null, " ", "Nicaragua" },
                    { 163, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8005), null, null, "NL", "NLD", false, null, null, " ", "Países Bajos" },
                    { 164, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8010), null, null, "NO", "NOR", false, null, null, " ", "Noruega" },
                    { 165, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8015), null, null, "NP", "NPL", false, null, null, " ", "Nepal" },
                    { 166, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8020), null, null, "NR", "NRU", false, null, null, " ", "Naurú" },
                    { 167, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8024), null, null, "NU", "NIU", false, null, null, " ", "Niue" },
                    { 168, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8029), null, null, "NZ", "NZL", false, null, null, " ", "Nueva Zelanda" },
                    { 169, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8033), null, null, "OM", "OMN", false, null, null, " ", "Omán" },
                    { 170, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8038), null, null, "PA", "PAN", false, null, null, " ", "Panamá" },
                    { 171, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8042), null, null, "PE", "PER", false, null, null, " ", "Perú" },
                    { 172, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8047), null, null, "PF", "PYF", false, null, null, " ", "Polinesia Francesa" },
                    { 173, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8052), null, null, "PG", "PNG", false, null, null, " ", "Papúa-Nueva Guinea" },
                    { 174, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8057), null, null, "PH", "PHL", false, null, null, " ", "Filipinas" },
                    { 175, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8061), null, null, "PK", "PAK", false, null, null, " ", "Pakistán" },
                    { 176, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8066), null, null, "PL", "POL", false, null, null, " ", "Polonia" },
                    { 177, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8070), null, null, "PM", "SPM", false, null, null, " ", "San Pedro y Miquelón" },
                    { 178, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8086), null, null, "PN", "PCN", false, null, null, " ", "Pitcairn" },
                    { 179, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8091), null, null, "PR", "PRI", false, null, null, " ", "Puerto Rico" },
                    { 180, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8095), null, null, "PS", "PSE", false, null, null, " ", "Estado de Palestina" },
                    { 181, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8100), null, null, "PT", "PRT", false, null, null, " ", "Portugal" },
                    { 182, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8105), null, null, "PW", "PLW", false, null, null, " ", "Palau" },
                    { 183, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8109), null, null, "PY", "PRY", false, null, null, " ", "Paraguay" },
                    { 184, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8114), null, null, "QA", "QAT", false, null, null, " ", "Qatar" },
                    { 185, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8119), null, null, "RE", "REU", false, null, null, " ", "Reunión" },
                    { 186, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8124), null, null, "RO", "ROM", false, null, null, " ", "Rumania" },
                    { 187, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8128), null, null, "RS", "SRB", false, null, null, " ", "Serbia" },
                    { 188, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8133), null, null, "RU", "RUS", false, null, null, " ", "Rusia" },
                    { 189, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8137), null, null, "RW", "RWA", false, null, null, " ", "Ruanda" },
                    { 190, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8142), null, null, "SA", "SAU", false, null, null, " ", "Arabia Saudita" },
                    { 191, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8147), null, null, "SB", "SLB", false, null, null, " ", "Islas Salomón" },
                    { 192, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8151), null, null, "SC", "SYC", false, null, null, " ", "Seychelles" },
                    { 193, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8156), null, null, "SD", "SDN", false, null, null, " ", "Sudán" },
                    { 194, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8160), null, null, "SE", "SWE", false, null, null, " ", "Suecia" },
                    { 195, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8165), null, null, "SG", "SGP", false, null, null, " ", "Singapur" },
                    { 196, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8169), null, null, "SH", "SHN", false, null, null, " ", "Santa Helena" },
                    { 197, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8174), null, null, "SI", "SVN", false, null, null, " ", "Eslovenia" },
                    { 198, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8179), null, null, "SJ", "SJM", false, null, null, " ", "Svalbard y Jan Mayen" },
                    { 199, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8183), null, null, "SK", "SVK", false, null, null, " ", "Eslovaquia" },
                    { 200, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8188), null, null, "SL", "SLE", false, null, null, " ", "Sierra Leona" },
                    { 201, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8193), null, null, "SM", "SMR", false, null, null, " ", "San Marino" },
                    { 202, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8198), null, null, "SN", "SEN", false, null, null, " ", "Senegal" },
                    { 203, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8202), null, null, "SO", "SOM", false, null, null, " ", "Somalia" },
                    { 204, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8207), null, null, "SR", "SUR", false, null, null, " ", "Surinam" },
                    { 205, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8211), null, null, "ST", "STP", false, null, null, " ", "Santo Tomé y Príncipe" },
                    { 206, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8216), null, null, "SV", "SLV", false, null, null, " ", "El Salvador" },
                    { 207, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8221), null, null, "SY", "SYR", false, null, null, " ", "Siria" },
                    { 208, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8225), null, null, "SZ", "SWZ", false, null, null, " ", "Swazilandia" },
                    { 209, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8230), null, null, "TC", "TCA", false, null, null, " ", "Isla Turks y Caicos" },
                    { 210, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8235), null, null, "TD", "TCD", false, null, null, " ", "Chad" },
                    { 211, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8239), null, null, "TF", "ATF", false, null, null, " ", "Territorios Franceses del Sur" },
                    { 212, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8245), null, null, "TG", "TGO", false, null, null, " ", "Togo" },
                    { 213, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8250), null, null, "TH", "THA", false, null, null, " ", "Tailandia" },
                    { 214, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8255), null, null, "TJ", "TJK", false, null, null, " ", "Tajikistán" },
                    { 215, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8259), null, null, "TK", "TKL", false, null, null, " ", "Tokelau" },
                    { 216, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8264), null, null, "TL", "TKM", false, null, null, " ", "Timor Este" },
                    { 217, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8268), null, null, "TM", "TUN", false, null, null, " ", "Turkmenistán" },
                    { 218, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8273), null, null, "TN", "TON", false, null, null, " ", "Tunicia" },
                    { 219, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8277), null, null, "TO", "TMP", false, null, null, " ", "Tonga" },
                    { 220, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8282), null, null, "TR", "TUR", false, null, null, " ", "Turquía" },
                    { 221, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8286), null, null, "TT", "TTO", false, null, null, " ", "Trinidad y Toba " },
                    { 222, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8291), null, null, "TV", "TUV", false, null, null, " ", "Tuvalú" },
                    { 223, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8295), null, null, "TW", "TWN", false, null, null, " ", "Taiwán" },
                    { 224, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8300), null, null, "TZ", "TZA", false, null, null, " ", "Tanzania" },
                    { 225, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8304), null, null, "UA", "UKR", false, null, null, " ", "Ucrania" },
                    { 226, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8309), null, null, "UG", "UGA", false, null, null, " ", "Uganda" },
                    { 227, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8313), null, null, "UM", "UMI", false, null, null, " ", "Islas Menores de Estados Unidos" },
                    { 228, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8318), null, null, "US", "USA", false, null, null, " ", "Estados Unidos" },
                    { 229, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8323), null, null, "UY", "URY", false, null, null, " ", "Uruguay" },
                    { 230, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8327), null, null, "UZ", "UZB", false, null, null, " ", "Uzbekistán" },
                    { 231, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8332), null, null, "VA", "VAT", false, null, null, " ", "El Vaticano" },
                    { 232, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8336), null, null, "VC", "VCT", false, null, null, " ", "San Vicente y Granadinas" },
                    { 233, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8341), null, null, "VE", "VEN", false, null, null, " ", "Venezuela" },
                    { 234, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8345), null, null, "VG", "VGB", false, null, null, " ", "Islas Vírgenes Británicas" },
                    { 235, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8350), null, null, "VI", "VIR", false, null, null, " ", "Islas Vírgenes de Estados Unidos" },
                    { 236, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8354), null, null, "VN", "VNM", false, null, null, " ", "Vietnam" },
                    { 237, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8359), null, null, "VU", "VUT", false, null, null, " ", "Vanuatu" },
                    { 238, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8375), null, null, "WF", "WLF", false, null, null, " ", "Wallis y Futuna" },
                    { 239, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8380), null, null, "WS", "WSM", false, null, null, " ", "Samoa" },
                    { 240, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8384), null, null, "YE", "YEM", false, null, null, " ", "Yemén" },
                    { 241, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8389), null, null, "YT", "MYT", false, null, null, " ", "Mayotte" },
                    { 242, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8393), null, null, "ZA", "ZAF", false, null, null, " ", "Suráfrica" },
                    { 243, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8398), null, null, "ZM", "ZMB", false, null, null, " ", "Zambia" },
                    { 244, "system", new DateTime(2023, 3, 21, 8, 17, 42, 401, DateTimeKind.Local).AddTicks(8402), null, null, "ZW", "ZWE", false, null, null, " ", "Zimbabwe" }
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
                name: "IX_Certificate_WorkerProfileId",
                table: "Certificate",
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
                name: "Certificate");

            migrationBuilder.DropTable(
                name: "Resume");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "ResumeType");

            migrationBuilder.DropTable(
                name: "WorkerProfile");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
