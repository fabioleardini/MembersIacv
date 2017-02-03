namespace MembersIacv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EcclesiasticalFunctions",
                c => new
                    {
                        EcclesiasticalFunctionId = c.Short(nullable: false, identity: true),
                        Description = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.EcclesiasticalFunctionId);
            
            CreateTable(
                "dbo.MartialStatus",
                c => new
                    {
                        MartialStatusId = c.Short(nullable: false, identity: true),
                        Description = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.MartialStatusId);
            
            CreateTable(
                "dbo.MemberViewModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 80),
                        BirthDay = c.DateTime(nullable: false),
                        NaturalOf = c.String(maxLength: 40),
                        MartialStatusId = c.Short(nullable: false),
                        Spouse = c.String(maxLength: 80),
                        MarriageDate = c.DateTime(nullable: false),
                        Father = c.String(maxLength: 80),
                        Mother = c.String(maxLength: 80),
                        HomePhone = c.String(maxLength: 10),
                        Mobile = c.String(maxLength: 11),
                        Email = c.String(),
                        Address = c.String(maxLength: 80),
                        District = c.String(maxLength: 40),
                        Ciy = c.String(maxLength: 40),
                        StateId = c.Short(nullable: false),
                        Zip = c.Int(nullable: false),
                        Profession = c.String(maxLength: 30),
                        Education = c.String(maxLength: 40),
                        Workplace = c.String(maxLength: 80),
                        WorkPhone = c.String(maxLength: 10),
                        Cpf = c.Long(nullable: false),
                        Rg = c.Long(nullable: false),
                        Nationality = c.String(maxLength: 20),
                        BloodType = c.String(maxLength: 3),
                        BaptismDate = c.DateTime(nullable: false),
                        EcclesiasticalFunctionId = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EcclesiasticalFunctions", t => t.EcclesiasticalFunctionId, cascadeDelete: true)
                .ForeignKey("dbo.MartialStatus", t => t.MartialStatusId, cascadeDelete: true)
                .ForeignKey("dbo.States", t => t.StateId, cascadeDelete: true)
                .Index(t => t.MartialStatusId)
                .Index(t => t.StateId)
                .Index(t => t.EcclesiasticalFunctionId);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        StateId = c.Short(nullable: false, identity: true),
                        Description = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.StateId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.MemberViewModels", "StateId", "dbo.States");
            DropForeignKey("dbo.MemberViewModels", "MartialStatusId", "dbo.MartialStatus");
            DropForeignKey("dbo.MemberViewModels", "EcclesiasticalFunctionId", "dbo.EcclesiasticalFunctions");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.MemberViewModels", new[] { "EcclesiasticalFunctionId" });
            DropIndex("dbo.MemberViewModels", new[] { "StateId" });
            DropIndex("dbo.MemberViewModels", new[] { "MartialStatusId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.States");
            DropTable("dbo.MemberViewModels");
            DropTable("dbo.MartialStatus");
            DropTable("dbo.EcclesiasticalFunctions");
        }
    }
}
