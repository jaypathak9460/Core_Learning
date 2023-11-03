using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CoreLearning.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDatafordifficultiesandRegions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("afe7fc48-bcb9-44ca-85a8-2f4ea8016638"), "Hard" },
                    { new Guid("bc5772c0-5f62-4fab-b99c-c706749f5f9d"), "Medium" },
                    { new Guid("fb7abb56-6a34-4403-b67c-3c963c178600"), "Easy" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("41d3352d-2182-4ce9-be1b-c30d3af15b86"), "RJ", "Rajasthan", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.mapsofindia.com%2Fmaps%2Frajasthan%2F&psig=AOvVaw1Lbu_lsMXAN4l2DtuEdyzv&ust=1699107459863000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCJD48taCqIIDFQAAAAAdAAAAABAJ" },
                    { new Guid("915c3eb9-9199-4c42-b127-672d9778699c"), "MH", "Maharastra", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FGeography_of_Maharashtra&psig=AOvVaw3vItKiMLD0TlI8k89RNuKN&ust=1699107533018000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCPiS1_mCqIIDFQAAAAAdAAAAABAE" },
                    { new Guid("a0b6d31e-828c-4948-ab5b-05a7844ddcb2"), "DL", "Delhi", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FNational_Capital_Region_%2528India%2529&psig=AOvVaw1B-sJYDzq3vTUzhtTCgSCm&ust=1699107574151000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCNjZ-YyDqIIDFQAAAAAdAAAAABAE" },
                    { new Guid("df63303b-f7da-45d9-9ba9-5b0c9cbccd1b"), "GJ", "Gujarat", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fstock.adobe.com%2Fsearch%3Fk%3Dgujarat%2Bmap&psig=AOvVaw3b0B2UfZ-jfvSasOPu9OA6&ust=1699107375317000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCIjbwK6CqIIDFQAAAAAdAAAAABAE" },
                    { new Guid("faab149c-f5cd-4035-9fe0-63c0eb1a4b7f"), "MP", "MadhyaPradesh", "https://www.google.com/url?sa=i&url=http%3A%2F%2Fwww.slbcmadhyapradesh.in%2Fgeographical-map.aspx&psig=AOvVaw2AYreGQs4RUOMjBHNxTMkl&ust=1699107643409000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCPCBhK6DqIIDFQAAAAAdAAAAABAE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("afe7fc48-bcb9-44ca-85a8-2f4ea8016638"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("bc5772c0-5f62-4fab-b99c-c706749f5f9d"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("fb7abb56-6a34-4403-b67c-3c963c178600"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("41d3352d-2182-4ce9-be1b-c30d3af15b86"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("915c3eb9-9199-4c42-b127-672d9778699c"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a0b6d31e-828c-4948-ab5b-05a7844ddcb2"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("df63303b-f7da-45d9-9ba9-5b0c9cbccd1b"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("faab149c-f5cd-4035-9fe0-63c0eb1a4b7f"));
        }
    }
}
