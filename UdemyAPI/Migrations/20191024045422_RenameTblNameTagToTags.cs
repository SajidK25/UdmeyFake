using Microsoft.EntityFrameworkCore.Migrations;

namespace UdemyAPI.Migrations
{
    public partial class RenameTblNameTagToTags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Author_AuthorId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseTag_Course_CourseId",
                table: "CourseTag");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseTag_CourseTag_CourseTagId",
                table: "CourseTag");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseTag_Tag_TagId",
                table: "CourseTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tag",
                table: "Tag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseTag",
                table: "CourseTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Author",
                table: "Author");

            migrationBuilder.RenameTable(
                name: "Tag",
                newName: "Tags");

            migrationBuilder.RenameTable(
                name: "CourseTag",
                newName: "CourseTags");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "Courses");

            migrationBuilder.RenameTable(
                name: "Author",
                newName: "Authors");

            migrationBuilder.RenameIndex(
                name: "IX_CourseTag_TagId",
                table: "CourseTags",
                newName: "IX_CourseTags_TagId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseTag_CourseTagId",
                table: "CourseTags",
                newName: "IX_CourseTags_CourseTagId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseTag_CourseId",
                table: "CourseTags",
                newName: "IX_CourseTags_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Course_AuthorId",
                table: "Courses",
                newName: "IX_Courses_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseTags",
                table: "CourseTags",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Authors_AuthorId",
                table: "Courses",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTags_Courses_CourseId",
                table: "CourseTags",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTags_CourseTags_CourseTagId",
                table: "CourseTags",
                column: "CourseTagId",
                principalTable: "CourseTags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTags_Tags_TagId",
                table: "CourseTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Authors_AuthorId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseTags_Courses_CourseId",
                table: "CourseTags");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseTags_CourseTags_CourseTagId",
                table: "CourseTags");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseTags_Tags_TagId",
                table: "CourseTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseTags",
                table: "CourseTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.RenameTable(
                name: "Tags",
                newName: "Tag");

            migrationBuilder.RenameTable(
                name: "CourseTags",
                newName: "CourseTag");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Course");

            migrationBuilder.RenameTable(
                name: "Authors",
                newName: "Author");

            migrationBuilder.RenameIndex(
                name: "IX_CourseTags_TagId",
                table: "CourseTag",
                newName: "IX_CourseTag_TagId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseTags_CourseTagId",
                table: "CourseTag",
                newName: "IX_CourseTag_CourseTagId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseTags_CourseId",
                table: "CourseTag",
                newName: "IX_CourseTag_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_AuthorId",
                table: "Course",
                newName: "IX_Course_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tag",
                table: "Tag",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseTag",
                table: "CourseTag",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Author",
                table: "Author",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Author_AuthorId",
                table: "Course",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTag_Course_CourseId",
                table: "CourseTag",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTag_CourseTag_CourseTagId",
                table: "CourseTag",
                column: "CourseTagId",
                principalTable: "CourseTag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTag_Tag_TagId",
                table: "CourseTag",
                column: "TagId",
                principalTable: "Tag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
