namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedMembershipTypeWithName : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes Set Name='Pay as You Go' WHERE SignUpFee=0");
            Sql("Update MembershipTypes Set Name='Monthly' WHERE SignUpFee=30");
            Sql("Update MembershipTypes Set Name='Quarterly' WHERE SignUpFee=90");
            Sql("Update MembershipTypes Set Name='Annual' WHERE SignUpFee=300");
        }
        
        public override void Down()
        {
        }
    }
}
