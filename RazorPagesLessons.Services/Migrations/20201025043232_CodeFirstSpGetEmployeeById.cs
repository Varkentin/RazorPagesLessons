using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesLessons.Services.Migrations
{
    public partial class CodeFirstSpGetEmployeeById : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Create procedure CodeFirstSpGetEmployeeById
                                   @Id int
                                   as
                                   Begin
                                        Select * from Employees
                                        where Id = @Id
                                   End";
            migrationBuilder.Sql(procedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Drop procedure CodeFirstSpGetEmployeeBy";
            migrationBuilder.Sql(procedure);

        }
    }
}
