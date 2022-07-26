﻿namespace Vidzy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _4thIteration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Videos", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Videos", new[] { "Genre_Id" });
            RenameColumn(table: "dbo.Videos", name: "Genre_Id", newName: "GenreId");
            DropPrimaryKey("dbo.Genres");
            AlterColumn("dbo.Genres", "Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Videos", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Videos", "Classification", c => c.Byte(nullable: false));
            AlterColumn("dbo.Videos", "GenreId", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Genres", "Id");
            CreateIndex("dbo.Videos", "GenreId");
            AddForeignKey("dbo.Videos", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Videos", "GenreId", "dbo.Genres");
            DropIndex("dbo.Videos", new[] { "GenreId" });
            DropPrimaryKey("dbo.Genres");
            AlterColumn("dbo.Videos", "GenreId", c => c.Int());
            AlterColumn("dbo.Videos", "Classification", c => c.Int(nullable: false));
            AlterColumn("dbo.Videos", "Name", c => c.String());
            AlterColumn("dbo.Genres", "Name", c => c.String());
            AlterColumn("dbo.Genres", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Genres", "Id");
            RenameColumn(table: "dbo.Videos", name: "GenreId", newName: "Genre_Id");
            CreateIndex("dbo.Videos", "Genre_Id");
            AddForeignKey("dbo.Videos", "Genre_Id", "dbo.Genres", "Id");
        }
    }
}
