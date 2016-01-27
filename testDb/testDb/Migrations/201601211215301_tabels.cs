namespace testDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tabels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "Model", c => c.String());
            AddColumn("dbo.Cars", "Price", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "Price");
            DropColumn("dbo.Cars", "Model");
        }
    }
}
