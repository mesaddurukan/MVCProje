namespace EsadMVCProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class denemeBlog : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Yorumlars", "Yorumlar_ID", "dbo.Yorumlars");
            DropIndex("dbo.Yorumlars", new[] { "Yorumlar_ID" });
            DropColumn("dbo.Yorumlars", "Yorumlar_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Yorumlars", "Yorumlar_ID", c => c.Int());
            CreateIndex("dbo.Yorumlars", "Yorumlar_ID");
            AddForeignKey("dbo.Yorumlars", "Yorumlar_ID", "dbo.Yorumlars", "ID");
        }
    }
}
