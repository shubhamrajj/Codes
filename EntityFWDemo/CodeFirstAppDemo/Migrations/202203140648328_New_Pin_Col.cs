namespace CodeFirstAppDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New_Pin_Col : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbl_customer", "Pincode", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tbl_customer", "Pincode");
        }
    }
}
