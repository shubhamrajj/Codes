namespace CodeFirstAppDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Drop_Col_Pin : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tbl_customer", "Pincode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tbl_customer", "Pincode", c => c.Int(nullable: false));
        }
    }
}
