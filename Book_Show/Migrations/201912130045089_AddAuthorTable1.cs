namespace Book_Show.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAuthorTable1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookName = c.String(),
                        PagesNamber = c.Int(nullable: false),
                        ISBAN = c.String(),
                        Author_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.Author_Id)
                .Index(t => t.Author_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "Author_Id", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "Author_Id" });
            DropTable("dbo.Books");
        }
    }
}
