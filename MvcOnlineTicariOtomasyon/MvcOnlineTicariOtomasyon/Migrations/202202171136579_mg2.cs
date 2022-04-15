namespace MvcOnlineTicariOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.mesajlars", "Gonderici", c => c.Int());
            AlterColumn("dbo.mesajlars", "altkonu", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.mesajlars", "altkonu", c => c.String(maxLength: 200, unicode: false));
            AlterColumn("dbo.mesajlars", "Gonderici", c => c.String(maxLength: 50, unicode: false));
        }
    }
}
