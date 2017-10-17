namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedtaleName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AspNetUsers", newName: "User");
            RenameTable(name: "dbo.AspNetUserClaims", newName: "userClaim");
            RenameColumn(table: "dbo.User", name: "Id", newName: "UserId");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.User", name: "UserId", newName: "Id");
            RenameTable(name: "dbo.userClaim", newName: "AspNetUserClaims");
            RenameTable(name: "dbo.User", newName: "AspNetUsers");
        }
    }
}
