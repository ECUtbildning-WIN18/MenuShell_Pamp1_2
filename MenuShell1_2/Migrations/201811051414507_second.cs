namespace MenuShell1_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeOfAnimal = c.String(),
                        Name = c.String(),
                        Dob = c.DateTime(nullable: false),
                        Owner_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Owners", t => t.Owner_Id)
                .Index(t => t.Owner_Id);
            
            CreateTable(
                "dbo.Owners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        SocSecNr = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AppointmentDate = c.DateTime(nullable: false),
                        Problem = c.String(),
                        Animal_Id = c.Int(),
                        Owner_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Animals", t => t.Animal_Id)
                .ForeignKey("dbo.Owners", t => t.Owner_Id)
                .Index(t => t.Animal_Id)
                .Index(t => t.Owner_Id);
            
            CreateTable(
                "dbo.Journals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ailment = c.String(),
                        Animal_Id = c.Int(),
                        Owner_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Animals", t => t.Animal_Id)
                .ForeignKey("dbo.Owners", t => t.Owner_Id)
                .Index(t => t.Animal_Id)
                .Index(t => t.Owner_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Journals", "Owner_Id", "dbo.Owners");
            DropForeignKey("dbo.Journals", "Animal_Id", "dbo.Animals");
            DropForeignKey("dbo.Appointments", "Owner_Id", "dbo.Owners");
            DropForeignKey("dbo.Appointments", "Animal_Id", "dbo.Animals");
            DropForeignKey("dbo.Animals", "Owner_Id", "dbo.Owners");
            DropIndex("dbo.Journals", new[] { "Owner_Id" });
            DropIndex("dbo.Journals", new[] { "Animal_Id" });
            DropIndex("dbo.Appointments", new[] { "Owner_Id" });
            DropIndex("dbo.Appointments", new[] { "Animal_Id" });
            DropIndex("dbo.Animals", new[] { "Owner_Id" });
            DropTable("dbo.Journals");
            DropTable("dbo.Appointments");
            DropTable("dbo.Owners");
            DropTable("dbo.Animals");
        }
    }
}
