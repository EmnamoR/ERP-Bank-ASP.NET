namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class emna : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "bank.candidature",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        cv = c.String(maxLength: 100, storeType: "nvarchar"),
                        email = c.String(maxLength: 100, storeType: "nvarchar"),
                        lastName = c.String(maxLength: 100, storeType: "nvarchar"),
                        name = c.String(maxLength: 100, storeType: "nvarchar"),
                        role = c.String(maxLength: 100, storeType: "nvarchar"),
                        state = c.String(maxLength: 100, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "bank.contract",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        contractType = c.String(maxLength: 100, storeType: "nvarchar"),
                        endDate = c.DateTime(precision: 0),
                        startDate = c.DateTime(precision: 0),
                        employee_id = c.String(maxLength: 100, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("bank.employee", t => t.employee_id)
                .Index(t => t.employee_id);
            
            CreateTable(
                "bank.employee",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        email = c.String(maxLength: 100, storeType: "nvarchar"),
                        lastName = c.String(maxLength: 100, storeType: "nvarchar"),
                        name = c.String(maxLength: 100, storeType: "nvarchar"),
                        passWord = c.String(maxLength: 100, storeType: "nvarchar"),
                        role = c.String(maxLength: 100, storeType: "nvarchar"),
                        userName = c.String(maxLength: 100, storeType: "nvarchar"),
                        local_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("bank.local", t => t.local_id)
                .Index(t => t.local_id);
            
            CreateTable(
                "bank.local",
                c => new
                    {
                        id = c.Int(nullable: false),
                        city = c.String(maxLength: 100, storeType: "nvarchar"),
                        region = c.String(maxLength: 100, storeType: "nvarchar"),
                        typeLocal = c.String(maxLength: 100, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "bank.material",
                c => new
                    {
                        idMat = c.Int(nullable: false),
                        designation = c.String(maxLength: 100, storeType: "nvarchar"),
                        quantite = c.Int(nullable: false),
                        local_id = c.Int(),
                        supplier_id_supp = c.Int(),
                    })
                .PrimaryKey(t => t.idMat)
                .ForeignKey("bank.local", t => t.local_id)
                .ForeignKey("bank.supplier", t => t.supplier_id_supp)
                .Index(t => t.local_id)
                .Index(t => t.supplier_id_supp);
            
            CreateTable(
                "bank.supplier",
                c => new
                    {
                        id_supp = c.Int(nullable: false),
                        adress = c.String(maxLength: 100, storeType: "nvarchar"),
                        email = c.String(maxLength: 100, storeType: "nvarchar"),
                        name = c.String(maxLength: 100, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id_supp);
            
            CreateTable(
                "bank.payroll",
                c => new
                    {
                        id = c.Int(nullable: false),
                        addsAmount = c.Single(nullable: false),
                        endDate = c.String(maxLength: 100, storeType: "nvarchar"),
                        extraWorkedHours = c.Int(nullable: false),
                        startDate = c.String(maxLength: 100, storeType: "nvarchar"),
                        workedHours = c.Int(nullable: false),
                        employee_id = c.String(maxLength: 100, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("bank.employee", t => t.employee_id)
                .Index(t => t.employee_id);
            
            CreateTable(
                "bank.trainingsession",
                c => new
                    {
                        id = c.Int(nullable: false),
                        description = c.String(maxLength: 100, storeType: "nvarchar"),
                        endDate = c.String(maxLength: 100, storeType: "nvarchar"),
                        startDate = c.String(maxLength: 100, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "bank.meeting",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        email = c.String(maxLength: 100, storeType: "nvarchar"),
                        lastName = c.String(maxLength: 100, storeType: "nvarchar"),
                        name = c.String(maxLength: 100, storeType: "nvarchar"),
                        role = c.String(maxLength: 100, storeType: "nvarchar"),
                        state = c.String(maxLength: 100, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        Name = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        RoleId = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
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
                        Id = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        Email = c.String(maxLength: 100, storeType: "nvarchar"),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(unicode: false),
                        SecurityStamp = c.String(unicode: false),
                        PhoneNumber = c.String(unicode: false),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(precision: 0),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        ClaimType = c.String(unicode: false),
                        ClaimValue = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        ProviderKey = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        UserId = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "bank.t_user_training",
                c => new
                    {
                        participants_id = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        trainingSessions_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.participants_id, t.trainingSessions_id })
                .ForeignKey("bank.employee", t => t.participants_id, cascadeDelete: true)
                .ForeignKey("bank.trainingsession", t => t.trainingSessions_id, cascadeDelete: true)
                .Index(t => t.participants_id)
                .Index(t => t.trainingSessions_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("bank.contract", "employee_id", "bank.employee");
            DropForeignKey("bank.t_user_training", "trainingSessions_id", "bank.trainingsession");
            DropForeignKey("bank.t_user_training", "participants_id", "bank.employee");
            DropForeignKey("bank.payroll", "employee_id", "bank.employee");
            DropForeignKey("bank.employee", "local_id", "bank.local");
            DropForeignKey("bank.material", "supplier_id_supp", "bank.supplier");
            DropForeignKey("bank.material", "local_id", "bank.local");
            DropIndex("bank.t_user_training", new[] { "trainingSessions_id" });
            DropIndex("bank.t_user_training", new[] { "participants_id" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("bank.payroll", new[] { "employee_id" });
            DropIndex("bank.material", new[] { "supplier_id_supp" });
            DropIndex("bank.material", new[] { "local_id" });
            DropIndex("bank.employee", new[] { "local_id" });
            DropIndex("bank.contract", new[] { "employee_id" });
            DropTable("bank.t_user_training");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("bank.meeting");
            DropTable("bank.trainingsession");
            DropTable("bank.payroll");
            DropTable("bank.supplier");
            DropTable("bank.material");
            DropTable("bank.local");
            DropTable("bank.employee");
            DropTable("bank.contract");
            DropTable("bank.candidature");
        }
    }
}
