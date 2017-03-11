namespace mvcformsauthentication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class person : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BodyMeasures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Weight = c.Byte(),
                        Breast = c.Byte(),
                        Waist = c.Byte(),
                        Butt = c.Byte(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Consumes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        amount = c.Int(nullable: false),
                        consumedate = c.DateTime(nullable: false),
                        description = c.String(),
                        image = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Injuries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        injurydate = c.DateTime(nullable: false),
                        Injury1 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Byte(nullable: false),
                        Height = c.Byte(nullable: false),
                        Weight = c.Byte(nullable: false),
                        Strength = c.Int(nullable: false),
                        Stamina = c.Int(nullable: false),
                        Intelligence = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
            DropTable("dbo.Injuries");
            DropTable("dbo.Consumes");
            DropTable("dbo.BodyMeasures");
        }
    }
}
