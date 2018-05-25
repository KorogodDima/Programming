namespace Service.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class abc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "db0.DbFaults",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Description = c.String(),
                    DbRepairRequest_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DbRideRequests", t => t.DbRepairRequest_Id)
                .Index(t => t.DbRepairRequest_Id);

            CreateTable(
                "dbo.DbRideRequests",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Filled = c.DateTime(nullable: false),
                    FullName = c.String(),
                    Model = c.String(),
                    Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.DbFaults", "DbRepairRequest_Id", "dbo.DbRepairRequests");
            DropIndex("dbo.DbFaults", new[] { "DbRepairRequest_Id" });
            DropTable("dbo.DbRepairRequests");
            DropTable("dbo.DbFaults");
        }
    }
}
