using CoreLearning.API.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace CoreLearning.API.Data
{
    public class CoreLearningDBContext : DbContext
    {
        public CoreLearningDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region  seed the data fopr the difficulties
            var difficulties = new List<Difficulty>(){
                new Difficulty()
                {
                    Id=Guid.Parse("fb7abb56-6a34-4403-b67c-3c963c178600"),
                    Name="Easy",
                },
                new Difficulty()
                {
                    Id=Guid.Parse("bc5772c0-5f62-4fab-b99c-c706749f5f9d"),
                    Name="Medium",
                },
                new Difficulty()
                {
                    Id= Guid.Parse("afe7fc48-bcb9-44ca-85a8-2f4ea8016638"),
                    Name="Hard",
                },
            };
            // seed difficulties to database
            modelBuilder.Entity<Difficulty>().HasData(difficulties);
            #endregion

            #region Seed Data for Regions
            var regions = new List<Region>
            {
                new Region()
                {
                    Id=Guid.Parse("df63303b-f7da-45d9-9ba9-5b0c9cbccd1b"),
                    Name="Gujarat",
                    Code="GJ",
                    RegionImageUrl ="https://www.google.com/url?sa=i&url=https%3A%2F%2Fstock.adobe.com%2Fsearch%3Fk%3Dgujarat%2Bmap&psig=AOvVaw3b0B2UfZ-jfvSasOPu9OA6&ust=1699107375317000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCIjbwK6CqIIDFQAAAAAdAAAAABAE"
                },
                new Region()
                {
                    Id=Guid.Parse("41d3352d-2182-4ce9-be1b-c30d3af15b86"),
                    Name="Rajasthan",
                    Code="RJ",
                    RegionImageUrl ="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.mapsofindia.com%2Fmaps%2Frajasthan%2F&psig=AOvVaw1Lbu_lsMXAN4l2DtuEdyzv&ust=1699107459863000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCJD48taCqIIDFQAAAAAdAAAAABAJ"
                },
                new Region()
                {
                    Id=Guid.Parse("915c3eb9-9199-4c42-b127-672d9778699c"),
                    Name="Maharastra",
                    Code="MH",
                    RegionImageUrl ="https://www.google.com/url?sa=i&url=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FGeography_of_Maharashtra&psig=AOvVaw3vItKiMLD0TlI8k89RNuKN&ust=1699107533018000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCPiS1_mCqIIDFQAAAAAdAAAAABAE"
                },
                new Region()
                {
                    Id=Guid.Parse("a0b6d31e-828c-4948-ab5b-05a7844ddcb2"),
                    Name="Delhi",
                    Code="DL",
                    RegionImageUrl ="https://www.google.com/url?sa=i&url=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FNational_Capital_Region_%2528India%2529&psig=AOvVaw1B-sJYDzq3vTUzhtTCgSCm&ust=1699107574151000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCNjZ-YyDqIIDFQAAAAAdAAAAABAE"
                },
                new Region()
                {
                    Id=Guid.Parse("faab149c-f5cd-4035-9fe0-63c0eb1a4b7f"),
                    Name="MadhyaPradesh",
                    Code="MP",
                    RegionImageUrl ="https://www.google.com/url?sa=i&url=http%3A%2F%2Fwww.slbcmadhyapradesh.in%2Fgeographical-map.aspx&psig=AOvVaw2AYreGQs4RUOMjBHNxTMkl&ust=1699107643409000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCPCBhK6DqIIDFQAAAAAdAAAAABAE"
                },
            };
            // seed difficulties to database
            modelBuilder.Entity<Region>().HasData(regions);
            #endregion
        }
    }
}
