using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASP.NETCoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class PopulateBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "books");

            migrationBuilder.AddPrimaryKey(
                name: "PK_books",
                table: "books",
                column: "id");

            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "id", "author", "launch_date", "price", "title" },
                values: new object[,]
                {
                    { 1L, "Michael C. Feathers", new DateTime(2004, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 49.00m, "Working Effectively with Legacy Code" },
                    { 2L, "Ralph Johnson, Erich Gamma, John Vlissides, Richard Helm", new DateTime(1994, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.00m, "Design Patterns: Elements of Reusable Object-Oriented Software" },
                    { 3L, "Robert C. Martin", new DateTime(2008, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 77.00m, "Clean Code: A Handbook of Agile Software Craftsmanship" },
                    { 4L, "Douglas Crockford", new DateTime(2008, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 67.00m, "JavaScript: The Good Parts" },
                    { 5L, "Steve McConnell", new DateTime(2004, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 58.00m, "Code Complete (2nd Edition)" },
                    { 6L, "Martin Fowler, Kent Beck", new DateTime(1999, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 88.00m, "Refactoring: Improving the Design of Existing Code" },
                    { 7L, "Eric Freeman, Elisabeth Freeman, Kathy Sierra, Bert Bates", new DateTime(2004, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 110.00m, "Head First Design Patterns" },
                    { 8L, "Eric Evans", new DateTime(2003, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 92.00m, "Domain-Driven Design: Tackling Complexity in the Heart of Software" },
                    { 9L, "Brian Goetz, Tim Peierls", new DateTime(2006, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 80.00m, "Java Concurrency in Practice" },
                    { 10L, "Susan Cain", new DateTime(2012, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 123.00m, "Quiet: The Power of Introverts in a World That Can''t Stop Talking" },
                    { 11L, "Roger S. Pressman", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 56.00m, "Software Engineering: A Practitioner''s Approach (7th Edition)" },
                    { 12L, "Viktor Mayer-Schonberger, Kenneth Kukier", new DateTime(2013, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 54.00m, "Big Data: A Revolution That Will Transform How We Live, Work, and Think" },
                    { 13L, "Richard Hunter, George Westerman", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 95.00m, "The Real Business of IT: How CIOs Create and Communicate Value" },
                    { 14L, "Aguinaldo Aragon Fernandes, Vladimir Ferraz de Abreu", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 54.00m, "Implementing IT Governance: A Practical Guide to Global Best Practices in IT Management" },
                    { 15L, "Marc J. Schiller", new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.00m, "The 11 Secrets of Highly Influential IT Leaders" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_books",
                table: "books");

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 15L);

            migrationBuilder.RenameTable(
                name: "books",
                newName: "Books");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "id");
        }
    }
}
