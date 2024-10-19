using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FS_PROJECT_ASPNETCore_WebTutorQuizzer.Migrations
{
    /// <inheritdoc />
    public partial class SubjectQuizRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Quiz_QuizId",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Subject_QuizId",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "QuizId",
                table: "Subject");

            migrationBuilder.AddColumn<int>(
                name: "SubjectId",
                table: "Quiz",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Quiz_SubjectId",
                table: "Quiz",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quiz_Subject_SubjectId",
                table: "Quiz",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quiz_Subject_SubjectId",
                table: "Quiz");

            migrationBuilder.DropIndex(
                name: "IX_Quiz_SubjectId",
                table: "Quiz");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "Quiz");

            migrationBuilder.AddColumn<int>(
                name: "QuizId",
                table: "Subject",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Subject_QuizId",
                table: "Subject",
                column: "QuizId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Quiz_QuizId",
                table: "Subject",
                column: "QuizId",
                principalTable: "Quiz",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
