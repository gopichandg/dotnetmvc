namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedfieldintable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "SurName", c => c.String());
            AddColumn("dbo.AspNetUsers", "FatherName", c => c.String());
            AddColumn("dbo.AspNetUsers", "DateOfBirth", c => c.String());
            AddColumn("dbo.AspNetUsers", "Caste", c => c.String());
            AddColumn("dbo.AspNetUsers", "SubCaste", c => c.String());
            AddColumn("dbo.AspNetUsers", "State", c => c.String());
            AddColumn("dbo.AspNetUsers", "District", c => c.String());
            AddColumn("dbo.AspNetUsers", "Mandal", c => c.String());
            AddColumn("dbo.AspNetUsers", "Village", c => c.String());
            AddColumn("dbo.AspNetUsers", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Address");
            DropColumn("dbo.AspNetUsers", "Village");
            DropColumn("dbo.AspNetUsers", "Mandal");
            DropColumn("dbo.AspNetUsers", "District");
            DropColumn("dbo.AspNetUsers", "State");
            DropColumn("dbo.AspNetUsers", "SubCaste");
            DropColumn("dbo.AspNetUsers", "Caste");
            DropColumn("dbo.AspNetUsers", "DateOfBirth");
            DropColumn("dbo.AspNetUsers", "FatherName");
            DropColumn("dbo.AspNetUsers", "SurName");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}
