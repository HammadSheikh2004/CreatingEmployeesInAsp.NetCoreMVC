﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutehticationSystem.Migrations
{
    public partial class Migration10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "5ecd4c7c-3d0a-4128-a96b-5683dc2aa1fc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "0371a588-741e-4747-b51a-00b475184951");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "0c4bf38d-182a-47f2-bcb5-0b14109f4f57");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "58ba0f18-927b-40ea-92fd-cdf964ba6d5f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "85de1005-4247-4ae8-a56d-379e8321bb8e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "4b671248-5aa3-4ac3-bec9-68d69de78a5d");
        }
    }
}
