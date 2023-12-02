﻿namespace Tabish_Console.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateStudentTableWithGender : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Gender", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Gender");
        }
    }
}
