using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeProject.Migrations
{
    public partial class updateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogComments_BlogComments_ParentBlogCommentId",
                table: "BlogComments");

            migrationBuilder.DropForeignKey(
                name: "FK_CousresComments_CousresComments_ParentCousresCommentId",
                table: "CousresComments");

            migrationBuilder.DropForeignKey(
                name: "FK_EventComments_EventComments_ParentEventCommentId",
                table: "EventComments");

            migrationBuilder.AlterColumn<int>(
                name: "ParentEventCommentId",
                table: "EventComments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ParentCousresCommentId",
                table: "CousresComments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ParentBlogCommentId",
                table: "BlogComments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogComments_BlogComments_ParentBlogCommentId",
                table: "BlogComments",
                column: "ParentBlogCommentId",
                principalTable: "BlogComments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CousresComments_CousresComments_ParentCousresCommentId",
                table: "CousresComments",
                column: "ParentCousresCommentId",
                principalTable: "CousresComments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventComments_EventComments_ParentEventCommentId",
                table: "EventComments",
                column: "ParentEventCommentId",
                principalTable: "EventComments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogComments_BlogComments_ParentBlogCommentId",
                table: "BlogComments");

            migrationBuilder.DropForeignKey(
                name: "FK_CousresComments_CousresComments_ParentCousresCommentId",
                table: "CousresComments");

            migrationBuilder.DropForeignKey(
                name: "FK_EventComments_EventComments_ParentEventCommentId",
                table: "EventComments");

            migrationBuilder.AlterColumn<int>(
                name: "ParentEventCommentId",
                table: "EventComments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ParentCousresCommentId",
                table: "CousresComments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ParentBlogCommentId",
                table: "BlogComments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogComments_BlogComments_ParentBlogCommentId",
                table: "BlogComments",
                column: "ParentBlogCommentId",
                principalTable: "BlogComments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CousresComments_CousresComments_ParentCousresCommentId",
                table: "CousresComments",
                column: "ParentCousresCommentId",
                principalTable: "CousresComments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventComments_EventComments_ParentEventCommentId",
                table: "EventComments",
                column: "ParentEventCommentId",
                principalTable: "EventComments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
