using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TSA.Model.Migrations
{
    /// <inheritdoc />
    public partial class ForeignKeysAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Personnels_DepartmentId",
                table: "Personnels",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceRecords_DeviceId",
                table: "MaintenanceRecords",
                column: "DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceRecords_UserId",
                table: "MaintenanceRecords",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_AssignedPersonnelId",
                table: "Devices",
                column: "AssignedPersonnelId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_TypeId",
                table: "Devices",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_DeviceTypes_TypeId",
                table: "Devices",
                column: "TypeId",
                principalTable: "DeviceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Personnels_AssignedPersonnelId",
                table: "Devices",
                column: "AssignedPersonnelId",
                principalTable: "Personnels",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceRecords_Devices_DeviceId",
                table: "MaintenanceRecords",
                column: "DeviceId",
                principalTable: "Devices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceRecords_Users_UserId",
                table: "MaintenanceRecords",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Personnels_Departments_DepartmentId",
                table: "Personnels",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_DeviceTypes_TypeId",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Personnels_AssignedPersonnelId",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceRecords_Devices_DeviceId",
                table: "MaintenanceRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceRecords_Users_UserId",
                table: "MaintenanceRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_Personnels_Departments_DepartmentId",
                table: "Personnels");

            migrationBuilder.DropIndex(
                name: "IX_Personnels_DepartmentId",
                table: "Personnels");

            migrationBuilder.DropIndex(
                name: "IX_MaintenanceRecords_DeviceId",
                table: "MaintenanceRecords");

            migrationBuilder.DropIndex(
                name: "IX_MaintenanceRecords_UserId",
                table: "MaintenanceRecords");

            migrationBuilder.DropIndex(
                name: "IX_Devices_AssignedPersonnelId",
                table: "Devices");

            migrationBuilder.DropIndex(
                name: "IX_Devices_TypeId",
                table: "Devices");
        }
    }
}
