namespace DataSaving.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class required : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.LogDTOes", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.LogDTOes", "Surname", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.LogDTOes", "Surname", c => c.String());
            AlterColumn("dbo.LogDTOes", "Name", c => c.String());
        }
    }
}
