using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace job_trackr_backend.Migrations
{
    /// <inheritdoc />
    public partial class AddSampleJobApplication : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "JobApplications",
                columns: new[] { "Id", "Company", "DateApplied", "JobTitle", "Notes", "StatusId" },
                values: new object[] { 1, "Zillow", new DateTime(2026, 10, 20, 16, 33, 16, 144, DateTimeKind.Utc).AddTicks(7136), "IT Support", null, 4 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JobApplications",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
