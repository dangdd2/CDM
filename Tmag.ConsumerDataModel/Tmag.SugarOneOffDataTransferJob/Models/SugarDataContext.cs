using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq;
using System.Linq.Expressions;
using Tmag.Common.Models;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class SugarDataContext : DbContext
    {
        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<AccountsAudit> AccountsAudit { get; set; }
        public virtual DbSet<AccountsBugs> AccountsBugs { get; set; }
        public virtual DbSet<AccountsCases> AccountsCases { get; set; }
        public virtual DbSet<AccountsContacts> AccountsContacts { get; set; }
        public virtual DbSet<AccountsCrCallRecords1C> AccountsCrCallRecords1C { get; set; }
        public virtual DbSet<AccountsCstm> AccountsCstm { get; set; }
        public virtual DbSet<AccountsOpportunities> AccountsOpportunities { get; set; }
        public virtual DbSet<AccountsRRetailDemoDays1C> AccountsRRetailDemoDays1C { get; set; }
        public virtual DbSet<AclActions> AclActions { get; set; }
        public virtual DbSet<AclFields> AclFields { get; set; }
        public virtual DbSet<AclRoles> AclRoles { get; set; }
        public virtual DbSet<AclRolesActions> AclRolesActions { get; set; }
        public virtual DbSet<AclRoleSets> AclRoleSets { get; set; }
        public virtual DbSet<AclRoleSetsAclRoles> AclRoleSetsAclRoles { get; set; }
        public virtual DbSet<AclRolesUsers> AclRolesUsers { get; set; }
        public virtual DbSet<Activities> Activities { get; set; }
        public virtual DbSet<ActivitiesUsers> ActivitiesUsers { get; set; }
        public virtual DbSet<AddressBook> AddressBook { get; set; }
        public virtual DbSet<AddressBookListItems> AddressBookListItems { get; set; }
        public virtual DbSet<AddressBookLists> AddressBookLists { get; set; }
        public virtual DbSet<Bugs> Bugs { get; set; }
        public virtual DbSet<BugsAudit> BugsAudit { get; set; }
        public virtual DbSet<Calls> Calls { get; set; }
        public virtual DbSet<CallsContacts> CallsContacts { get; set; }
        public virtual DbSet<CallsCstm> CallsCstm { get; set; }
        public virtual DbSet<CallsLeads> CallsLeads { get; set; }
        public virtual DbSet<CallsUsers> CallsUsers { get; set; }
        public virtual DbSet<CampaignLog> CampaignLog { get; set; }
        public virtual DbSet<Campaigns> Campaigns { get; set; }
        public virtual DbSet<CampaignsAudit> CampaignsAudit { get; set; }
        public virtual DbSet<CampaignTrkrs> CampaignTrkrs { get; set; }
        public virtual DbSet<Cases> Cases { get; set; }
        public virtual DbSet<CasesAudit> CasesAudit { get; set; }
        public virtual DbSet<CasesBugs> CasesBugs { get; set; }
        public virtual DbSet<CasesCstm> CasesCstm { get; set; }
        public virtual DbSet<CasesPProductRegistrations1C> CasesPProductRegistrations1C { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<CategoryTree> CategoryTree { get; set; }
        public virtual DbSet<CConsumerCampaigns> CConsumerCampaigns { get; set; }
        public virtual DbSet<CConsumerCampaignsAudit> CConsumerCampaignsAudit { get; set; }
        public virtual DbSet<CConsumerCampaignsCConsumersC> CConsumerCampaignsCConsumersC { get; set; }
        public virtual DbSet<CConsumerCampaignsCstm> CConsumerCampaignsCstm { get; set; }
        public virtual DbSet<CConsumers> CConsumers { get; set; }
        public virtual DbSet<CConsumersAudit> CConsumersAudit { get; set; }
        public virtual DbSet<CConsumersCases1C> CConsumersCases1C { get; set; }
        public virtual DbSet<CConsumersCrCallRecords1C> CConsumersCrCallRecords1C { get; set; }
        public virtual DbSet<CConsumersCstm> CConsumersCstm { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<ContactsAudit> ContactsAudit { get; set; }
        public virtual DbSet<ContactsBugs> ContactsBugs { get; set; }
        public virtual DbSet<ContactsCases> ContactsCases { get; set; }
        public virtual DbSet<ContactsCstm> ContactsCstm { get; set; }
        public virtual DbSet<ContactsUsers> ContactsUsers { get; set; }
        public virtual DbSet<Contracts> Contracts { get; set; }
        public virtual DbSet<ContractsAudit> ContractsAudit { get; set; }
        public virtual DbSet<ContractsContacts> ContractsContacts { get; set; }
        public virtual DbSet<ContractsOpportunities> ContractsOpportunities { get; set; }
        public virtual DbSet<ContractsProducts> ContractsProducts { get; set; }
        public virtual DbSet<ContractsQuotes> ContractsQuotes { get; set; }
        public virtual DbSet<ContractTypes> ContractTypes { get; set; }
        public virtual DbSet<CrCallRecords> CrCallRecords { get; set; }
        public virtual DbSet<CrCallRecordsAudit> CrCallRecordsAudit { get; set; }
        public virtual DbSet<Currencies> Currencies { get; set; }
        public virtual DbSet<Dashboards> Dashboards { get; set; }
        public virtual DbSet<DocumentRevisions> DocumentRevisions { get; set; }
        public virtual DbSet<Documents> Documents { get; set; }
        public virtual DbSet<DocumentsAccounts> DocumentsAccounts { get; set; }
        public virtual DbSet<DocumentsBugs> DocumentsBugs { get; set; }
        public virtual DbSet<DocumentsCases> DocumentsCases { get; set; }
        public virtual DbSet<DocumentsContacts> DocumentsContacts { get; set; }
        public virtual DbSet<DocumentsOpportunities> DocumentsOpportunities { get; set; }
        public virtual DbSet<DocumentsProducts> DocumentsProducts { get; set; }
        public virtual DbSet<DocumentsQuotes> DocumentsQuotes { get; set; }
        public virtual DbSet<DocumentsRevenuelineitems> DocumentsRevenuelineitems { get; set; }
        public virtual DbSet<Eapm> Eapm { get; set; }
        public virtual DbSet<EExperiences> EExperiences { get; set; }
        public virtual DbSet<EExperiencesAudit> EExperiencesAudit { get; set; }
        public virtual DbSet<EExperiencesCConsumersC> EExperiencesCConsumersC { get; set; }
        public virtual DbSet<EmailAddrBeanRel> EmailAddrBeanRel { get; set; }
        public virtual DbSet<EmailAddresses> EmailAddresses { get; set; }
        public virtual DbSet<Emailman> Emailman { get; set; }
        public virtual DbSet<EmailMarketing> EmailMarketing { get; set; }
        public virtual DbSet<EmailMarketingProspectLists> EmailMarketingProspectLists { get; set; }
        public virtual DbSet<Emails> Emails { get; set; }
        public virtual DbSet<EmailsBeans> EmailsBeans { get; set; }
        public virtual DbSet<EmailsEmailAddrRel> EmailsEmailAddrRel { get; set; }
        public virtual DbSet<EmailsText> EmailsText { get; set; }
        public virtual DbSet<EmailTemplates> EmailTemplates { get; set; }
        public virtual DbSet<EmbeddedFiles> EmbeddedFiles { get; set; }
        public virtual DbSet<Expressions> Expressions { get; set; }
        public virtual DbSet<FieldsMetaData> FieldsMetaData { get; set; }
        public virtual DbSet<Filters> Filters { get; set; }
        public virtual DbSet<Folders> Folders { get; set; }
        public virtual DbSet<FoldersRel> FoldersRel { get; set; }
        public virtual DbSet<FoldersSubscriptions> FoldersSubscriptions { get; set; }
        public virtual DbSet<ForecastManagerWorksheets> ForecastManagerWorksheets { get; set; }
        public virtual DbSet<ForecastManagerWorksheetsAudit> ForecastManagerWorksheetsAudit { get; set; }
        public virtual DbSet<Forecasts> Forecasts { get; set; }
        public virtual DbSet<ForecastSchedule> ForecastSchedule { get; set; }
        public virtual DbSet<ForecastTree> ForecastTree { get; set; }
        public virtual DbSet<ForecastWorksheets> ForecastWorksheets { get; set; }
        public virtual DbSet<FtsQueue> FtsQueue { get; set; }
        public virtual DbSet<Healthcheck> Healthcheck { get; set; }
        public virtual DbSet<Holidays> Holidays { get; set; }
        public virtual DbSet<ImportMaps> ImportMaps { get; set; }
        public virtual DbSet<InboundEmail> InboundEmail { get; set; }
        public virtual DbSet<InboundEmailAutoreply> InboundEmailAutoreply { get; set; }
        public virtual DbSet<InboundEmailCacheTs> InboundEmailCacheTs { get; set; }
        public virtual DbSet<JobQueue> JobQueue { get; set; }
        public virtual DbSet<JobQueueAudit> JobQueueAudit { get; set; }
        public virtual DbSet<Kbarticles> Kbarticles { get; set; }
        public virtual DbSet<Kbcontents> Kbcontents { get; set; }
        public virtual DbSet<KbcontentsAudit> KbcontentsAudit { get; set; }
        public virtual DbSet<KbcontentTemplates> KbcontentTemplates { get; set; }
        public virtual DbSet<KbcontentTemplatesAudit> KbcontentTemplatesAudit { get; set; }
        public virtual DbSet<Kbdocuments> Kbdocuments { get; set; }
        public virtual DbSet<Kbusefulness> Kbusefulness { get; set; }
        public virtual DbSet<KeyValueCache> KeyValueCache { get; set; }
        public virtual DbSet<Leads> Leads { get; set; }
        public virtual DbSet<LeadsAudit> LeadsAudit { get; set; }
        public virtual DbSet<LinkedDocuments> LinkedDocuments { get; set; }
        public virtual DbSet<Manufacturers> Manufacturers { get; set; }
        public virtual DbSet<Meetings> Meetings { get; set; }
        public virtual DbSet<MeetingsContacts> MeetingsContacts { get; set; }
        public virtual DbSet<MeetingsLeads> MeetingsLeads { get; set; }
        public virtual DbSet<MeetingsUsers> MeetingsUsers { get; set; }
        public virtual DbSet<MetadataCache> MetadataCache { get; set; }
        public virtual DbSet<Notes> Notes { get; set; }
        public virtual DbSet<NotesCstm> NotesCstm { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<NotificationsAudit> NotificationsAudit { get; set; }
        public virtual DbSet<OauthConsumer> OauthConsumer { get; set; }
        public virtual DbSet<OauthNonce> OauthNonce { get; set; }
        public virtual DbSet<OauthTokens> OauthTokens { get; set; }
        public virtual DbSet<Opportunities> Opportunities { get; set; }
        public virtual DbSet<OpportunitiesAudit> OpportunitiesAudit { get; set; }
        public virtual DbSet<OpportunitiesContacts> OpportunitiesContacts { get; set; }
        public virtual DbSet<OpsBackups> OpsBackups { get; set; }
        public virtual DbSet<OutboundEmail> OutboundEmail { get; set; }
        public virtual DbSet<Pdfmanager> Pdfmanager { get; set; }
        public virtual DbSet<PProductRegistrations> PProductRegistrations { get; set; }
        public virtual DbSet<PProductRegistrationsAudit> PProductRegistrationsAudit { get; set; }
        public virtual DbSet<PProductRegistrationsCConsumersC> PProductRegistrationsCConsumersC { get; set; }
        public virtual DbSet<PProductRegistrationsCstm> PProductRegistrationsCstm { get; set; }
        public virtual DbSet<ProductBundleNote> ProductBundleNote { get; set; }
        public virtual DbSet<ProductBundleNotes> ProductBundleNotes { get; set; }
        public virtual DbSet<ProductBundleProduct> ProductBundleProduct { get; set; }
        public virtual DbSet<ProductBundleQuote> ProductBundleQuote { get; set; }
        public virtual DbSet<ProductBundles> ProductBundles { get; set; }
        public virtual DbSet<ProductCategories> ProductCategories { get; set; }
        public virtual DbSet<ProductProduct> ProductProduct { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProductsAudit> ProductsAudit { get; set; }
        public virtual DbSet<ProductTemplates> ProductTemplates { get; set; }
        public virtual DbSet<ProductTemplatesAudit> ProductTemplatesAudit { get; set; }
        public virtual DbSet<ProductTypes> ProductTypes { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<ProjectResources> ProjectResources { get; set; }
        public virtual DbSet<ProjectsAccounts> ProjectsAccounts { get; set; }
        public virtual DbSet<ProjectsBugs> ProjectsBugs { get; set; }
        public virtual DbSet<ProjectsCases> ProjectsCases { get; set; }
        public virtual DbSet<ProjectsContacts> ProjectsContacts { get; set; }
        public virtual DbSet<ProjectsOpportunities> ProjectsOpportunities { get; set; }
        public virtual DbSet<ProjectsProducts> ProjectsProducts { get; set; }
        public virtual DbSet<ProjectsQuotes> ProjectsQuotes { get; set; }
        public virtual DbSet<ProjectsRevenueLineItems> ProjectsRevenueLineItems { get; set; }
        public virtual DbSet<ProjectTask> ProjectTask { get; set; }
        public virtual DbSet<ProjectTaskAudit> ProjectTaskAudit { get; set; }
        public virtual DbSet<ProspectListCampaigns> ProspectListCampaigns { get; set; }
        public virtual DbSet<ProspectLists> ProspectLists { get; set; }
        public virtual DbSet<ProspectListsProspects> ProspectListsProspects { get; set; }
        public virtual DbSet<Prospects> Prospects { get; set; }
        public virtual DbSet<Quotas> Quotas { get; set; }
        public virtual DbSet<QuotasAudit> QuotasAudit { get; set; }
        public virtual DbSet<Quotes> Quotes { get; set; }
        public virtual DbSet<QuotesAccounts> QuotesAccounts { get; set; }
        public virtual DbSet<QuotesAudit> QuotesAudit { get; set; }
        public virtual DbSet<QuotesContacts> QuotesContacts { get; set; }
        public virtual DbSet<QuotesOpportunities> QuotesOpportunities { get; set; }
        public virtual DbSet<RecordList> RecordList { get; set; }
        public virtual DbSet<Relationships> Relationships { get; set; }
        public virtual DbSet<Releases> Releases { get; set; }
        public virtual DbSet<ReportCache> ReportCache { get; set; }
        public virtual DbSet<ReportSchedules> ReportSchedules { get; set; }
        public virtual DbSet<RevenueLineItems> RevenueLineItems { get; set; }
        public virtual DbSet<RevenueLineItemsAudit> RevenueLineItemsAudit { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<RolesModules> RolesModules { get; set; }
        public virtual DbSet<RolesUsers> RolesUsers { get; set; }
        public virtual DbSet<RRetailDemoDays> RRetailDemoDays { get; set; }
        public virtual DbSet<RRetailDemoDaysAudit> RRetailDemoDaysAudit { get; set; }
        public virtual DbSet<SavedReports> SavedReports { get; set; }
        public virtual DbSet<SavedSearch> SavedSearch { get; set; }
        public virtual DbSet<Schedulers> Schedulers { get; set; }
        public virtual DbSet<SchedulersTimes> SchedulersTimes { get; set; }
        public virtual DbSet<SessionActive> SessionActive { get; set; }
        public virtual DbSet<SessionHistory> SessionHistory { get; set; }
        public virtual DbSet<Shippers> Shippers { get; set; }
        public virtual DbSet<SSurveys> SSurveys { get; set; }
        public virtual DbSet<SSurveysAccountsC> SSurveysAccountsC { get; set; }
        public virtual DbSet<SSurveysAudit> SSurveysAudit { get; set; }
        public virtual DbSet<SSurveysCasesC> SSurveysCasesC { get; set; }
        public virtual DbSet<SSurveysCConsumersC> SSurveysCConsumersC { get; set; }
        public virtual DbSet<SSurveysContactsC> SSurveysContactsC { get; set; }
        public virtual DbSet<SSurveysCstm> SSurveysCstm { get; set; }
        public virtual DbSet<Styleguide> Styleguide { get; set; }
        public virtual DbSet<Subscriptions> Subscriptions { get; set; }
        public virtual DbSet<Sugarfavorites> Sugarfavorites { get; set; }
        public virtual DbSet<Systems> Systems { get; set; }
        public virtual DbSet<TagBeanRel> TagBeanRel { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }
        public virtual DbSet<TagsAudit> TagsAudit { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }
        public virtual DbSet<TasksAudit> TasksAudit { get; set; }
        public virtual DbSet<TasksCstm> TasksCstm { get; set; }
        public virtual DbSet<Taxrates> Taxrates { get; set; }
        public virtual DbSet<TeamMemberships> TeamMemberships { get; set; }
        public virtual DbSet<TeamNotices> TeamNotices { get; set; }
        public virtual DbSet<Teams> Teams { get; set; }
        public virtual DbSet<TeamSets> TeamSets { get; set; }
        public virtual DbSet<TeamSetsModules> TeamSetsModules { get; set; }
        public virtual DbSet<TeamSetsTeams> TeamSetsTeams { get; set; }
        public virtual DbSet<Timeperiods> Timeperiods { get; set; }
        public virtual DbSet<Tracker> Tracker { get; set; }
        public virtual DbSet<TrackerPerf> TrackerPerf { get; set; }
        public virtual DbSet<TrackerQueries> TrackerQueries { get; set; }
        public virtual DbSet<TrackerSessions> TrackerSessions { get; set; }
        public virtual DbSet<TrackerTrackerQueries> TrackerTrackerQueries { get; set; }
        public virtual DbSet<UkCases> UkCases { get; set; }
        public virtual DbSet<UkCasesAccountsC> UkCasesAccountsC { get; set; }
        public virtual DbSet<UkCasesAudit> UkCasesAudit { get; set; }
        public virtual DbSet<UpgradeHistory> UpgradeHistory { get; set; }
        public virtual DbSet<UserPreferences> UserPreferences { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersHolidays> UsersHolidays { get; set; }
        public virtual DbSet<UsersLastImport> UsersLastImport { get; set; }
        public virtual DbSet<UsersPasswordLink> UsersPasswordLink { get; set; }
        public virtual DbSet<UsersSignatures> UsersSignatures { get; set; }
        public virtual DbSet<Vcals> Vcals { get; set; }
        public virtual DbSet<Versions> Versions { get; set; }
        public virtual DbSet<Weblogichooks> Weblogichooks { get; set; }
        public virtual DbSet<Workflow> Workflow { get; set; }
        public virtual DbSet<WorkflowActions> WorkflowActions { get; set; }
        public virtual DbSet<WorkflowActionshells> WorkflowActionshells { get; set; }
        public virtual DbSet<WorkflowAlerts> WorkflowAlerts { get; set; }
        public virtual DbSet<WorkflowAlertshells> WorkflowAlertshells { get; set; }
        public virtual DbSet<WorkflowSchedules> WorkflowSchedules { get; set; }
        public virtual DbSet<WorkflowTriggershells> WorkflowTriggershells { get; set; }
        public virtual DbSet<WWhatsInTheBag> WWhatsInTheBag { get; set; }
        public virtual DbSet<WWhatsInTheBagAudit> WWhatsInTheBagAudit { get; set; }
        public virtual DbSet<WWhatsInTheBagCConsumersC> WWhatsInTheBagCConsumersC { get; set; }
        public virtual DbSet<WWhatsInTheBagCstm> WWhatsInTheBagCstm { get; set; }

        // Unable to generate entity type for table 'taylormadeCRM.custom_fields'. Please see the warning messages.
        // Unable to generate entity type for table 'taylormadeCRM.email_cache'. Please see the warning messages.
        // Unable to generate entity type for table 'taylormadeCRM.users_feeds'. Please see the warning messages.
        // Unable to generate entity type for table 'taylormadeCRM.config'. Please see the warning messages.

        public IQueryable<T> Query<T>(Expression<Func<T, bool>> expression = null) where T : class
        {
            return expression == null ? this.Set<T>() : this.Set<T>().Where(expression);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=tcp:tmcdmdev.database.windows.net,1433;Initial Catalog=SugarData;Persist Security Info=False;User ID=TmagSqlDevuser;Password=Tm@gDev#Pass;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accounts>(entity =>
            {
                entity.ToTable("accounts", "db_taylormade");

                entity.HasIndex(e => e.BillingAddressCity)
                    .HasName("idx_account_billing_address_city");

                entity.HasIndex(e => e.BillingAddressCountry)
                    .HasName("idx_account_billing_address_country");

                entity.HasIndex(e => e.BilltoIdC)
                    .HasName("idx_billto_id_c");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_account_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("accountsmod");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_accnt_parent_id");

                entity.HasIndex(e => e.ShiptoIdC)
                    .HasName("idx_shipto_id_c");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_accounts_tmst_id");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_accounts_assigned_del");

                entity.HasIndex(e => new { e.Deleted, e.AssignedUserId })
                    .HasName("idx_accnt_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_accnt_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_accnt_name_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountType)
                    .HasColumnName("account_type")
                    .HasMaxLength(50);

                entity.Property(e => e.AnnualRevenue)
                    .HasColumnName("annual_revenue")
                    .HasMaxLength(100);

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.BillingAddressCity)
                    .HasColumnName("billing_address_city")
                    .HasMaxLength(100);

                entity.Property(e => e.BillingAddressCountry)
                    .HasColumnName("billing_address_country")
                    .HasMaxLength(255);

                entity.Property(e => e.BillingAddressPostalcode)
                    .HasColumnName("billing_address_postalcode")
                    .HasMaxLength(20);

                entity.Property(e => e.BillingAddressState)
                    .HasColumnName("billing_address_state")
                    .HasMaxLength(100);

                entity.Property(e => e.BillingAddressStreet)
                    .HasColumnName("billing_address_street")
                    .HasMaxLength(150);

                entity.Property(e => e.BilltoIdC)
                    .HasColumnName("billto_id_c")
                    .HasMaxLength(10);

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DunsNum)
                    .HasColumnName("duns_num")
                    .HasMaxLength(15);

                entity.Property(e => e.Employees)
                    .HasColumnName("employees")
                    .HasMaxLength(10);

                entity.Property(e => e.Facebook)
                    .HasColumnName("facebook")
                    .HasMaxLength(100);

                entity.Property(e => e.Googleplus)
                    .HasColumnName("googleplus")
                    .HasMaxLength(100);

                entity.Property(e => e.Industry)
                    .HasColumnName("industry")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(150);

                entity.Property(e => e.Ownership)
                    .HasColumnName("ownership")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.PhoneAlternate)
                    .HasColumnName("phone_alternate")
                    .HasMaxLength(100);

                entity.Property(e => e.PhoneFax)
                    .HasColumnName("phone_fax")
                    .HasMaxLength(100);

                entity.Property(e => e.PhoneOffice)
                    .HasColumnName("phone_office")
                    .HasMaxLength(100);

                entity.Property(e => e.Rating)
                    .HasColumnName("rating")
                    .HasMaxLength(100);

                entity.Property(e => e.ShippingAddressCity)
                    .HasColumnName("shipping_address_city")
                    .HasMaxLength(100);

                entity.Property(e => e.ShippingAddressCountry)
                    .HasColumnName("shipping_address_country")
                    .HasMaxLength(255);

                entity.Property(e => e.ShippingAddressPostalcode)
                    .HasColumnName("shipping_address_postalcode")
                    .HasMaxLength(20);

                entity.Property(e => e.ShippingAddressState)
                    .HasColumnName("shipping_address_state")
                    .HasMaxLength(100);

                entity.Property(e => e.ShippingAddressStreet)
                    .HasColumnName("shipping_address_street")
                    .HasMaxLength(150);

                entity.Property(e => e.ShiptoIdC)
                    .HasColumnName("shipto_id_c")
                    .HasMaxLength(10);

                entity.Property(e => e.SicCode)
                    .HasColumnName("sic_code")
                    .HasMaxLength(10);

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TickerSymbol)
                    .HasColumnName("ticker_symbol")
                    .HasMaxLength(10);

                entity.Property(e => e.Twitter)
                    .HasColumnName("twitter")
                    .HasMaxLength(100);

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AccountsAudit>(entity =>
            {
                entity.ToTable("accounts_audit", "db_taylormade");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_accounts_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.AfterValueText).HasColumnName("after_value_text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.BeforeValueText).HasColumnName("before_value_text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<AccountsBugs>(entity =>
            {
                entity.ToTable("accounts_bugs", "db_taylormade");

                entity.HasIndex(e => e.AccountId)
                    .HasName("idx_acc_bug_acc");

                entity.HasIndex(e => e.BugId)
                    .HasName("idx_acc_bug_bug");

                entity.HasIndex(e => new { e.AccountId, e.BugId })
                    .HasName("idx_account_bug");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.BugId)
                    .HasColumnName("bug_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AccountsCases>(entity =>
            {
                entity.ToTable("accounts_cases", "db_taylormade");

                entity.HasIndex(e => e.AccountId)
                    .HasName("idx_acc_case_acc");

                entity.HasIndex(e => e.CaseId)
                    .HasName("idx_acc_acc_case");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CaseId)
                    .HasColumnName("case_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AccountsContacts>(entity =>
            {
                entity.ToTable("accounts_contacts", "db_taylormade");

                entity.HasIndex(e => new { e.AccountId, e.ContactId })
                    .HasName("idx_account_contact");

                entity.HasIndex(e => new { e.ContactId, e.Deleted, e.AccountId })
                    .HasName("idx_contid_del_accid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrimaryAccount)
                    .HasColumnName("primary_account")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AccountsCrCallRecords1C>(entity =>
            {
                entity.ToTable("accounts_cr_call_records_1_c", "db_taylormade");

                entity.HasIndex(e => e.AccountsCrCallRecords1accountsIda)
                    .HasName("accounts_cr_call_records_1_ida1");

                entity.HasIndex(e => e.AccountsCrCallRecords1crCallRecordsIdb)
                    .HasName("accounts_cr_call_records_1_alt");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(36)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountsCrCallRecords1accountsIda)
                    .HasColumnName("accounts_cr_call_records_1accounts_ida")
                    .HasMaxLength(36);

                entity.Property(e => e.AccountsCrCallRecords1crCallRecordsIdb)
                    .HasColumnName("accounts_cr_call_records_1cr_call_records_idb")
                    .HasMaxLength(36);

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AccountsCstm>(entity =>
            {
                entity.HasKey(e => e.IdC);

                entity.ToTable("accounts_cstm", "db_taylormade");

                entity.Property(e => e.IdC)
                    .HasColumnName("id_c")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountViewC)
                    .HasColumnName("account_view_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'http://accview.cb.tmag.biz/isft/jsp/searchQuery.jsp?DIVISION_CODE=G1&shipto_id={shipto_id_c}')");

                entity.Property(e => e.AcctviewC)
                    .HasColumnName("acctview_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'http://accview.cb.tmag.biz/isft/customer/{id}')");

                entity.Property(e => e.AdamsC)
                    .HasColumnName("adams_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AdidasC)
                    .HasColumnName("adidas_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AshworthC)
                    .HasColumnName("ashworth_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AuthorizedLocationC)
                    .HasColumnName("authorized_location_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CertifiedLocationC)
                    .HasColumnName("certified_location_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ChannelC)
                    .HasColumnName("channel_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ComfilC)
                    .HasColumnName("comfil_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("currency_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DisplaynameC)
                    .HasColumnName("displayname_c")
                    .HasMaxLength(40);

                entity.Property(e => e.FittingLocationC)
                    .HasColumnName("fitting_location_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LeadrankC)
                    .HasColumnName("leadrank_c")
                    .HasMaxLength(10);

                entity.Property(e => e.MattC)
                    .HasColumnName("matt_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxfliC)
                    .HasColumnName("maxfli_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrganizationTypeC)
                    .HasColumnName("organization_type_c")
                    .HasMaxLength(100);

                entity.Property(e => e.OtherC)
                    .HasColumnName("other_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OutsideSalesRepC)
                    .HasColumnName("outside_sales_rep_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PremierLocationC)
                    .HasColumnName("premier_location_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProgramLevelC)
                    .HasColumnName("program_level_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RegionC)
                    .HasColumnName("region_c")
                    .HasMaxLength(100);

                entity.Property(e => e.RetailLocatorC)
                    .HasColumnName("retail_locator_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SelectfitC)
                    .HasColumnName("selectfit_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StoreEmailC)
                    .HasColumnName("store_email_c")
                    .HasMaxLength(255);

                entity.Property(e => e.StoreUrlC)
                    .HasColumnName("store_url_c")
                    .HasMaxLength(255);

                entity.Property(e => e.StorehoursC)
                    .HasColumnName("storehours_c")
                    .HasMaxLength(50);

                entity.Property(e => e.TaylormadeC)
                    .HasColumnName("taylormade_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TextCurrencyC)
                    .HasColumnName("text_currency_c")
                    .HasMaxLength(50);

                entity.Property(e => e.TmStudioC)
                    .HasColumnName("tm_studio_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TmcdwoodsC)
                    .HasColumnName("tmcdwoods_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TmcfironsC)
                    .HasColumnName("tmcfirons_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TmfittingcenterC)
                    .HasColumnName("tmfittingcenter_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TmplC)
                    .HasColumnName("tmpl_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TourprosC)
                    .HasColumnName("tourpros_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UkBlockCode1C)
                    .HasColumnName("uk_block_code1_c")
                    .HasMaxLength(25);

                entity.Property(e => e.UkBlockCode2C)
                    .HasColumnName("uk_block_code2_c")
                    .HasMaxLength(25);

                entity.Property(e => e.UkBlockCode3C)
                    .HasColumnName("uk_block_code3_c")
                    .HasMaxLength(25);

                entity.Property(e => e.UkBuyingGroupC)
                    .HasColumnName("uk_buying_group_c")
                    .HasMaxLength(255);

                entity.Property(e => e.UkDtpC)
                    .HasColumnName("uk_dtp_c")
                    .HasMaxLength(255);

                entity.Property(e => e.UkFreeCode10C)
                    .HasColumnName("uk_free_code10_c")
                    .HasMaxLength(50);

                entity.Property(e => e.UkFreeCode11C)
                    .HasColumnName("uk_free_code11_c")
                    .HasMaxLength(50);

                entity.Property(e => e.UkFreeCode12C)
                    .HasColumnName("uk_free_code12_c")
                    .HasMaxLength(50);

                entity.Property(e => e.UkFreeCode13C)
                    .HasColumnName("uk_free_code13_c")
                    .HasMaxLength(50);

                entity.Property(e => e.UkFreeCode14C)
                    .HasColumnName("uk_free_code14_c")
                    .HasMaxLength(50);

                entity.Property(e => e.UkFreeCode15C)
                    .HasColumnName("uk_free_code15_c")
                    .HasMaxLength(50);

                entity.Property(e => e.UkFreeCode16C)
                    .HasColumnName("uk_free_code16_c")
                    .HasMaxLength(50);

                entity.Property(e => e.UkFreeCode1C)
                    .HasColumnName("uk_free_code1_c")
                    .HasMaxLength(50);

                entity.Property(e => e.UkFreeCode4C)
                    .HasColumnName("uk_free_code4_c")
                    .HasMaxLength(50);

                entity.Property(e => e.UkFreeCode5C)
                    .HasColumnName("uk_free_code5_c")
                    .HasMaxLength(50);

                entity.Property(e => e.UkFreeCode7C)
                    .HasColumnName("uk_free_code7_c")
                    .HasMaxLength(50);

                entity.Property(e => e.UkFreeCode8C)
                    .HasColumnName("uk_free_code8_c")
                    .HasMaxLength(50);

                entity.Property(e => e.UkIncotermsC)
                    .HasColumnName("uk_incoterms_c")
                    .HasMaxLength(50);

                entity.Property(e => e.UkIronBagC)
                    .HasColumnName("uk_iron_bag_c")
                    .HasMaxLength(255);

                entity.Property(e => e.UkLogisticsProfileC)
                    .HasColumnName("uk_logistics_profile_c")
                    .HasMaxLength(255);

                entity.Property(e => e.UkRepCodesC)
                    .HasColumnName("uk_rep_codes_c")
                    .HasMaxLength(255);

                entity.Property(e => e.UkSelectFitC)
                    .HasColumnName("uk_select_fit_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UkSubsidiaryCodeC)
                    .HasColumnName("uk_subsidiary_code_c")
                    .HasMaxLength(255);

                entity.Property(e => e.UkTmagStaffC)
                    .HasColumnName("uk_tmag_staff_c")
                    .HasMaxLength(255);

                entity.Property(e => e.UkTotalSalesC)
                    .HasColumnName("uk_total_sales_c")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.UkVasAccountC)
                    .HasColumnName("uk_vas_account_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserId1C)
                    .HasColumnName("user_id1_c")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.UserId2C)
                    .HasColumnName("user_id2_c")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.UserId3C)
                    .HasColumnName("user_id3_c")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.UserId4C)
                    .HasColumnName("user_id4_c")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.UserIdC)
                    .HasColumnName("user_id_c")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.UserTypeC)
                    .HasColumnName("user_type_c")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AccountsOpportunities>(entity =>
            {
                entity.ToTable("accounts_opportunities", "db_taylormade");

                entity.HasIndex(e => new { e.AccountId, e.OpportunityId })
                    .HasName("idx_account_opportunity");

                entity.HasIndex(e => new { e.OpportunityId, e.Deleted, e.AccountId })
                    .HasName("idx_oppid_del_accid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OpportunityId)
                    .HasColumnName("opportunity_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<AccountsRRetailDemoDays1C>(entity =>
            {
                entity.ToTable("accounts_r_retail_demo_days_1_c", "db_taylormade");

                entity.HasIndex(e => e.AccountsRRetailDemoDays1accountsIda)
                    .HasName("accounts_r_retail_demo_days_1_ida1");

                entity.HasIndex(e => e.AccountsRRetailDemoDays1rRetailDemoDaysIdb)
                    .HasName("accounts_r_retail_demo_days_1_alt");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(36)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountsRRetailDemoDays1accountsIda)
                    .HasColumnName("accounts_r_retail_demo_days_1accounts_ida")
                    .HasMaxLength(36);

                entity.Property(e => e.AccountsRRetailDemoDays1rRetailDemoDaysIdb)
                    .HasColumnName("accounts_r_retail_demo_days_1r_retail_demo_days_idb")
                    .HasMaxLength(36);

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AclActions>(entity =>
            {
                entity.ToTable("acl_actions", "db_taylormade");

                entity.HasIndex(e => new { e.Category, e.Name })
                    .HasName("idx_category_name");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_aclaction_id_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aclaccess).HasColumnName("aclaccess");

                entity.Property(e => e.Acltype)
                    .HasColumnName("acltype")
                    .HasMaxLength(100);

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<AclFields>(entity =>
            {
                entity.ToTable("acl_fields", "db_taylormade");

                entity.HasIndex(e => new { e.RoleId, e.Category, e.Deleted })
                    .HasName("idx_aclfield_role_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aclaccess).HasColumnName("aclaccess");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(150);

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasColumnName("role_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<AclRoles>(entity =>
            {
                entity.ToTable("acl_roles", "db_taylormade");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_aclrole_name");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_aclrole_id_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<AclRolesActions>(entity =>
            {
                entity.ToTable("acl_roles_actions", "db_taylormade");

                entity.HasIndex(e => e.ActionId)
                    .HasName("idx_acl_action_id");

                entity.HasIndex(e => e.RoleId)
                    .HasName("idx_acl_role_id");

                entity.HasIndex(e => new { e.RoleId, e.ActionId })
                    .HasName("idx_aclrole_action");

                entity.HasIndex(e => new { e.RoleId, e.Deleted, e.ActionId, e.AccessOverride })
                    .HasName("idx_del_override");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccessOverride).HasColumnName("access_override");

                entity.Property(e => e.ActionId)
                    .HasColumnName("action_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RoleId)
                    .HasColumnName("role_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<AclRoleSets>(entity =>
            {
                entity.ToTable("acl_role_sets", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_acl_role_sets_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("idx_acl_role_sets_date_modfied");

                entity.HasIndex(e => e.Hash)
                    .HasName("acl_role_sets$idx_acl_role_sets_hash")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_acl_role_sets_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_acl_role_sets_name_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Hash)
                    .HasColumnName("hash")
                    .HasMaxLength(32);

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AclRoleSetsAclRoles>(entity =>
            {
                entity.ToTable("acl_role_sets_acl_roles", "db_taylormade");

                entity.HasIndex(e => e.AclRoleId)
                    .HasName("idx_rsr_role_id");

                entity.HasIndex(e => e.AclRoleSetId)
                    .HasName("idx_rsr_acl_role_set_id");

                entity.HasIndex(e => new { e.AclRoleSetId, e.AclRoleId })
                    .HasName("idx_rsr_set_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AclRoleId)
                    .HasColumnName("acl_role_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.AclRoleSetId)
                    .HasColumnName("acl_role_set_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted).HasColumnName("deleted");
            });

            modelBuilder.Entity<AclRolesUsers>(entity =>
            {
                entity.ToTable("acl_roles_users", "db_taylormade");

                entity.HasIndex(e => e.RoleId)
                    .HasName("idx_aclrole_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("idx_acluser_id");

                entity.HasIndex(e => new { e.RoleId, e.UserId })
                    .HasName("idx_aclrole_user");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RoleId)
                    .HasColumnName("role_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<Activities>(entity =>
            {
                entity.ToTable("activities", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_activities_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("activitiesmod");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_activities_id_del");

                entity.HasIndex(e => new { e.ParentType, e.ParentId })
                    .HasName("activity_records");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityType)
                    .HasColumnName("activity_type")
                    .HasMaxLength(100);

                entity.Property(e => e.CommentCount)
                    .HasColumnName("comment_count")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastComment).HasColumnName("last_comment");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ParentType)
                    .HasColumnName("parent_type")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ActivitiesUsers>(entity =>
            {
                entity.ToTable("activities_users", "db_taylormade");

                entity.HasIndex(e => new { e.ParentType, e.ParentId })
                    .HasName("activities_records");

                entity.HasIndex(e => new { e.ActivityId, e.ParentId, e.ParentType })
                    .HasName("activities_users_parent");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityId)
                    .IsRequired()
                    .HasColumnName("activity_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Fields).HasColumnName("fields");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ParentType)
                    .HasColumnName("parent_type")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<AddressBook>(entity =>
            {
                entity.HasKey(e => new { e.AssignedUserId, e.BeanId });

                entity.ToTable("address_book", "db_taylormade");

                entity.HasIndex(e => new { e.AssignedUserId, e.Bean })
                    .HasName("ab_user_bean_idx");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.BeanId)
                    .HasColumnName("bean_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Bean)
                    .HasColumnName("bean")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AddressBookListItems>(entity =>
            {
                entity.HasKey(e => new { e.ListId, e.BeanId });

                entity.ToTable("address_book_list_items", "db_taylormade");

                entity.HasIndex(e => e.ListId)
                    .HasName("abli_list_id_idx");

                entity.HasIndex(e => new { e.ListId, e.BeanId })
                    .HasName("abli_list_id_bean_idx");

                entity.Property(e => e.ListId)
                    .HasColumnName("list_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.BeanId)
                    .HasColumnName("bean_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<AddressBookLists>(entity =>
            {
                entity.ToTable("address_book_lists", "db_taylormade");

                entity.HasIndex(e => e.AssignedUserId)
                    .HasName("abml_user_bean_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .IsRequired()
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ListName)
                    .HasColumnName("list_name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Bugs>(entity =>
            {
                entity.ToTable("bugs", "db_taylormade");

                entity.HasIndex(e => e.AssignedUserId)
                    .HasName("idx_bugs_assigned_user");

                entity.HasIndex(e => e.BugNumber)
                    .HasName("bugs$bugsnumk")
                    .IsUnique();

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_bugs_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("bugsmod");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_bug_name");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_bugs_tmst_id");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_bugs_assigned_del");

                entity.HasIndex(e => new { e.BugNumber, e.SystemId })
                    .HasName("bugs$bug_number")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_bugs_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_bugs_name_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.BugNumber)
                    .HasColumnName("bug_number")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.FixedInRelease)
                    .HasColumnName("fixed_in_release")
                    .HasMaxLength(255);

                entity.Property(e => e.FoundInRelease)
                    .HasColumnName("found_in_release")
                    .HasMaxLength(255);

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasMaxLength(100);

                entity.Property(e => e.ProductCategory)
                    .HasColumnName("product_category")
                    .HasMaxLength(255);

                entity.Property(e => e.Resolution)
                    .HasColumnName("resolution")
                    .HasMaxLength(255);

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(100);

                entity.Property(e => e.SystemId).HasColumnName("system_id");

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255);

                entity.Property(e => e.WorkLog).HasColumnName("work_log");
            });

            modelBuilder.Entity<BugsAudit>(entity =>
            {
                entity.ToTable("bugs_audit", "db_taylormade");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_bugs_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.AfterValueText).HasColumnName("after_value_text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.BeforeValueText).HasColumnName("before_value_text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<Calls>(entity =>
            {
                entity.ToTable("calls", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_call_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("callsmod");

                entity.HasIndex(e => e.DateStart)
                    .HasName("idx_calls_date_start");

                entity.HasIndex(e => e.Direction)
                    .HasName("idx_call_direction");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_call_name");

                entity.HasIndex(e => e.RecurrenceId)
                    .HasName("idx_calls_recurrence_id");

                entity.HasIndex(e => e.Status)
                    .HasName("idx_status");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_calls_tmst_id");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_calls_assigned_del");

                entity.HasIndex(e => new { e.DateStart, e.ReminderTime })
                    .HasName("idx_calls_date_start_reminder");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_calls_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_calls_name_del");

                entity.HasIndex(e => new { e.RepeatParentId, e.Deleted })
                    .HasName("idx_calls_repeat_parent_id");

                entity.HasIndex(e => new { e.DateStart, e.DateEnd, e.Deleted })
                    .HasName("idx_calls_date_start_end_del");

                entity.HasIndex(e => new { e.ParentId, e.ParentType, e.Deleted })
                    .HasName("idx_calls_par_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEnd)
                    .HasColumnName("date_end")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateStart)
                    .HasColumnName("date_start")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Direction)
                    .HasColumnName("direction")
                    .HasMaxLength(100);

                entity.Property(e => e.DurationHours)
                    .HasColumnName("duration_hours")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DurationMinutes).HasColumnName("duration_minutes");

                entity.Property(e => e.EmailReminderSent)
                    .HasColumnName("email_reminder_sent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailReminderTime)
                    .HasColumnName("email_reminder_time")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.OutlookId)
                    .HasColumnName("outlook_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ParentType)
                    .HasColumnName("parent_type")
                    .HasMaxLength(255);

                entity.Property(e => e.RecurrenceId)
                    .HasColumnName("recurrence_id")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.RecurringSource)
                    .HasColumnName("recurring_source")
                    .HasMaxLength(36);

                entity.Property(e => e.ReminderTime)
                    .HasColumnName("reminder_time")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.RepeatCount).HasColumnName("repeat_count");

                entity.Property(e => e.RepeatDays)
                    .HasColumnName("repeat_days")
                    .HasMaxLength(128);

                entity.Property(e => e.RepeatDow)
                    .HasColumnName("repeat_dow")
                    .HasMaxLength(7);

                entity.Property(e => e.RepeatInterval)
                    .HasColumnName("repeat_interval")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RepeatOrdinal)
                    .HasColumnName("repeat_ordinal")
                    .HasMaxLength(36);

                entity.Property(e => e.RepeatParentId)
                    .HasColumnName("repeat_parent_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.RepeatSelector)
                    .HasColumnName("repeat_selector")
                    .HasMaxLength(36);

                entity.Property(e => e.RepeatType)
                    .HasColumnName("repeat_type")
                    .HasMaxLength(36);

                entity.Property(e => e.RepeatUnit)
                    .HasColumnName("repeat_unit")
                    .HasMaxLength(36);

                entity.Property(e => e.RepeatUntil)
                    .HasColumnName("repeat_until")
                    .HasColumnType("date");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Planned')");

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<CallsContacts>(entity =>
            {
                entity.ToTable("calls_contacts", "db_taylormade");

                entity.HasIndex(e => e.CallId)
                    .HasName("idx_con_call_call");

                entity.HasIndex(e => e.ContactId)
                    .HasName("idx_con_call_con");

                entity.HasIndex(e => new { e.CallId, e.ContactId })
                    .HasName("idx_call_contact");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcceptStatus)
                    .HasColumnName("accept_status")
                    .HasMaxLength(25)
                    .HasDefaultValueSql("(N'none')");

                entity.Property(e => e.CallId)
                    .HasColumnName("call_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Required)
                    .HasColumnName("required")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'1')");
            });

            modelBuilder.Entity<CallsCstm>(entity =>
            {
                entity.HasKey(e => e.IdC);

                entity.ToTable("calls_cstm", "db_taylormade");

                entity.Property(e => e.IdC)
                    .HasColumnName("id_c")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShiptoIdC)
                    .HasColumnName("shipto_id_c")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<CallsLeads>(entity =>
            {
                entity.ToTable("calls_leads", "db_taylormade");

                entity.HasIndex(e => e.CallId)
                    .HasName("idx_lead_call_call");

                entity.HasIndex(e => e.LeadId)
                    .HasName("idx_lead_call_lead");

                entity.HasIndex(e => new { e.CallId, e.LeadId })
                    .HasName("idx_call_lead");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcceptStatus)
                    .HasColumnName("accept_status")
                    .HasMaxLength(25)
                    .HasDefaultValueSql("(N'none')");

                entity.Property(e => e.CallId)
                    .HasColumnName("call_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LeadId)
                    .HasColumnName("lead_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Required)
                    .HasColumnName("required")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'1')");
            });

            modelBuilder.Entity<CallsUsers>(entity =>
            {
                entity.ToTable("calls_users", "db_taylormade");

                entity.HasIndex(e => e.CallId)
                    .HasName("idx_usr_call_call");

                entity.HasIndex(e => e.UserId)
                    .HasName("idx_usr_call_usr");

                entity.HasIndex(e => new { e.CallId, e.UserId })
                    .HasName("idx_call_users");

                entity.HasIndex(e => new { e.CallId, e.UserId, e.Deleted })
                    .HasName("idx_call_users_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcceptStatus)
                    .HasColumnName("accept_status")
                    .HasMaxLength(25)
                    .HasDefaultValueSql("(N'none')");

                entity.Property(e => e.CallId)
                    .HasColumnName("call_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Required)
                    .HasColumnName("required")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'1')");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<CampaignLog>(entity =>
            {
                entity.ToTable("campaign_log", "db_taylormade");

                entity.HasIndex(e => e.CampaignId)
                    .HasName("idx_camp_campaign_id");

                entity.HasIndex(e => e.MoreInformation)
                    .HasName("idx_camp_more_info");

                entity.HasIndex(e => e.TargetId)
                    .HasName("idx_target_id");

                entity.HasIndex(e => e.TargetTrackerKey)
                    .HasName("idx_camp_tracker");

                entity.HasIndex(e => new { e.TargetId, e.Deleted })
                    .HasName("idx_target_id_deleted");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityDate)
                    .HasColumnName("activity_date")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.ActivityType)
                    .HasColumnName("activity_type")
                    .HasMaxLength(100);

                entity.Property(e => e.Archived)
                    .HasColumnName("archived")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Hits)
                    .HasColumnName("hits")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ListId)
                    .HasColumnName("list_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.MarketingId)
                    .HasColumnName("marketing_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.MoreInformation)
                    .HasColumnName("more_information")
                    .HasMaxLength(100);

                entity.Property(e => e.RelatedId)
                    .HasColumnName("related_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.RelatedType)
                    .HasColumnName("related_type")
                    .HasMaxLength(100);

                entity.Property(e => e.TargetId)
                    .HasColumnName("target_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TargetTrackerKey)
                    .HasColumnName("target_tracker_key")
                    .HasMaxLength(36);

                entity.Property(e => e.TargetType)
                    .HasColumnName("target_type")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Campaigns>(entity =>
            {
                entity.ToTable("campaigns", "db_taylormade");

                entity.HasIndex(e => e.CampaignType)
                    .HasName("idx_campaign_campaign_type");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_campaign_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("campaignsmod");

                entity.HasIndex(e => e.EndDate)
                    .HasName("idx_campaign_end_date");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_campaign_name");

                entity.HasIndex(e => e.Status)
                    .HasName("idx_campaign_status");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_campaigns_tmst_id");

                entity.HasIndex(e => e.TrackerKey)
                    .HasName("camp_auto_tracker_key");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_campaigns_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_campaigns_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_campaigns_name_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActualCost)
                    .HasColumnName("actual_cost")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.BaseRate)
                    .HasColumnName("base_rate")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.Budget)
                    .HasColumnName("budget")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.CampaignType)
                    .HasColumnName("campaign_type")
                    .HasMaxLength(100);

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("currency_id")
                    .HasColumnType("nchar(36)")
                    .HasDefaultValueSql("(N'-99')");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("date");

                entity.Property(e => e.ExpectedCost)
                    .HasColumnName("expected_cost")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.ExpectedRevenue)
                    .HasColumnName("expected_revenue")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.Frequency)
                    .HasColumnName("frequency")
                    .HasMaxLength(100);

                entity.Property(e => e.Impressions)
                    .HasColumnName("impressions")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Objective).HasColumnName("objective");

                entity.Property(e => e.ReferUrl)
                    .HasColumnName("refer_url")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'http://')");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("date");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(100);

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TrackerCount)
                    .HasColumnName("tracker_count")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TrackerKey)
                    .HasColumnName("tracker_key")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TrackerText)
                    .HasColumnName("tracker_text")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<CampaignsAudit>(entity =>
            {
                entity.ToTable("campaigns_audit", "db_taylormade");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_campaigns_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.AfterValueText).HasColumnName("after_value_text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.BeforeValueText).HasColumnName("before_value_text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<CampaignTrkrs>(entity =>
            {
                entity.ToTable("campaign_trkrs", "db_taylormade");

                entity.HasIndex(e => e.TrackerKey)
                    .HasName("campaign_tracker_key_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsOptout)
                    .HasColumnName("is_optout")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TrackerKey)
                    .HasColumnName("tracker_key")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TrackerName)
                    .HasColumnName("tracker_name")
                    .HasMaxLength(30);

                entity.Property(e => e.TrackerUrl)
                    .HasColumnName("tracker_url")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'http://')");
            });

            modelBuilder.Entity<Cases>(entity =>
            {
                entity.ToTable("cases", "db_taylormade");

                entity.HasIndex(e => e.AccountId)
                    .HasName("idx_account_id");

                entity.HasIndex(e => e.CaseNumber)
                    .HasName("cases$casesnumk")
                    .IsUnique();

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_case_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("casesmod");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_case_name");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_cases_tmst_id");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_cases_assigned_del");

                entity.HasIndex(e => new { e.CaseNumber, e.SystemId })
                    .HasName("cases$case_number")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_cases_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_cases_name_del");

                entity.HasIndex(e => new { e.AssignedUserId, e.Status, e.Deleted })
                    .HasName("idx_cases_stat_del");

                entity.HasIndex(e => new { e.TeamSetId, e.Deleted, e.Status })
                    .HasName("idx_tmst_del_status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CaseNumber)
                    .HasColumnName("case_number")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasMaxLength(100);

                entity.Property(e => e.Resolution).HasColumnName("resolution");

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(100);

                entity.Property(e => e.SystemId).HasColumnName("system_id");

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255);

                entity.Property(e => e.WorkLog).HasColumnName("work_log");
            });

            modelBuilder.Entity<CasesAudit>(entity =>
            {
                entity.ToTable("cases_audit", "db_taylormade");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_cases_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.AfterValueText).HasColumnName("after_value_text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.BeforeValueText).HasColumnName("before_value_text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<CasesBugs>(entity =>
            {
                entity.ToTable("cases_bugs", "db_taylormade");

                entity.HasIndex(e => e.BugId)
                    .HasName("idx_cas_bug_bug");

                entity.HasIndex(e => e.CaseId)
                    .HasName("idx_cas_bug_cas");

                entity.HasIndex(e => new { e.CaseId, e.BugId })
                    .HasName("idx_case_bug");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.BugId)
                    .HasColumnName("bug_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CaseId)
                    .HasColumnName("case_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CasesCstm>(entity =>
            {
                entity.HasKey(e => e.IdC);

                entity.ToTable("cases_cstm", "db_taylormade");

                entity.HasIndex(e => e.SiteC)
                    .HasName("idx_site_c");

                entity.HasIndex(e => new { e.CustomerTypeC, e.SourceC, e.SiteC })
                    .HasName("idx_type_source_site_c");

                entity.Property(e => e.IdC)
                    .HasColumnName("id_c")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivationC)
                    .HasColumnName("activation_c")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CampaignC)
                    .HasColumnName("campaign_c")
                    .HasMaxLength(100);

                entity.Property(e => e.CaseAgeC).HasColumnName("case_age_c");

                entity.Property(e => e.CaseTypeC)
                    .HasColumnName("case_type_c")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ComfilOrderNumberC)
                    .HasColumnName("comfil_order_number_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ConsumerEmailC)
                    .HasColumnName("consumer_email_c")
                    .HasMaxLength(255);

                entity.Property(e => e.ConsumerFirstNameC)
                    .HasColumnName("consumer_first_name_c")
                    .HasMaxLength(255);

                entity.Property(e => e.ConsumerLastNameC)
                    .HasColumnName("consumer_last_name_c")
                    .HasMaxLength(255);

                entity.Property(e => e.ConsumerPhoneC)
                    .HasColumnName("consumer_phone_c")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactCountryC)
                    .HasColumnName("contact_country_c")
                    .HasMaxLength(100);

                entity.Property(e => e.ContactEmailC)
                    .HasColumnName("contact_email_c")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactFirstNameC)
                    .HasColumnName("contact_first_name_c")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactLastNameC)
                    .HasColumnName("contact_last_name_c")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactMobileC)
                    .HasColumnName("contact_mobile_c")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactPhoneC)
                    .HasColumnName("contact_phone_c")
                    .HasMaxLength(255);

                entity.Property(e => e.CourseAddressC)
                    .HasColumnName("course_address_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CourseCityC)
                    .HasColumnName("course_city_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CourseCountryC)
                    .HasColumnName("course_country_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CourseNameC)
                    .HasColumnName("course_name_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CoursePhoneC)
                    .HasColumnName("course_phone_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CourseStateC)
                    .HasColumnName("course_state_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CourseTeenameC)
                    .HasColumnName("course_teename_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CourseTeeparC)
                    .HasColumnName("course_teepar_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CourseTypeC)
                    .HasColumnName("course_type_c")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CourseZipcodeC)
                    .HasColumnName("course_zipcode_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("currency_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CustomerTypeC)
                    .HasColumnName("customer_type_c")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Account')");

                entity.Property(e => e.DateClosedC)
                    .HasColumnName("date_closed_c")
                    .HasColumnType("date");

                entity.Property(e => e.DeliveryNumberC)
                    .HasColumnName("delivery_number_c")
                    .HasMaxLength(255);

                entity.Property(e => e.EcommerceOrderNumberC)
                    .HasColumnName("ecommerce_order_number_c")
                    .HasMaxLength(255);

                entity.Property(e => e.ExistingContactsListC)
                    .HasColumnName("existing_contacts_list_c")
                    .HasMaxLength(100);

                entity.Property(e => e.FedexTrackingUrlC)
                    .HasColumnName("fedex_tracking_url_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'http://www.fedex.com/Tracking?cntry_code=us&tracknumber_list={delivery_number_c}&language=english')");

                entity.Property(e => e.FrequencyC)
                    .HasColumnName("frequency_c")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.HandicaprangeC)
                    .HasColumnName("handicaprange_c")
                    .HasMaxLength(100);

                entity.Property(e => e.InternalNotesC).HasColumnName("internal_notes_c");

                entity.Property(e => e.IssueTypeC)
                    .HasColumnName("issue_type_c")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.OtherDescriptionC)
                    .HasColumnName("other_description_c")
                    .HasMaxLength(255);

                entity.Property(e => e.ProductCategoryC)
                    .HasColumnName("product_category_c")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ProductModelC)
                    .HasColumnName("product_model_c")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PurchaseDateC)
                    .HasColumnName("purchase_date_c")
                    .HasMaxLength(255);

                entity.Property(e => e.PurchaseLocationC)
                    .HasColumnName("purchase_location_c")
                    .HasMaxLength(255);

                entity.Property(e => e.PurchasePriceC)
                    .HasColumnName("purchase_price_c")
                    .HasMaxLength(255);

                entity.Property(e => e.ReplaceErpOrderNoC)
                    .HasColumnName("replace_erp_order_no_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RoundCompleteC)
                    .HasColumnName("round_complete_c")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RoundDateC)
                    .HasColumnName("round_date_c")
                    .HasColumnType("date");

                entity.Property(e => e.SendSurveyC).HasColumnName("send_survey_c");

                entity.Property(e => e.SerialNumberC)
                    .HasColumnName("serial_number_c")
                    .HasMaxLength(255);

                entity.Property(e => e.ShiptoIdC)
                    .HasColumnName("shipto_id_c")
                    .HasMaxLength(25);

                entity.Property(e => e.SiteC)
                    .HasColumnName("site_c")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SldrBoughtC)
                    .HasColumnName("sldr_bought_c")
                    .HasMaxLength(100);

                entity.Property(e => e.SldrFittedC)
                    .HasColumnName("sldr_fitted_c")
                    .HasMaxLength(100);

                entity.Property(e => e.SourceC)
                    .HasColumnName("source_c")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Phone')");

                entity.Property(e => e.StaffC)
                    .HasColumnName("staff_c")
                    .HasMaxLength(100);

                entity.Property(e => e.SubTypeC)
                    .HasColumnName("sub_type_c")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SyncRoundC)
                    .HasColumnName("sync_round_c")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TotalCycleTimeC).HasColumnName("total_cycle_time_c");

                entity.Property(e => e.TranferSourceC)
                    .HasColumnName("tranfer_source_c")
                    .HasMaxLength(100);

                entity.Property(e => e.TriggerReadonlyC)
                    .HasColumnName("trigger_readonly_c")
                    .HasMaxLength(100);

                entity.Property(e => e.WebFormAccountC)
                    .HasColumnName("web_form_account_c")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<CasesPProductRegistrations1C>(entity =>
            {
                entity.ToTable("cases_p_product_registrations_1_c", "db_taylormade");

                entity.HasIndex(e => e.CasesPProductRegistrations1casesIda)
                    .HasName("cases_p_product_registrations_1_ida1");

                entity.HasIndex(e => e.CasesPProductRegistrations1pProductRegistrationsIdb)
                    .HasName("cases_p_product_registrations_1_idb2");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(36)
                    .ValueGeneratedNever();

                entity.Property(e => e.CasesPProductRegistrations1casesIda)
                    .HasColumnName("cases_p_product_registrations_1cases_ida")
                    .HasMaxLength(36);

                entity.Property(e => e.CasesPProductRegistrations1pProductRegistrationsIdb)
                    .HasColumnName("cases_p_product_registrations_1p_product_registrations_idb")
                    .HasMaxLength(36);

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.ToTable("categories", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_categories_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("idx_categories_date_modfied");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_categories_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_categories_name_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.IsExternal)
                    .HasColumnName("is_external")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Lft).HasColumnName("lft");

                entity.Property(e => e.Lvl).HasColumnName("lvl");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Rgt).HasColumnName("rgt");

                entity.Property(e => e.Root)
                    .HasColumnName("root")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.SourceId)
                    .HasColumnName("source_id")
                    .HasMaxLength(255);

                entity.Property(e => e.SourceMeta).HasColumnName("source_meta");

                entity.Property(e => e.SourceType)
                    .HasColumnName("source_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<CategoryTree>(entity =>
            {
                entity.HasKey(e => e.NodeId);

                entity.ToTable("category_tree", "db_taylormade");

                entity.HasIndex(e => e.SelfId)
                    .HasName("idx_categorytree");

                entity.Property(e => e.NodeId).HasColumnName("node_id");

                entity.Property(e => e.ParentNodeId)
                    .HasColumnName("parent_node_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SelfId)
                    .HasColumnName("self_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(36);
            });

            modelBuilder.Entity<CConsumerCampaigns>(entity =>
            {
                entity.ToTable("c_consumer_campaigns", "db_taylormade");

                entity.HasIndex(e => e.CampaignType)
                    .HasName("idx_campaign_type");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("c_consumer_campaignsmod");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_c_consumer_campaigns_tmst_id");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_c_consumer_campaigns_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_c_consumer_campaigns_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_c_consumer_campaigns_name_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CampaignType)
                    .HasColumnName("campaign_type")
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.InitialTransaction)
                    .HasColumnName("initial_transaction")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<CConsumerCampaignsAudit>(entity =>
            {
                entity.ToTable("c_consumer_campaigns_audit", "db_taylormade");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_c_consumer_campaigns_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.AfterValueText).HasColumnName("after_value_text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.BeforeValueText).HasColumnName("before_value_text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<CConsumerCampaignsCConsumersC>(entity =>
            {
                entity.ToTable("c_consumer_campaigns_c_consumers_c", "db_taylormade");

                entity.HasIndex(e => e.CConsumerCampaignsCConsumerscConsumerCampaignsIdb)
                    .HasName("c_consumer_campaigns_c_consumers_alt");

                entity.HasIndex(e => e.CConsumerCampaignsCConsumerscConsumersIda)
                    .HasName("c_consumer_campaigns_c_consumers_ida1");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(36)
                    .ValueGeneratedNever();

                entity.Property(e => e.CConsumerCampaignsCConsumerscConsumerCampaignsIdb)
                    .HasColumnName("c_consumer_campaigns_c_consumersc_consumer_campaigns_idb")
                    .HasMaxLength(36);

                entity.Property(e => e.CConsumerCampaignsCConsumerscConsumersIda)
                    .HasColumnName("c_consumer_campaigns_c_consumersc_consumers_ida")
                    .HasMaxLength(36);

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CConsumerCampaignsCstm>(entity =>
            {
                entity.HasKey(e => e.IdC);

                entity.ToTable("c_consumer_campaigns_cstm", "db_taylormade");

                entity.Property(e => e.IdC)
                    .HasColumnName("id_c")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmailC)
                    .HasColumnName("email_c")
                    .HasMaxLength(255);

                entity.Property(e => e.FootwearC)
                    .HasColumnName("footwear_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OuterwearC)
                    .HasColumnName("outerwear_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PantsC)
                    .HasColumnName("pants_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PlayerIdC)
                    .HasColumnName("player_id_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PolosC)
                    .HasColumnName("polos_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TravelgearC)
                    .HasColumnName("travelgear_c")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CConsumers>(entity =>
            {
                entity.ToTable("c_consumers", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("c_consumersmod");

                entity.HasIndex(e => e.Deleted)
                    .HasName("idx_deleted");

                entity.HasIndex(e => e.Euci)
                    .HasName("idx_euci");

                entity.HasIndex(e => e.Phonehm)
                    .HasName("idx_phonehm");

                entity.HasIndex(e => e.Phonemb)
                    .HasName("idx_phonemb");

                entity.HasIndex(e => e.ResponsysDate)
                    .HasName("idx_responsys_date");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_c_consumers_tmst_id");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_c_consumers_assigned_del");

                entity.HasIndex(e => new { e.Email, e.Deleted })
                    .HasName("idx_email_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_c_consumers_name_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Adams)
                    .HasColumnName("adams")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddressCity)
                    .HasColumnName("address_city")
                    .HasMaxLength(100);

                entity.Property(e => e.AddressCountry)
                    .HasColumnName("address_country")
                    .HasMaxLength(100);

                entity.Property(e => e.AddressPostalcode)
                    .HasColumnName("address_postalcode")
                    .HasMaxLength(20);

                entity.Property(e => e.AddressState)
                    .HasColumnName("address_state")
                    .HasMaxLength(100);

                entity.Property(e => e.AddressStreet)
                    .HasColumnName("address_street")
                    .HasMaxLength(100);

                entity.Property(e => e.Adidas)
                    .HasColumnName("adidas")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ashworth)
                    .HasColumnName("ashworth")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Dexterity)
                    .HasColumnName("dexterity")
                    .HasMaxLength(100);

                entity.Property(e => e.Dob)
                    .HasColumnName("dob")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100);

                entity.Property(e => e.Euci)
                    .HasColumnName("euci")
                    .HasMaxLength(100);

                entity.Property(e => e.ExternalMarketingSegment)
                    .HasColumnName("external_marketing_segment")
                    .HasMaxLength(100);

                entity.Property(e => e.Facebookid)
                    .HasColumnName("facebookid")
                    .HasMaxLength(100);

                entity.Property(e => e.Fname)
                    .HasColumnName("fname")
                    .HasMaxLength(100);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(100);

                entity.Property(e => e.HandicapRange)
                    .HasColumnName("handicap_range")
                    .HasMaxLength(100);

                entity.Property(e => e.Height)
                    .HasColumnName("height")
                    .HasMaxLength(100);

                entity.Property(e => e.Instagramid)
                    .HasColumnName("instagramid")
                    .HasMaxLength(100);

                entity.Property(e => e.InternalMarketingSegment)
                    .HasColumnName("internal_marketing_segment")
                    .HasMaxLength(100);

                entity.Property(e => e.Linkedinid)
                    .HasColumnName("linkedinid")
                    .HasMaxLength(100);

                entity.Property(e => e.Lname)
                    .HasColumnName("lname")
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Optout)
                    .HasColumnName("optout")
                    .HasMaxLength(100);

                entity.Property(e => e.Outlet)
                    .HasColumnName("outlet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Phonehm)
                    .HasColumnName("phonehm")
                    .HasMaxLength(25);

                entity.Property(e => e.Phonemb)
                    .HasColumnName("phonemb")
                    .HasMaxLength(25);

                entity.Property(e => e.Responsys)
                    .HasColumnName("responsys")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ResponsysDate)
                    .HasColumnName("responsys_date")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.ResponsysId)
                    .HasColumnName("responsys_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rpm)
                    .HasColumnName("rpm")
                    .HasMaxLength(100);

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Tmag)
                    .HasColumnName("tmag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Twitterhandle)
                    .HasColumnName("twitterhandle")
                    .HasMaxLength(100);

                entity.Property(e => e.Whereplay)
                    .HasColumnName("whereplay")
                    .HasMaxLength(100);

                entity.Property(e => e.Yearsplay)
                    .HasColumnName("yearsplay")
                    .HasMaxLength(2);
            });

            modelBuilder.Entity<CConsumersAudit>(entity =>
            {
                entity.ToTable("c_consumers_audit", "db_taylormade");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_c_consumers_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.AfterValueText).HasColumnName("after_value_text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.BeforeValueText).HasColumnName("before_value_text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<CConsumersCases1C>(entity =>
            {
                entity.ToTable("c_consumers_cases_1_c", "db_taylormade");

                entity.HasIndex(e => e.CConsumersCases1cConsumersIda)
                    .HasName("c_consumers_cases_1_ida1");

                entity.HasIndex(e => e.CConsumersCases1casesIdb)
                    .HasName("c_consumers_cases_1_alt");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(36)
                    .ValueGeneratedNever();

                entity.Property(e => e.CConsumersCases1cConsumersIda)
                    .HasColumnName("c_consumers_cases_1c_consumers_ida")
                    .HasMaxLength(36);

                entity.Property(e => e.CConsumersCases1casesIdb)
                    .HasColumnName("c_consumers_cases_1cases_idb")
                    .HasMaxLength(36);

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CConsumersCrCallRecords1C>(entity =>
            {
                entity.ToTable("c_consumers_cr_call_records_1_c", "db_taylormade");

                entity.HasIndex(e => e.CConsumersCrCallRecords1cConsumersIda)
                    .HasName("c_consumers_cr_call_records_1_ida1");

                entity.HasIndex(e => e.CConsumersCrCallRecords1crCallRecordsIdb)
                    .HasName("c_consumers_cr_call_records_1_alt");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(36)
                    .ValueGeneratedNever();

                entity.Property(e => e.CConsumersCrCallRecords1cConsumersIda)
                    .HasColumnName("c_consumers_cr_call_records_1c_consumers_ida")
                    .HasMaxLength(36);

                entity.Property(e => e.CConsumersCrCallRecords1crCallRecordsIdb)
                    .HasColumnName("c_consumers_cr_call_records_1cr_call_records_idb")
                    .HasMaxLength(36);

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CConsumersCstm>(entity =>
            {
                entity.HasKey(e => e.IdC);

                entity.ToTable("c_consumers_cstm", "db_taylormade");

                entity.Property(e => e.IdC)
                    .HasColumnName("id_c")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressStreet2C)
                    .HasColumnName("address_street2_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CurrentDriverBallFlightC)
                    .HasColumnName("current_driver_ball_flight_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CurrentIronBallFlightC)
                    .HasColumnName("current_iron_ball_flight_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DesiredDriverBallFlightC)
                    .HasColumnName("desired_driver_ball_flight_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DesiredDriverShaftFlexC)
                    .HasColumnName("desired_driver_shaft_flex_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DesiredIronBallFlightC)
                    .HasColumnName("desired_iron_ball_flight_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DriverLoftC)
                    .HasColumnName("driver_loft_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DriverShaftFlexC)
                    .HasColumnName("driver_shaft_flex_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FootwearOptinC)
                    .HasColumnName("footwear_optin_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HandicapC)
                    .HasColumnName("handicap_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.HomeCourseC)
                    .HasColumnName("home_course_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IronLengthC)
                    .HasColumnName("iron_length_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IronLieC)
                    .HasColumnName("iron_lie_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IronShaftFlexC)
                    .HasColumnName("iron_shaft_flex_c")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.MediaPreferenceC)
                    .HasColumnName("media_preference_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MensOptinC)
                    .HasColumnName("mens_optin_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductInterestC)
                    .HasColumnName("product_interest_c")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PromotionsOptinC)
                    .HasColumnName("promotions_optin_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ResponsysInstanceC)
                    .HasColumnName("responsys_instance_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TypicalDriverDistanceC)
                    .HasColumnName("typical_driver_distance_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TypicalIronDistanceC)
                    .HasColumnName("typical_iron_distance_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.VipC)
                    .HasColumnName("vip_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WomensOptinC)
                    .HasColumnName("womens_optin_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.YouthOptinC)
                    .HasColumnName("youth_optin_c")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Comments>(entity =>
            {
                entity.ToTable("comments", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_comments_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("commentsmod");

                entity.HasIndex(e => e.ParentId)
                    .HasName("comment_activities");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_comments_id_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<Contacts>(entity =>
            {
                entity.ToTable("contacts", "db_taylormade");

                entity.HasIndex(e => e.AssignedUserId)
                    .HasName("idx_cont_assigned");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_contact_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("contactsmod");

                entity.HasIndex(e => e.MktoId)
                    .HasName("idx_contact_mkto_id");

                entity.HasIndex(e => e.ReportsToId)
                    .HasName("idx_reports_to_id");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_contacts_tmst_id");

                entity.HasIndex(e => e.Title)
                    .HasName("idx_contact_title");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_contacts_assigned_del");

                entity.HasIndex(e => new { e.Deleted, e.LastName })
                    .HasName("idx_contacts_del_last");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_contacts_id_del");

                entity.HasIndex(e => new { e.Deleted, e.Id, e.AssignedUserId })
                    .HasName("idx_del_id_user");

                entity.HasIndex(e => new { e.Deleted, e.ReportsToId, e.LastName })
                    .HasName("idx_cont_del_reports");

                entity.HasIndex(e => new { e.FirstName, e.LastName, e.Deleted })
                    .HasName("idx_contacts_first_last");

                entity.HasIndex(e => new { e.LastName, e.FirstName, e.Deleted })
                    .HasName("idx_cont_last_first");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AltAddressCity)
                    .HasColumnName("alt_address_city")
                    .HasMaxLength(100);

                entity.Property(e => e.AltAddressCountry)
                    .HasColumnName("alt_address_country")
                    .HasMaxLength(255);

                entity.Property(e => e.AltAddressPostalcode)
                    .HasColumnName("alt_address_postalcode")
                    .HasMaxLength(20);

                entity.Property(e => e.AltAddressState)
                    .HasColumnName("alt_address_state")
                    .HasMaxLength(100);

                entity.Property(e => e.AltAddressStreet)
                    .HasColumnName("alt_address_street")
                    .HasMaxLength(150);

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Assistant)
                    .HasColumnName("assistant")
                    .HasMaxLength(75);

                entity.Property(e => e.AssistantPhone)
                    .HasColumnName("assistant_phone")
                    .HasMaxLength(100);

                entity.Property(e => e.Birthdate)
                    .HasColumnName("birthdate")
                    .HasColumnType("date");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Department)
                    .HasColumnName("department")
                    .HasMaxLength(255);

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DnbPrincipalId)
                    .HasColumnName("dnb_principal_id")
                    .HasMaxLength(30);

                entity.Property(e => e.DoNotCall)
                    .HasColumnName("do_not_call")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Facebook)
                    .HasColumnName("facebook")
                    .HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(100);

                entity.Property(e => e.Googleplus)
                    .HasColumnName("googleplus")
                    .HasMaxLength(100);

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(100);

                entity.Property(e => e.LeadSource)
                    .HasColumnName("lead_source")
                    .HasMaxLength(255);

                entity.Property(e => e.MktoId).HasColumnName("mkto_id");

                entity.Property(e => e.MktoLeadScore).HasColumnName("mkto_lead_score");

                entity.Property(e => e.MktoSync)
                    .HasColumnName("mkto_sync")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.PhoneFax)
                    .HasColumnName("phone_fax")
                    .HasMaxLength(100);

                entity.Property(e => e.PhoneHome)
                    .HasColumnName("phone_home")
                    .HasMaxLength(100);

                entity.Property(e => e.PhoneMobile)
                    .HasColumnName("phone_mobile")
                    .HasMaxLength(100);

                entity.Property(e => e.PhoneOther)
                    .HasColumnName("phone_other")
                    .HasMaxLength(100);

                entity.Property(e => e.PhoneWork)
                    .HasColumnName("phone_work")
                    .HasMaxLength(100);

                entity.Property(e => e.Picture)
                    .HasColumnName("picture")
                    .HasMaxLength(255);

                entity.Property(e => e.PrimaryAddressCity)
                    .HasColumnName("primary_address_city")
                    .HasMaxLength(100);

                entity.Property(e => e.PrimaryAddressCountry)
                    .HasColumnName("primary_address_country")
                    .HasMaxLength(255);

                entity.Property(e => e.PrimaryAddressPostalcode)
                    .HasColumnName("primary_address_postalcode")
                    .HasMaxLength(20);

                entity.Property(e => e.PrimaryAddressState)
                    .HasColumnName("primary_address_state")
                    .HasMaxLength(100);

                entity.Property(e => e.PrimaryAddressStreet)
                    .HasColumnName("primary_address_street")
                    .HasMaxLength(150);

                entity.Property(e => e.ReportsToId)
                    .HasColumnName("reports_to_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Salutation)
                    .HasColumnName("salutation")
                    .HasMaxLength(255);

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100);

                entity.Property(e => e.Twitter)
                    .HasColumnName("twitter")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ContactsAudit>(entity =>
            {
                entity.ToTable("contacts_audit", "db_taylormade");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_contacts_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.AfterValueText).HasColumnName("after_value_text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.BeforeValueText).HasColumnName("before_value_text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<ContactsBugs>(entity =>
            {
                entity.ToTable("contacts_bugs", "db_taylormade");

                entity.HasIndex(e => e.BugId)
                    .HasName("idx_con_bug_bug");

                entity.HasIndex(e => e.ContactId)
                    .HasName("idx_con_bug_con");

                entity.HasIndex(e => new { e.ContactId, e.BugId })
                    .HasName("idx_contact_bug");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.BugId)
                    .HasColumnName("bug_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ContactRole)
                    .HasColumnName("contact_role")
                    .HasMaxLength(50);

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ContactsCases>(entity =>
            {
                entity.ToTable("contacts_cases", "db_taylormade");

                entity.HasIndex(e => e.CaseId)
                    .HasName("idx_con_case_case");

                entity.HasIndex(e => e.ContactId)
                    .HasName("idx_con_case_con");

                entity.HasIndex(e => new { e.ContactId, e.CaseId })
                    .HasName("idx_contacts_cases");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CaseId)
                    .HasColumnName("case_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ContactRole)
                    .HasColumnName("contact_role")
                    .HasMaxLength(50);

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ContactsCstm>(entity =>
            {
                entity.HasKey(e => e.IdC);

                entity.ToTable("contacts_cstm", "db_taylormade");

                entity.Property(e => e.IdC)
                    .HasColumnName("id_c")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountStatusC)
                    .HasColumnName("account_status_c")
                    .HasMaxLength(100);

                entity.Property(e => e.AdiCommitC)
                    .HasColumnName("adi_commit_c")
                    .HasMaxLength(255);

                entity.Property(e => e.AshCommitC)
                    .HasColumnName("ash_commit_c")
                    .HasMaxLength(255);

                entity.Property(e => e.BallNumberPreferenceC)
                    .HasColumnName("ball_number_preference_c")
                    .HasMaxLength(255);

                entity.Property(e => e.BilltonumberC)
                    .HasColumnName("billtonumber_c")
                    .HasMaxLength(255);

                entity.Property(e => e.ContractNameC)
                    .HasColumnName("contract_name_c")
                    .HasMaxLength(255);

                entity.Property(e => e.ContractSignerC).HasColumnName("contract_signer_c");

                entity.Property(e => e.CourseTypeC)
                    .HasColumnName("course_type_c")
                    .HasMaxLength(255);

                entity.Property(e => e.CrusaderLevelC)
                    .HasColumnName("crusader_level_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DecisionMakerC)
                    .HasColumnName("decision_maker_c")
                    .HasMaxLength(100);

                entity.Property(e => e.DominantHandC)
                    .HasColumnName("dominant_hand_c")
                    .HasMaxLength(100);

                entity.Property(e => e.EchosignC)
                    .HasColumnName("echosign_c")
                    .HasMaxLength(255);

                entity.Property(e => e.GenderC)
                    .HasColumnName("gender_c")
                    .HasMaxLength(255);

                entity.Property(e => e.GiftCardNumberC)
                    .HasColumnName("gift_card_number_c")
                    .HasMaxLength(100);

                entity.Property(e => e.GloveSizeC)
                    .HasColumnName("glove_size_c")
                    .HasMaxLength(255);

                entity.Property(e => e.LastSurveyDateC)
                    .HasColumnName("last_survey_date_c")
                    .HasColumnType("date");

                entity.Property(e => e.NotesC).HasColumnName("notes_c");

                entity.Property(e => e.OracleSiteC)
                    .HasColumnName("oracle_site_c")
                    .HasMaxLength(255);

                entity.Property(e => e.OracleVendorIdC)
                    .HasColumnName("oracle_vendor_id_c")
                    .HasMaxLength(100);

                entity.Property(e => e.OuterwearSizeC)
                    .HasColumnName("outerwear_size_c")
                    .HasMaxLength(255);

                entity.Property(e => e.OuterwearbSizeC)
                    .HasColumnName("outerwearb_size_c")
                    .HasMaxLength(255);

                entity.Property(e => e.PgaAffiliationC)
                    .HasColumnName("pga_affiliation_c")
                    .HasMaxLength(255);

                entity.Property(e => e.PgaSectionC)
                    .HasColumnName("pga_section_c")
                    .HasMaxLength(255);

                entity.Property(e => e.PhoneFacilityC)
                    .HasColumnName("phone_facility_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RoleC)
                    .HasColumnName("role_c")
                    .HasMaxLength(100);

                entity.Property(e => e.SalesProgramC)
                    .HasColumnName("sales_program_c")
                    .HasMaxLength(100);

                entity.Property(e => e.ShippingPreferenceC)
                    .HasColumnName("shipping_preference_c")
                    .HasMaxLength(100);

                entity.Property(e => e.ShiptoIdC)
                    .HasColumnName("shipto_id_c")
                    .HasMaxLength(25);

                entity.Property(e => e.ShirtSizeC)
                    .HasColumnName("shirt_size_c")
                    .HasMaxLength(255);

                entity.Property(e => e.ShoeSizeC)
                    .HasColumnName("shoe_size_c")
                    .HasMaxLength(255);

                entity.Property(e => e.ShoeWidthC)
                    .HasColumnName("shoe_width_c")
                    .HasMaxLength(255);

                entity.Property(e => e.SpouseNameC)
                    .HasColumnName("spouse_name_c")
                    .HasMaxLength(255);

                entity.Property(e => e.StaffC)
                    .HasColumnName("staff_c")
                    .HasMaxLength(100);

                entity.Property(e => e.StaffIdC)
                    .HasColumnName("staff_id_c")
                    .HasMaxLength(255);

                entity.Property(e => e.StaffIntegrationResponseC)
                    .HasColumnName("staff_integration_response_c")
                    .HasMaxLength(255);

                entity.Property(e => e.StaffLoginidC)
                    .HasColumnName("staff_loginid_c")
                    .HasMaxLength(255);

                entity.Property(e => e.TmCommitmentC)
                    .HasColumnName("tm_commitment_c")
                    .HasMaxLength(255);

                entity.Property(e => e.UkPreferredLanguageC)
                    .HasColumnName("uk_preferred_language_c")
                    .HasMaxLength(255);

                entity.Property(e => e.UserTypeC)
                    .HasColumnName("user_type_c")
                    .HasMaxLength(255);

                entity.Property(e => e.VipStatusC)
                    .HasColumnName("vip_status_c")
                    .HasMaxLength(100);

                entity.Property(e => e.W9OnFileC)
                    .HasColumnName("w9_on_file_c")
                    .HasMaxLength(100);

                entity.Property(e => e.WaistSizeC)
                    .HasColumnName("waist_size_c")
                    .HasMaxLength(255);

                entity.Property(e => e.WebsiteC)
                    .HasColumnName("website_c")
                    .HasMaxLength(255);

                entity.Property(e => e.WinterAddressCityC)
                    .HasColumnName("winter_address_city_c")
                    .HasMaxLength(100);

                entity.Property(e => e.WinterAddressCountryC)
                    .HasColumnName("winter_address_country_c")
                    .HasMaxLength(255);

                entity.Property(e => e.WinterAddressPostalcodeC)
                    .HasColumnName("winter_address_postalcode_c")
                    .HasMaxLength(255);

                entity.Property(e => e.WinterAddressStateC)
                    .HasColumnName("winter_address_state_c")
                    .HasMaxLength(255);

                entity.Property(e => e.WinterAddressStreetC).HasColumnName("winter_address_street_c");
            });

            modelBuilder.Entity<ContactsUsers>(entity =>
            {
                entity.ToTable("contacts_users", "db_taylormade");

                entity.HasIndex(e => e.ContactId)
                    .HasName("idx_con_users_con");

                entity.HasIndex(e => e.UserId)
                    .HasName("idx_con_users_user");

                entity.HasIndex(e => new { e.ContactId, e.UserId })
                    .HasName("idx_contacts_users");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<Contracts>(entity =>
            {
                entity.ToTable("contracts", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_contracts_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("contractsmod");

                entity.HasIndex(e => e.EndDate)
                    .HasName("idx_contract_end_date");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_contract_name");

                entity.HasIndex(e => e.StartDate)
                    .HasName("idx_contract_start_date");

                entity.HasIndex(e => e.Status)
                    .HasName("idx_contract_status");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_contracts_tmst_id");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_contracts_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_contracts_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_contracts_name_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.BaseRate)
                    .HasColumnName("base_rate")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.CompanySignedDate)
                    .HasColumnName("company_signed_date")
                    .HasColumnType("date");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("currency_id")
                    .HasColumnType("nchar(36)")
                    .HasDefaultValueSql("(N'-99')");

                entity.Property(e => e.CustomerSignedDate)
                    .HasColumnName("customer_signed_date")
                    .HasColumnType("date");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("date");

                entity.Property(e => e.ExpirationNotice)
                    .HasColumnName("expiration_notice")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferenceCode)
                    .HasColumnName("reference_code")
                    .HasMaxLength(255);

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("date");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(100);

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TotalContractValue)
                    .HasColumnName("total_contract_value")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.TotalContractValueUsdollar)
                    .HasColumnName("total_contract_value_usdollar")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ContractsAudit>(entity =>
            {
                entity.ToTable("contracts_audit", "db_taylormade");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_contracts_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.AfterValueText).HasColumnName("after_value_text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.BeforeValueText).HasColumnName("before_value_text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<ContractsContacts>(entity =>
            {
                entity.ToTable("contracts_contacts", "db_taylormade");

                entity.HasIndex(e => new { e.ContactId, e.ContractId })
                    .HasName("contracts_contacts_alt");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ContractId)
                    .HasColumnName("contract_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ContractsOpportunities>(entity =>
            {
                entity.ToTable("contracts_opportunities", "db_taylormade");

                entity.HasIndex(e => e.ContractId)
                    .HasName("contracts_opp_alt");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContractId)
                    .HasColumnName("contract_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OpportunityId)
                    .HasColumnName("opportunity_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<ContractsProducts>(entity =>
            {
                entity.ToTable("contracts_products", "db_taylormade");

                entity.HasIndex(e => new { e.ContractId, e.ProductId })
                    .HasName("contracts_prod_alt");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContractId)
                    .HasColumnName("contract_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<ContractsQuotes>(entity =>
            {
                entity.ToTable("contracts_quotes", "db_taylormade");

                entity.HasIndex(e => new { e.ContractId, e.QuoteId })
                    .HasName("contracts_quot_alt");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContractId)
                    .HasColumnName("contract_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QuoteId)
                    .HasColumnName("quote_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<ContractTypes>(entity =>
            {
                entity.ToTable("contract_types", "db_taylormade");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_contracttype_name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ListOrder).HasColumnName("list_order");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<CrCallRecords>(entity =>
            {
                entity.ToTable("cr_call_records", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_cr_call_records_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("cr_call_recordsmod");

                entity.HasIndex(e => new { e.AgentId, e.Deleted })
                    .HasName("idx_agentid_del");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_cr_call_records_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_cr_call_records_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_cr_call_records_name_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AgentId)
                    .HasColumnName("agent_id")
                    .HasMaxLength(255);

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(255);

                entity.Property(e => e.Response).HasColumnName("response");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<CrCallRecordsAudit>(entity =>
            {
                entity.ToTable("cr_call_records_audit", "db_taylormade");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_cr_call_records_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.AfterValueText).HasColumnName("after_value_text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.BeforeValueText).HasColumnName("before_value_text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<Currencies>(entity =>
            {
                entity.ToTable("currencies", "db_taylormade");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_currency_name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConversionRate)
                    .HasColumnName("conversion_rate")
                    .HasColumnType("decimal(26, 6)")
                    .HasDefaultValueSql("((0.000000))");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Iso4217)
                    .HasColumnName("iso4217")
                    .HasMaxLength(3);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(36);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(100);

                entity.Property(e => e.Symbol)
                    .HasColumnName("symbol")
                    .HasMaxLength(36);
            });

            modelBuilder.Entity<Dashboards>(entity =>
            {
                entity.ToTable("dashboards", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_dashboards_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("dashboardsmod");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_dashboards_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_dashboards_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_dashboards_name_del");

                entity.HasIndex(e => new { e.AssignedUserId, e.DashboardModule, e.ViewName })
                    .HasName("user_module_view");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DashboardModule)
                    .HasColumnName("dashboard_module")
                    .HasMaxLength(100);

                entity.Property(e => e.DashboardType)
                    .HasColumnName("dashboard_type")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'dashboard')");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Metadata).HasColumnName("metadata");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.ViewName)
                    .HasColumnName("view_name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DocumentRevisions>(entity =>
            {
                entity.ToTable("document_revisions", "db_taylormade");

                entity.HasIndex(e => e.DocumentId)
                    .HasName("documentrevision_document_id");

                entity.HasIndex(e => e.FileMimeType)
                    .HasName("documentrevision_mimetype");

                entity.HasIndex(e => new { e.DocumentId, e.Deleted })
                    .HasName("idx_document_revisions_document_id_deleted");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChangeLog)
                    .HasColumnName("change_log")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DocId)
                    .HasColumnName("doc_id")
                    .HasMaxLength(100);

                entity.Property(e => e.DocType)
                    .HasColumnName("doc_type")
                    .HasMaxLength(100);

                entity.Property(e => e.DocUrl)
                    .HasColumnName("doc_url")
                    .HasMaxLength(255);

                entity.Property(e => e.DocumentId)
                    .HasColumnName("document_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.FileExt)
                    .HasColumnName("file_ext")
                    .HasMaxLength(100);

                entity.Property(e => e.FileMimeType)
                    .HasColumnName("file_mime_type")
                    .HasMaxLength(100);

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasMaxLength(255);

                entity.Property(e => e.Revision)
                    .HasColumnName("revision")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Documents>(entity =>
            {
                entity.ToTable("documents", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_document_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("documentsmod");

                entity.HasIndex(e => e.DocType)
                    .HasName("idx_document_doc_type");

                entity.HasIndex(e => e.ExpDate)
                    .HasName("idx_document_exp_date");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_documents_tmst_id");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_documents_assigned_del");

                entity.HasIndex(e => new { e.CategoryId, e.SubcategoryId })
                    .HasName("idx_doc_cat");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_documents_id_del");

                entity.HasIndex(e => new { e.RelatedDocId, e.Deleted })
                    .HasName("idx_documents_related_doc_id_deleted");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveDate)
                    .HasColumnName("active_date")
                    .HasColumnType("date");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DocId)
                    .HasColumnName("doc_id")
                    .HasMaxLength(100);

                entity.Property(e => e.DocType)
                    .HasColumnName("doc_type")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Sugar')");

                entity.Property(e => e.DocUrl)
                    .HasColumnName("doc_url")
                    .HasMaxLength(255);

                entity.Property(e => e.DocumentName)
                    .HasColumnName("document_name")
                    .HasMaxLength(255);

                entity.Property(e => e.DocumentRevisionId)
                    .HasColumnName("document_revision_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ExpDate)
                    .HasColumnName("exp_date")
                    .HasColumnType("date");

                entity.Property(e => e.IsTemplate)
                    .HasColumnName("is_template")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.RelatedDocId)
                    .HasColumnName("related_doc_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.RelatedDocRevId)
                    .HasColumnName("related_doc_rev_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.StatusId)
                    .HasColumnName("status_id")
                    .HasMaxLength(100);

                entity.Property(e => e.SubcategoryId)
                    .HasColumnName("subcategory_id")
                    .HasMaxLength(100);

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TemplateType)
                    .HasColumnName("template_type")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DocumentsAccounts>(entity =>
            {
                entity.ToTable("documents_accounts", "db_taylormade");

                entity.HasIndex(e => new { e.AccountId, e.DocumentId })
                    .HasName("documents_accounts_account_id");

                entity.HasIndex(e => new { e.DocumentId, e.AccountId })
                    .HasName("documents_accounts_document_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DocumentId)
                    .HasColumnName("document_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<DocumentsBugs>(entity =>
            {
                entity.ToTable("documents_bugs", "db_taylormade");

                entity.HasIndex(e => new { e.BugId, e.DocumentId })
                    .HasName("documents_bugs_bug_id");

                entity.HasIndex(e => new { e.DocumentId, e.BugId })
                    .HasName("documents_bugs_document_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.BugId)
                    .HasColumnName("bug_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DocumentId)
                    .HasColumnName("document_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<DocumentsCases>(entity =>
            {
                entity.ToTable("documents_cases", "db_taylormade");

                entity.HasIndex(e => new { e.CaseId, e.DocumentId })
                    .HasName("documents_cases_case_id");

                entity.HasIndex(e => new { e.DocumentId, e.CaseId })
                    .HasName("documents_cases_document_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CaseId)
                    .HasColumnName("case_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DocumentId)
                    .HasColumnName("document_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<DocumentsContacts>(entity =>
            {
                entity.ToTable("documents_contacts", "db_taylormade");

                entity.HasIndex(e => new { e.ContactId, e.DocumentId })
                    .HasName("documents_contacts_contact_id");

                entity.HasIndex(e => new { e.DocumentId, e.ContactId })
                    .HasName("documents_contacts_document_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DocumentId)
                    .HasColumnName("document_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<DocumentsOpportunities>(entity =>
            {
                entity.ToTable("documents_opportunities", "db_taylormade");

                entity.HasIndex(e => new { e.DocumentId, e.OpportunityId })
                    .HasName("idx_docu_oppo_docu_id");

                entity.HasIndex(e => new { e.OpportunityId, e.DocumentId })
                    .HasName("idx_docu_opps_oppo_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DocumentId)
                    .HasColumnName("document_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.OpportunityId)
                    .HasColumnName("opportunity_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<DocumentsProducts>(entity =>
            {
                entity.ToTable("documents_products", "db_taylormade");

                entity.HasIndex(e => new { e.DocumentId, e.ProductId })
                    .HasName("documents_products_document_id");

                entity.HasIndex(e => new { e.ProductId, e.DocumentId })
                    .HasName("documents_products_product_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DocumentId)
                    .HasColumnName("document_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<DocumentsQuotes>(entity =>
            {
                entity.ToTable("documents_quotes", "db_taylormade");

                entity.HasIndex(e => new { e.DocumentId, e.QuoteId })
                    .HasName("documents_quotes_document_id");

                entity.HasIndex(e => new { e.QuoteId, e.DocumentId })
                    .HasName("documents_quotes_quote_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DocumentId)
                    .HasColumnName("document_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.QuoteId)
                    .HasColumnName("quote_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<DocumentsRevenuelineitems>(entity =>
            {
                entity.ToTable("documents_revenuelineitems", "db_taylormade");

                entity.HasIndex(e => new { e.DocumentId, e.RliId })
                    .HasName("documents_revenuelineitems_document_id");

                entity.HasIndex(e => new { e.RliId, e.DocumentId })
                    .HasName("documents_revenuelineitems_revenuelineitem_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DocumentId)
                    .HasColumnName("document_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.RliId)
                    .HasColumnName("rli_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<Eapm>(entity =>
            {
                entity.ToTable("eapm", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_eapm_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("eapmmod");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_eapm_name");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_eapm_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_eapm_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_eapm_name_del");

                entity.HasIndex(e => new { e.AssignedUserId, e.Application, e.Validated })
                    .HasName("idx_app_active");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApiData).HasColumnName("api_data");

                entity.Property(e => e.Application)
                    .HasColumnName("application")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'webex')");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ConsumerKey)
                    .HasColumnName("consumer_key")
                    .HasMaxLength(255);

                entity.Property(e => e.ConsumerSecret)
                    .HasColumnName("consumer_secret")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.OauthSecret)
                    .HasColumnName("oauth_secret")
                    .HasMaxLength(255);

                entity.Property(e => e.OauthToken)
                    .HasColumnName("oauth_token")
                    .HasMaxLength(255);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(255);

                entity.Property(e => e.Validated).HasColumnName("validated");
            });

            modelBuilder.Entity<EExperiences>(entity =>
            {
                entity.ToTable("e_experiences", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_e_experiences_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("e_experiencesmod");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_e_experiences_tmst_id");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_e_experiences_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_e_experiences_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_e_experiences_name_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.ExperienceDate)
                    .HasColumnName("experience_date")
                    .HasColumnType("date");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(255);

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.PlayerType)
                    .HasColumnName("player_type")
                    .HasMaxLength(100);

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<EExperiencesAudit>(entity =>
            {
                entity.ToTable("e_experiences_audit", "db_taylormade");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_e_experiences_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.AfterValueText).HasColumnName("after_value_text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.BeforeValueText).HasColumnName("before_value_text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<EExperiencesCConsumersC>(entity =>
            {
                entity.ToTable("e_experiences_c_consumers_c", "db_taylormade");

                entity.HasIndex(e => e.EExperiencesCConsumerscConsumersIda)
                    .HasName("e_experiences_c_consumers_ida1");

                entity.HasIndex(e => e.EExperiencesCConsumerseExperiencesIdb)
                    .HasName("e_experiences_c_consumers_alt");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(36)
                    .ValueGeneratedNever();

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EExperiencesCConsumerscConsumersIda)
                    .HasColumnName("e_experiences_c_consumersc_consumers_ida")
                    .HasMaxLength(36);

                entity.Property(e => e.EExperiencesCConsumerseExperiencesIdb)
                    .HasColumnName("e_experiences_c_consumerse_experiences_idb")
                    .HasMaxLength(36);
            });

            modelBuilder.Entity<EmailAddrBeanRel>(entity =>
            {
                entity.ToTable("email_addr_bean_rel", "db_taylormade");

                entity.HasIndex(e => e.EmailAddressId)
                    .HasName("idx_email_address_id");

                entity.HasIndex(e => new { e.BeanId, e.BeanModule })
                    .HasName("idx_bean_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.BeanId)
                    .IsRequired()
                    .HasColumnName("bean_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.BeanModule)
                    .HasColumnName("bean_module")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailAddressId)
                    .IsRequired()
                    .HasColumnName("email_address_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.PrimaryAddress)
                    .HasColumnName("primary_address")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReplyToAddress)
                    .HasColumnName("reply_to_address")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<EmailAddresses>(entity =>
            {
                entity.ToTable("email_addresses", "db_taylormade");

                entity.HasIndex(e => new { e.EmailAddress, e.OptOut, e.InvalidEmail })
                    .HasName("idx_ea_opt_out_invalid");

                entity.HasIndex(e => new { e.EmailAddressCaps, e.OptOut, e.InvalidEmail })
                    .HasName("idx_ea_caps_opt_out_invalid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("email_address")
                    .HasMaxLength(255);

                entity.Property(e => e.EmailAddressCaps)
                    .HasColumnName("email_address_caps")
                    .HasMaxLength(255);

                entity.Property(e => e.InvalidEmail)
                    .HasColumnName("invalid_email")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OptOut)
                    .HasColumnName("opt_out")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Emailman>(entity =>
            {
                entity.ToTable("emailman", "db_taylormade");

                entity.HasIndex(e => e.CampaignId)
                    .HasName("idx_eman_campaign_id");

                entity.HasIndex(e => e.SendAttempts)
                    .HasName("idx_emailman_send_attempts");

                entity.HasIndex(e => e.SendDateTime)
                    .HasName("idx_emailman_send_date_time");

                entity.HasIndex(e => new { e.ListId, e.UserId, e.Deleted })
                    .HasName("idx_eman_list");

                entity.HasIndex(e => new { e.RelatedId, e.RelatedType, e.CampaignId })
                    .HasName("idx_eman_relid_reltype_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InQueue)
                    .HasColumnName("in_queue")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InQueueDate)
                    .HasColumnName("in_queue_date")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.ListId)
                    .HasColumnName("list_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.MarketingId)
                    .HasColumnName("marketing_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.RelatedId)
                    .HasColumnName("related_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.RelatedType)
                    .HasColumnName("related_type")
                    .HasMaxLength(100);

                entity.Property(e => e.SendAttempts)
                    .HasColumnName("send_attempts")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SendDateTime)
                    .HasColumnName("send_date_time")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<EmailMarketing>(entity =>
            {
                entity.ToTable("email_marketing", "db_taylormade");

                entity.HasIndex(e => e.Deleted)
                    .HasName("idx_emmkit_del");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_emmkt_name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AllProspectLists)
                    .HasColumnName("all_prospect_lists")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateStart)
                    .HasColumnName("date_start")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.FromAddr)
                    .HasColumnName("from_addr")
                    .HasMaxLength(100);

                entity.Property(e => e.FromName)
                    .HasColumnName("from_name")
                    .HasMaxLength(100);

                entity.Property(e => e.InboundEmailId)
                    .HasColumnName("inbound_email_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.ReplyToAddr)
                    .HasColumnName("reply_to_addr")
                    .HasMaxLength(100);

                entity.Property(e => e.ReplyToName)
                    .HasColumnName("reply_to_name")
                    .HasMaxLength(100);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(100);

                entity.Property(e => e.TemplateId)
                    .IsRequired()
                    .HasColumnName("template_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<EmailMarketingProspectLists>(entity =>
            {
                entity.ToTable("email_marketing_prospect_lists", "db_taylormade");

                entity.HasIndex(e => new { e.EmailMarketingId, e.ProspectListId })
                    .HasName("email_mp_prospects");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailMarketingId)
                    .HasColumnName("email_marketing_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ProspectListId)
                    .HasColumnName("prospect_list_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<Emails>(entity =>
            {
                entity.ToTable("emails", "db_taylormade");

                entity.HasIndex(e => e.MessageId)
                    .HasName("idx_message_id");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_email_name");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_email_parent_id");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_emails_tmst_id");

                entity.HasIndex(e => new { e.AssignedUserId, e.Type, e.Status })
                    .HasName("idx_email_assigned");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateSent)
                    .HasColumnName("date_sent")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Flagged).HasColumnName("flagged");

                entity.Property(e => e.Intent)
                    .HasColumnName("intent")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'pick')");

                entity.Property(e => e.MailboxId)
                    .HasColumnName("mailbox_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.MessageId)
                    .HasColumnName("message_id")
                    .HasMaxLength(255);

                entity.Property(e => e.MessageUid)
                    .HasColumnName("message_uid")
                    .HasMaxLength(64);

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ParentType)
                    .HasColumnName("parent_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ReplyToStatus).HasColumnName("reply_to_status");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(100);

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<EmailsBeans>(entity =>
            {
                entity.ToTable("emails_beans", "db_taylormade");

                entity.HasIndex(e => e.BeanId)
                    .HasName("idx_emails_beans_bean_id");

                entity.HasIndex(e => new { e.EmailId, e.BeanId, e.Deleted })
                    .HasName("idx_emails_beans_email_bean");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.BeanId)
                    .HasColumnName("bean_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.BeanModule)
                    .HasColumnName("bean_module")
                    .HasMaxLength(100);

                entity.Property(e => e.CampaignData).HasColumnName("campaign_data");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailId)
                    .HasColumnName("email_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<EmailsEmailAddrRel>(entity =>
            {
                entity.ToTable("emails_email_addr_rel", "db_taylormade");

                entity.HasIndex(e => e.EmailAddressId)
                    .HasName("idx_eearl_address_id");

                entity.HasIndex(e => new { e.EmailId, e.AddressType })
                    .HasName("idx_eearl_email_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressType)
                    .HasColumnName("address_type")
                    .HasMaxLength(4);

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailAddressId)
                    .IsRequired()
                    .HasColumnName("email_address_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasColumnName("email_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<EmailsText>(entity =>
            {
                entity.HasKey(e => e.EmailId);

                entity.ToTable("emails_text", "db_taylormade");

                entity.HasIndex(e => e.FromAddr)
                    .HasName("emails_textfromaddr");

                entity.Property(e => e.EmailId)
                    .HasColumnName("email_id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.BccAddrs).HasColumnName("bcc_addrs");

                entity.Property(e => e.CcAddrs).HasColumnName("cc_addrs");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DescriptionHtml).HasColumnName("description_html");

                entity.Property(e => e.FromAddr)
                    .HasColumnName("from_addr")
                    .HasMaxLength(255);

                entity.Property(e => e.RawSource).HasColumnName("raw_source");

                entity.Property(e => e.ReplyToAddr)
                    .HasColumnName("reply_to_addr")
                    .HasMaxLength(255);

                entity.Property(e => e.ToAddrs).HasColumnName("to_addrs");
            });

            modelBuilder.Entity<EmailTemplates>(entity =>
            {
                entity.ToTable("email_templates", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_emailtemplate_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("idx_emailtemplate_date_modified");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_email_template_name");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_email_templates_tmst_id");

                entity.HasIndex(e => e.Type)
                    .HasName("idx_emailtemplate_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.BaseModule)
                    .HasColumnName("base_module")
                    .HasMaxLength(50);

                entity.Property(e => e.Body).HasColumnName("body");

                entity.Property(e => e.BodyHtml).HasColumnName("body_html");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.FromAddress)
                    .HasColumnName("from_address")
                    .HasMaxLength(255);

                entity.Property(e => e.FromName)
                    .HasColumnName("from_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Published)
                    .HasColumnName("published")
                    .HasMaxLength(3);

                entity.Property(e => e.Subject)
                    .HasColumnName("subject")
                    .HasMaxLength(255);

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TextOnly).HasColumnName("text_only");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<EmbeddedFiles>(entity =>
            {
                entity.ToTable("embedded_files", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_embedded_files_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("idx_embedded_files_date_modfied");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_embedded_files_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_embedded_files_name_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.FileMimeType)
                    .HasColumnName("file_mime_type")
                    .HasMaxLength(100);

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasMaxLength(255);

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Expressions>(entity =>
            {
                entity.ToTable("expressions", "db_taylormade");

                entity.HasIndex(e => new { e.ParentId, e.Deleted })
                    .HasName("idx_exp");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpOrder).HasColumnName("exp_order");

                entity.Property(e => e.ExpType)
                    .HasColumnName("exp_type")
                    .HasMaxLength(100);

                entity.Property(e => e.Ext1)
                    .HasColumnName("ext1")
                    .HasMaxLength(50);

                entity.Property(e => e.Ext2)
                    .HasColumnName("ext2")
                    .HasMaxLength(50);

                entity.Property(e => e.Ext3)
                    .HasColumnName("ext3")
                    .HasMaxLength(50);

                entity.Property(e => e.LhsField)
                    .HasColumnName("lhs_field")
                    .HasMaxLength(50);

                entity.Property(e => e.LhsGroupType)
                    .HasColumnName("lhs_group_type")
                    .HasMaxLength(10);

                entity.Property(e => e.LhsModule)
                    .HasColumnName("lhs_module")
                    .HasMaxLength(50);

                entity.Property(e => e.LhsType)
                    .HasColumnName("lhs_type")
                    .HasMaxLength(15);

                entity.Property(e => e.LhsValue)
                    .HasColumnName("lhs_value")
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Operator)
                    .HasColumnName("operator")
                    .HasMaxLength(15);

                entity.Property(e => e.ParentExpId)
                    .HasColumnName("parent_exp_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ParentExpSide).HasColumnName("parent_exp_side");

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ParentType)
                    .HasColumnName("parent_type")
                    .HasMaxLength(255);

                entity.Property(e => e.RhsField)
                    .HasColumnName("rhs_field")
                    .HasMaxLength(50);

                entity.Property(e => e.RhsGroupType)
                    .HasColumnName("rhs_group_type")
                    .HasMaxLength(10);

                entity.Property(e => e.RhsModule)
                    .HasColumnName("rhs_module")
                    .HasMaxLength(50);

                entity.Property(e => e.RhsType)
                    .HasColumnName("rhs_type")
                    .HasMaxLength(15);

                entity.Property(e => e.RhsValue)
                    .HasColumnName("rhs_value")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<FieldsMetaData>(entity =>
            {
                entity.ToTable("fields_meta_data", "db_taylormade");

                entity.HasIndex(e => new { e.CustomModule, e.Deleted })
                    .HasName("idx_meta_cm_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_meta_id_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Audited)
                    .HasColumnName("audited")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomModule)
                    .HasColumnName("custom_module")
                    .HasMaxLength(255);

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DefaultValue)
                    .HasColumnName("default_value")
                    .HasMaxLength(255);

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DuplicateMerge)
                    .HasColumnName("duplicate_merge")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ext1)
                    .HasColumnName("ext1")
                    .HasMaxLength(255);

                entity.Property(e => e.Ext2)
                    .HasColumnName("ext2")
                    .HasMaxLength(255);

                entity.Property(e => e.Ext3)
                    .HasColumnName("ext3")
                    .HasMaxLength(255);

                entity.Property(e => e.Ext4).HasColumnName("ext4");

                entity.Property(e => e.Help)
                    .HasColumnName("help")
                    .HasMaxLength(255);

                entity.Property(e => e.Importable)
                    .HasColumnName("importable")
                    .HasMaxLength(255);

                entity.Property(e => e.Len).HasColumnName("len");

                entity.Property(e => e.Massupdate)
                    .HasColumnName("massupdate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Reportable)
                    .HasColumnName("reportable")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Required)
                    .HasColumnName("required")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255);

                entity.Property(e => e.Vname)
                    .HasColumnName("vname")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Filters>(entity =>
            {
                entity.ToTable("filters", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_filters_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("filtersmod");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_filters_tmst_id");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_filters_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_filters_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_filters_name_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.FilterDefinition).HasColumnName("filter_definition");

                entity.Property(e => e.FilterTemplate).HasColumnName("filter_template");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ModuleName)
                    .HasColumnName("module_name")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<Folders>(entity =>
            {
                entity.ToTable("folders", "db_taylormade");

                entity.HasIndex(e => e.ParentFolder)
                    .HasName("idx_parent_folder");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignToId)
                    .HasColumnName("assign_to_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DynamicQuery).HasColumnName("dynamic_query");

                entity.Property(e => e.FolderType)
                    .HasColumnName("folder_type")
                    .HasMaxLength(25);

                entity.Property(e => e.HasChild)
                    .HasColumnName("has_child")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDynamic)
                    .HasColumnName("is_dynamic")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsGroup)
                    .HasColumnName("is_group")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnName("modified_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(25);

                entity.Property(e => e.ParentFolder)
                    .HasColumnName("parent_folder")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<FoldersRel>(entity =>
            {
                entity.ToTable("folders_rel", "db_taylormade");

                entity.HasIndex(e => new { e.PolymorphicModule, e.PolymorphicId })
                    .HasName("idx_poly_module_poly_id");

                entity.HasIndex(e => new { e.FolderId, e.Deleted, e.PolymorphicId })
                    .HasName("idx_fr_id_deleted_poly");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FolderId)
                    .IsRequired()
                    .HasColumnName("folder_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.PolymorphicId)
                    .IsRequired()
                    .HasColumnName("polymorphic_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.PolymorphicModule)
                    .HasColumnName("polymorphic_module")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<FoldersSubscriptions>(entity =>
            {
                entity.ToTable("folders_subscriptions", "db_taylormade");

                entity.HasIndex(e => new { e.FolderId, e.AssignedUserId })
                    .HasName("idx_folder_id_assigned_user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .IsRequired()
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.FolderId)
                    .IsRequired()
                    .HasColumnName("folder_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<ForecastManagerWorksheets>(entity =>
            {
                entity.ToTable("forecast_manager_worksheets", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_forecast_manager_worksheets_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("forecast_manager_worksheetsmod");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_forecast_manager_worksheets_tmst_id");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_forecast_manager_worksheets_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_forecast_manager_worksheets_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_forecast_manager_worksheets_name_del");

                entity.HasIndex(e => new { e.AssignedUserId, e.UserId, e.TimeperiodId, e.Draft, e.Deleted })
                    .HasName("idx_manager_worksheets_user_timestamp_assigned_user");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.BaseRate)
                    .HasColumnName("base_rate")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.BestCase)
                    .HasColumnName("best_case")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.BestCaseAdjusted)
                    .HasColumnName("best_case_adjusted")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.ClosedAmount)
                    .HasColumnName("closed_amount")
                    .HasColumnType("decimal(26, 6)")
                    .HasDefaultValueSql("((0.000000))");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("currency_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Draft)
                    .HasColumnName("draft")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LikelyCase)
                    .HasColumnName("likely_case")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.LikelyCaseAdjusted)
                    .HasColumnName("likely_case_adjusted")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.ManagerSaved)
                    .HasColumnName("manager_saved")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.OppCount).HasColumnName("opp_count");

                entity.Property(e => e.PipelineAmount)
                    .HasColumnName("pipeline_amount")
                    .HasColumnType("decimal(26, 6)")
                    .HasDefaultValueSql("((0.000000))");

                entity.Property(e => e.PipelineOppCount)
                    .HasColumnName("pipeline_opp_count")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Quota)
                    .HasColumnName("quota")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TimeperiodId)
                    .HasColumnName("timeperiod_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.WorstCase)
                    .HasColumnName("worst_case")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.WorstCaseAdjusted)
                    .HasColumnName("worst_case_adjusted")
                    .HasColumnType("decimal(26, 6)");
            });

            modelBuilder.Entity<ForecastManagerWorksheetsAudit>(entity =>
            {
                entity.ToTable("forecast_manager_worksheets_audit", "db_taylormade");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_forecast_manager_worksheets_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.AfterValueText).HasColumnName("after_value_text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.BeforeValueText).HasColumnName("before_value_text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<Forecasts>(entity =>
            {
                entity.ToTable("forecasts", "db_taylormade");

                entity.HasIndex(e => new { e.UserId, e.TimeperiodId, e.DateModified })
                    .HasName("idx_forecast_user_tp");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.BaseRate)
                    .HasColumnName("base_rate")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.BestCase)
                    .HasColumnName("best_case")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.ClosedAmount)
                    .HasColumnName("closed_amount")
                    .HasColumnType("decimal(26, 6)")
                    .HasDefaultValueSql("((0.000000))");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("currency_id")
                    .HasColumnType("nchar(36)")
                    .HasDefaultValueSql("(N'-99')");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.ForecastType)
                    .HasColumnName("forecast_type")
                    .HasMaxLength(100);

                entity.Property(e => e.LikelyCase)
                    .HasColumnName("likely_case")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.OppCount).HasColumnName("opp_count");

                entity.Property(e => e.OppWeighValue).HasColumnName("opp_weigh_value");

                entity.Property(e => e.PipelineAmount)
                    .HasColumnName("pipeline_amount")
                    .HasColumnType("decimal(26, 6)")
                    .HasDefaultValueSql("((0.000000))");

                entity.Property(e => e.PipelineOppCount)
                    .HasColumnName("pipeline_opp_count")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TimeperiodId)
                    .HasColumnName("timeperiod_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.WorstCase)
                    .HasColumnName("worst_case")
                    .HasColumnType("decimal(26, 6)");
            });

            modelBuilder.Entity<ForecastSchedule>(entity =>
            {
                entity.ToTable("forecast_schedule", "db_taylormade");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CascadeHierarchy).HasColumnName("cascade_hierarchy");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.ForecastStartDate)
                    .HasColumnName("forecast_start_date")
                    .HasColumnType("date");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(100);

                entity.Property(e => e.TimeperiodId)
                    .HasColumnName("timeperiod_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<ForecastTree>(entity =>
            {
                entity.ToTable("forecast_tree", "db_taylormade");

                entity.HasIndex(e => e.UserId)
                    .HasName("forecast_tree_idx_user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.HierarchyType)
                    .HasColumnName("hierarchy_type")
                    .HasMaxLength(25);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<ForecastWorksheets>(entity =>
            {
                entity.ToTable("forecast_worksheets", "db_taylormade");

                entity.HasIndex(e => e.CommitStage)
                    .HasName("idx_forecastworksheet_commit_stage");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_forecast_worksheets_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("forecast_worksheetsmod");

                entity.HasIndex(e => e.SalesStage)
                    .HasName("idx_forecastworksheet_sales_stage");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_forecast_worksheets_tmst_id");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_forecast_worksheets_assigned_del");

                entity.HasIndex(e => new { e.Deleted, e.AssignedUserId })
                    .HasName("idx_worksheets_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_forecast_worksheets_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_forecast_worksheets_name_del");

                entity.HasIndex(e => new { e.ParentId, e.ParentType })
                    .HasName("idx_worksheets_parent");

                entity.HasIndex(e => new { e.Deleted, e.AssignedUserId, e.Draft, e.DateClosedTimestamp, e.ParentType })
                    .HasName("idx_worksheets_assigned_del_time_draft_parent_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.BaseRate)
                    .HasColumnName("base_rate")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.BestCase)
                    .HasColumnName("best_case")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CampaignName)
                    .HasColumnName("campaign_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CategoryName)
                    .HasColumnName("category_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CommitStage)
                    .HasColumnName("commit_stage")
                    .HasMaxLength(50);

                entity.Property(e => e.CostPrice)
                    .HasColumnName("cost_price")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("currency_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateClosed)
                    .HasColumnName("date_closed")
                    .HasColumnType("date");

                entity.Property(e => e.DateClosedTimestamp)
                    .HasColumnName("date_closed_timestamp")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DiscountAmount)
                    .HasColumnName("discount_amount")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.DiscountPrice)
                    .HasColumnName("discount_price")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.Draft)
                    .HasColumnName("draft")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LeadSource)
                    .HasColumnName("lead_source")
                    .HasMaxLength(50);

                entity.Property(e => e.LikelyCase)
                    .HasColumnName("likely_case")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.ListPrice)
                    .HasColumnName("list_price")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.NextStep)
                    .HasColumnName("next_step")
                    .HasMaxLength(100);

                entity.Property(e => e.OpportunityId)
                    .HasColumnName("opportunity_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.OpportunityName)
                    .HasColumnName("opportunity_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ParentType)
                    .HasColumnName("parent_type")
                    .HasMaxLength(255);

                entity.Property(e => e.Probability).HasColumnName("probability");

                entity.Property(e => e.ProductTemplateId)
                    .HasColumnName("product_template_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ProductTemplateName)
                    .HasColumnName("product_template_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ProductType)
                    .HasColumnName("product_type")
                    .HasMaxLength(255);

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SalesStage)
                    .HasColumnName("sales_stage")
                    .HasMaxLength(255);

                entity.Property(e => e.SalesStatus)
                    .HasColumnName("sales_status")
                    .HasMaxLength(255);

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TotalAmount)
                    .HasColumnName("total_amount")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.WorstCase)
                    .HasColumnName("worst_case")
                    .HasColumnType("decimal(26, 6)");
            });

            modelBuilder.Entity<FtsQueue>(entity =>
            {
                entity.ToTable("fts_queue", "db_taylormade");

                entity.HasIndex(e => new { e.BeanModule, e.BeanId })
                    .HasName("idx_beans_bean_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.BeanId)
                    .HasColumnName("bean_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.BeanModule)
                    .HasColumnName("bean_module")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Processed)
                    .HasColumnName("processed")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Healthcheck>(entity =>
            {
                entity.ToTable("healthcheck", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_healthcheck_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("idx_healthcheck_date_modfied");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_healthcheck_id_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bucket)
                    .HasColumnName("bucket")
                    .HasColumnType("nchar(1)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Error)
                    .HasColumnName("error")
                    .HasMaxLength(255);

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.Logfile)
                    .HasColumnName("logfile")
                    .HasMaxLength(255);

                entity.Property(e => e.Logmeta).HasColumnName("logmeta");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Holidays>(entity =>
            {
                entity.ToTable("holidays", "db_taylormade");

                entity.HasIndex(e => e.HolidayDate)
                    .HasName("idx_holiday_holiday_date");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_holiday_id_del");

                entity.HasIndex(e => new { e.RelatedModuleId, e.RelatedModule })
                    .HasName("idx_holiday_id_rel");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.HolidayDate)
                    .HasColumnName("holiday_date")
                    .HasColumnType("date");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.PersonId)
                    .HasColumnName("person_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.PersonType)
                    .HasColumnName("person_type")
                    .HasMaxLength(255);

                entity.Property(e => e.RelatedModule)
                    .HasColumnName("related_module")
                    .HasMaxLength(255);

                entity.Property(e => e.RelatedModuleId)
                    .HasColumnName("related_module_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ResourceName)
                    .HasColumnName("resource_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ImportMaps>(entity =>
            {
                entity.ToTable("import_maps", "db_taylormade");

                entity.HasIndex(e => new { e.AssignedUserId, e.Module, e.Name, e.Deleted })
                    .HasName("idx_owner_module_name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DefaultValues).HasColumnName("default_values");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Delimiter)
                    .HasColumnName("delimiter")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N',')");

                entity.Property(e => e.Enclosure)
                    .HasColumnName("enclosure")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N' ')");

                entity.Property(e => e.HasHeader)
                    .HasColumnName("has_header")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsPublished)
                    .HasColumnName("is_published")
                    .HasMaxLength(3)
                    .HasDefaultValueSql("(N'no')");

                entity.Property(e => e.Module)
                    .HasColumnName("module")
                    .HasMaxLength(36);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(254);

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasMaxLength(36);
            });

            modelBuilder.Entity<InboundEmail>(entity =>
            {
                entity.ToTable("inbound_email", "db_taylormade");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_inbound_email_tmst_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(36)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DeleteSeen)
                    .HasColumnName("delete_seen")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailPassword)
                    .HasColumnName("email_password")
                    .HasMaxLength(100);

                entity.Property(e => e.EmailUser)
                    .HasColumnName("email_user")
                    .HasMaxLength(100);

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.GroupfolderId)
                    .HasColumnName("groupfolder_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.IsPersonal)
                    .HasColumnName("is_personal")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mailbox).HasColumnName("mailbox");

                entity.Property(e => e.MailboxType)
                    .HasColumnName("mailbox_type")
                    .HasMaxLength(10);

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Port).HasColumnName("port");

                entity.Property(e => e.ServerUrl)
                    .HasColumnName("server_url")
                    .HasMaxLength(100);

                entity.Property(e => e.Service)
                    .HasColumnName("service")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Active')");

                entity.Property(e => e.StoredOptions).HasColumnName("stored_options");

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<InboundEmailAutoreply>(entity =>
            {
                entity.ToTable("inbound_email_autoreply", "db_taylormade");

                entity.HasIndex(e => e.AutorepliedTo)
                    .HasName("idx_ie_autoreplied_to");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AutorepliedTo)
                    .HasColumnName("autoreplied_to")
                    .HasMaxLength(100);

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IeId)
                    .IsRequired()
                    .HasColumnName("ie_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<InboundEmailCacheTs>(entity =>
            {
                entity.ToTable("inbound_email_cache_ts", "db_taylormade");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.IeTimestamp).HasColumnName("ie_timestamp");
            });

            modelBuilder.Entity<JobQueue>(entity =>
            {
                entity.ToTable("job_queue", "db_taylormade");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_job_queue_assigned_del");

                entity.HasIndex(e => new { e.JobGroup, e.Status })
                    .HasName("idx_group_status");

                entity.HasIndex(e => new { e.Status, e.DateEntered })
                    .HasName("idx_status_entered");

                entity.HasIndex(e => new { e.Status, e.DateModified })
                    .HasName("idx_status_modified");

                entity.HasIndex(e => new { e.Status, e.SchedulerId })
                    .HasName("idx_status_scheduler");

                entity.HasIndex(e => new { e.Status, e.ExecuteTime, e.DateEntered })
                    .HasName("idx_status_time");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Client)
                    .HasColumnName("client")
                    .HasMaxLength(255);

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExecuteTime)
                    .HasColumnName("execute_time")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FailureCount).HasColumnName("failure_count");

                entity.Property(e => e.Fallible)
                    .HasColumnName("fallible")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Interface)
                    .HasColumnName("interface")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobDelay).HasColumnName("job_delay");

                entity.Property(e => e.JobGroup)
                    .HasColumnName("job_group")
                    .HasMaxLength(255);

                entity.Property(e => e.Message).HasColumnName("message");

                entity.Property(e => e.Module)
                    .HasColumnName("module")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.PercentComplete).HasColumnName("percent_complete");

                entity.Property(e => e.Requeue)
                    .HasColumnName("requeue")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rerun)
                    .HasColumnName("rerun")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Resolution)
                    .HasColumnName("resolution")
                    .HasMaxLength(20);

                entity.Property(e => e.RetryCount).HasColumnName("retry_count");

                entity.Property(e => e.SchedulerId)
                    .HasColumnName("scheduler_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(20);

                entity.Property(e => e.Target)
                    .HasColumnName("target")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<JobQueueAudit>(entity =>
            {
                entity.ToTable("job_queue_audit", "db_taylormade");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_job_queue_audit_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.AfterValueText).HasColumnName("after_value_text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.BeforeValueText).HasColumnName("before_value_text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<Kbarticles>(entity =>
            {
                entity.ToTable("kbarticles", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_kbarticles_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("idx_kbarticles_date_modfied");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_kbarticles_tmst_id");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_kbarticles_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_kbarticles_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_kbarticles_name_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.KbdocumentId)
                    .HasColumnName("kbdocument_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<Kbcontents>(entity =>
            {
                entity.ToTable("kbcontents", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_kbcontents_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("idx_kbcontents_date_modfied");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_kbcontent_name");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_kbcontents_tmst_id");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_kbcontents_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_kbcontents_id_del");

                entity.HasIndex(e => new { e.KbdocumentId, e.Deleted })
                    .HasName("idx_kbcontent_del_doc_id");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_kbcontents_name_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveDate)
                    .HasColumnName("active_date")
                    .HasColumnType("date");

                entity.Property(e => e.ActiveRev)
                    .HasColumnName("active_rev")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Approved)
                    .HasColumnName("approved")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.ExpDate)
                    .HasColumnName("exp_date")
                    .HasColumnType("date");

                entity.Property(e => e.IsExternal)
                    .HasColumnName("is_external")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KbarticleId)
                    .HasColumnName("kbarticle_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.KbdocumentBody).HasColumnName("kbdocument_body");

                entity.Property(e => e.KbdocumentId)
                    .HasColumnName("kbdocument_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.KbsapproverId)
                    .HasColumnName("kbsapprover_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.KbscaseId)
                    .HasColumnName("kbscase_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Language)
                    .HasColumnName("language")
                    .HasMaxLength(2);

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Notuseful)
                    .HasColumnName("notuseful")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Revision)
                    .HasColumnName("revision")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'draft')");

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Useful)
                    .HasColumnName("useful")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Viewcount)
                    .HasColumnName("viewcount")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KbcontentsAudit>(entity =>
            {
                entity.ToTable("kbcontents_audit", "db_taylormade");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_kbcontents_audit_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.AfterValueText).HasColumnName("after_value_text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.BeforeValueText).HasColumnName("before_value_text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<KbcontentTemplates>(entity =>
            {
                entity.ToTable("kbcontent_templates", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_kbcontent_templates_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("idx_kbcontent_templates_date_modfied");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_kbcontent_templates_tmst_id");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_kbcontent_templates_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_kbcontent_templates_name_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Body).HasColumnName("body");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<KbcontentTemplatesAudit>(entity =>
            {
                entity.ToTable("kbcontent_templates_audit", "db_taylormade");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_kbcontent_templates_audit_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.AfterValueText).HasColumnName("after_value_text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.BeforeValueText).HasColumnName("before_value_text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<Kbdocuments>(entity =>
            {
                entity.ToTable("kbdocuments", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_kbdocuments_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("idx_kbdocuments_date_modfied");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_kbdocuments_tmst_id");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_kbdocuments_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_kbdocuments_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_kbdocuments_name_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<Kbusefulness>(entity =>
            {
                entity.ToTable("kbusefulness", "db_taylormade");

                entity.HasIndex(e => new { e.KbarticleId, e.UserId })
                    .HasName("kbusefulness_user");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KbarticleId)
                    .IsRequired()
                    .HasColumnName("kbarticle_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Ssid)
                    .HasColumnName("ssid")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Vote).HasColumnName("vote");

                entity.Property(e => e.Zeroflag).HasColumnName("zeroflag");
            });

            modelBuilder.Entity<KeyValueCache>(entity =>
            {
                entity.ToTable("key_value_cache", "db_taylormade");

                entity.HasIndex(e => e.DateExpires)
                    .HasName("key_value_cache_date_expires");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(32)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateExpires)
                    .HasColumnName("date_expires")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<Leads>(entity =>
            {
                entity.ToTable("leads", "db_taylormade");

                entity.HasIndex(e => e.AssignedUserId)
                    .HasName("idx_lead_assigned");

                entity.HasIndex(e => e.ContactId)
                    .HasName("idx_lead_contact");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_lead_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("leadsmod");

                entity.HasIndex(e => e.MktoId)
                    .HasName("idx_lead_mkto_id");

                entity.HasIndex(e => e.PhoneWork)
                    .HasName("idx_lead_phone_work");

                entity.HasIndex(e => e.ReportsToId)
                    .HasName("idx_reports_to");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_leads_tmst_id");

                entity.HasIndex(e => new { e.AccountId, e.Deleted })
                    .HasName("idx_leads_acct_del");

                entity.HasIndex(e => new { e.AccountName, e.Deleted })
                    .HasName("idx_lead_acct_name_first");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_leads_assigned_del");

                entity.HasIndex(e => new { e.Deleted, e.AssignedUserId })
                    .HasName("idx_del_user");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_leads_id_del");

                entity.HasIndex(e => new { e.OpportunityId, e.Deleted })
                    .HasName("idx_lead_opp_del");

                entity.HasIndex(e => new { e.FirstName, e.LastName, e.Deleted })
                    .HasName("idx_leads_first_last");

                entity.HasIndex(e => new { e.LastName, e.FirstName, e.Deleted })
                    .HasName("idx_lead_last_first");

                entity.HasIndex(e => new { e.LastName, e.Status, e.Deleted, e.FirstName })
                    .HasName("idx_lead_del_stat");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountDescription).HasColumnName("account_description");

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AltAddressCity)
                    .HasColumnName("alt_address_city")
                    .HasMaxLength(100);

                entity.Property(e => e.AltAddressCountry)
                    .HasColumnName("alt_address_country")
                    .HasMaxLength(255);

                entity.Property(e => e.AltAddressPostalcode)
                    .HasColumnName("alt_address_postalcode")
                    .HasMaxLength(20);

                entity.Property(e => e.AltAddressState)
                    .HasColumnName("alt_address_state")
                    .HasMaxLength(100);

                entity.Property(e => e.AltAddressStreet)
                    .HasColumnName("alt_address_street")
                    .HasMaxLength(150);

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Assistant)
                    .HasColumnName("assistant")
                    .HasMaxLength(75);

                entity.Property(e => e.AssistantPhone)
                    .HasColumnName("assistant_phone")
                    .HasMaxLength(100);

                entity.Property(e => e.Birthdate)
                    .HasColumnName("birthdate")
                    .HasColumnType("date");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Converted)
                    .HasColumnName("converted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Department)
                    .HasColumnName("department")
                    .HasMaxLength(100);

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DnbPrincipalId)
                    .HasColumnName("dnb_principal_id")
                    .HasMaxLength(30);

                entity.Property(e => e.DoNotCall)
                    .HasColumnName("do_not_call")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Facebook)
                    .HasColumnName("facebook")
                    .HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(100);

                entity.Property(e => e.Googleplus)
                    .HasColumnName("googleplus")
                    .HasMaxLength(100);

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(100);

                entity.Property(e => e.LeadSource)
                    .HasColumnName("lead_source")
                    .HasMaxLength(100);

                entity.Property(e => e.LeadSourceDescription).HasColumnName("lead_source_description");

                entity.Property(e => e.MktoId).HasColumnName("mkto_id");

                entity.Property(e => e.MktoLeadScore).HasColumnName("mkto_lead_score");

                entity.Property(e => e.MktoSync)
                    .HasColumnName("mkto_sync")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.OpportunityAmount)
                    .HasColumnName("opportunity_amount")
                    .HasMaxLength(50);

                entity.Property(e => e.OpportunityId)
                    .HasColumnName("opportunity_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.OpportunityName)
                    .HasColumnName("opportunity_name")
                    .HasMaxLength(255);

                entity.Property(e => e.PhoneFax)
                    .HasColumnName("phone_fax")
                    .HasMaxLength(100);

                entity.Property(e => e.PhoneHome)
                    .HasColumnName("phone_home")
                    .HasMaxLength(100);

                entity.Property(e => e.PhoneMobile)
                    .HasColumnName("phone_mobile")
                    .HasMaxLength(100);

                entity.Property(e => e.PhoneOther)
                    .HasColumnName("phone_other")
                    .HasMaxLength(100);

                entity.Property(e => e.PhoneWork)
                    .HasColumnName("phone_work")
                    .HasMaxLength(100);

                entity.Property(e => e.Picture)
                    .HasColumnName("picture")
                    .HasMaxLength(255);

                entity.Property(e => e.PortalApp)
                    .HasColumnName("portal_app")
                    .HasMaxLength(255);

                entity.Property(e => e.PortalName)
                    .HasColumnName("portal_name")
                    .HasMaxLength(255);

                entity.Property(e => e.PreferredLanguage)
                    .HasColumnName("preferred_language")
                    .HasMaxLength(255);

                entity.Property(e => e.PrimaryAddressCity)
                    .HasColumnName("primary_address_city")
                    .HasMaxLength(100);

                entity.Property(e => e.PrimaryAddressCountry)
                    .HasColumnName("primary_address_country")
                    .HasMaxLength(255);

                entity.Property(e => e.PrimaryAddressPostalcode)
                    .HasColumnName("primary_address_postalcode")
                    .HasMaxLength(20);

                entity.Property(e => e.PrimaryAddressState)
                    .HasColumnName("primary_address_state")
                    .HasMaxLength(100);

                entity.Property(e => e.PrimaryAddressStreet)
                    .HasColumnName("primary_address_street")
                    .HasMaxLength(150);

                entity.Property(e => e.ReferedBy)
                    .HasColumnName("refered_by")
                    .HasMaxLength(100);

                entity.Property(e => e.ReportsToId)
                    .HasColumnName("reports_to_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Salutation)
                    .HasColumnName("salutation")
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(100);

                entity.Property(e => e.StatusDescription).HasColumnName("status_description");

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100);

                entity.Property(e => e.Twitter)
                    .HasColumnName("twitter")
                    .HasMaxLength(100);

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<LeadsAudit>(entity =>
            {
                entity.ToTable("leads_audit", "db_taylormade");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_leads_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.AfterValueText).HasColumnName("after_value_text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.BeforeValueText).HasColumnName("before_value_text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<LinkedDocuments>(entity =>
            {
                entity.ToTable("linked_documents", "db_taylormade");

                entity.HasIndex(e => new { e.ParentType, e.ParentId, e.DocumentId })
                    .HasName("idx_parent_document");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DocumentId)
                    .HasColumnName("document_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DocumentRevisionId)
                    .HasColumnName("document_revision_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ParentType)
                    .HasColumnName("parent_type")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<Manufacturers>(entity =>
            {
                entity.ToTable("manufacturers", "db_taylormade");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_manufacturers");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.ListOrder).HasColumnName("list_order");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Meetings>(entity =>
            {
                entity.ToTable("meetings", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_meeting_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("meetingsmod");

                entity.HasIndex(e => e.DateStart)
                    .HasName("idx_meet_date_start");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_mtg_name");

                entity.HasIndex(e => e.RecurrenceId)
                    .HasName("idx_meet_recurrence_id");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_meetings_tmst_id");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_meetings_assigned_del");

                entity.HasIndex(e => new { e.DateStart, e.ReminderTime })
                    .HasName("idx_meet_date_start_reminder");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_meetings_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_meetings_name_del");

                entity.HasIndex(e => new { e.RepeatParentId, e.Deleted })
                    .HasName("idx_meet_repeat_parent_id");

                entity.HasIndex(e => new { e.AssignedUserId, e.Status, e.Deleted })
                    .HasName("idx_meet_stat_del");

                entity.HasIndex(e => new { e.DateStart, e.DateEnd, e.Deleted })
                    .HasName("idx_meet_date_start_end_del");

                entity.HasIndex(e => new { e.ParentId, e.ParentType, e.Deleted })
                    .HasName("idx_meet_par_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Creator)
                    .HasColumnName("creator")
                    .HasMaxLength(50);

                entity.Property(e => e.DateEnd)
                    .HasColumnName("date_end")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateStart)
                    .HasColumnName("date_start")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DisplayedUrl)
                    .HasColumnName("displayed_url")
                    .HasMaxLength(400);

                entity.Property(e => e.DurationHours)
                    .HasColumnName("duration_hours")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DurationMinutes)
                    .HasColumnName("duration_minutes")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailReminderSent)
                    .HasColumnName("email_reminder_sent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailReminderTime)
                    .HasColumnName("email_reminder_time")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.ExternalId)
                    .HasColumnName("external_id")
                    .HasMaxLength(50);

                entity.Property(e => e.HostUrl)
                    .HasColumnName("host_url")
                    .HasMaxLength(600);

                entity.Property(e => e.JoinUrl)
                    .HasColumnName("join_url")
                    .HasMaxLength(600);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.OutlookId)
                    .HasColumnName("outlook_id")
                    .HasMaxLength(255);

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ParentType)
                    .HasColumnName("parent_type")
                    .HasMaxLength(100);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50);

                entity.Property(e => e.RecurrenceId)
                    .HasColumnName("recurrence_id")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.RecurringSource)
                    .HasColumnName("recurring_source")
                    .HasMaxLength(36);

                entity.Property(e => e.ReminderTime)
                    .HasColumnName("reminder_time")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.RepeatCount).HasColumnName("repeat_count");

                entity.Property(e => e.RepeatDays)
                    .HasColumnName("repeat_days")
                    .HasMaxLength(128);

                entity.Property(e => e.RepeatDow)
                    .HasColumnName("repeat_dow")
                    .HasMaxLength(7);

                entity.Property(e => e.RepeatInterval)
                    .HasColumnName("repeat_interval")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RepeatOrdinal)
                    .HasColumnName("repeat_ordinal")
                    .HasMaxLength(36);

                entity.Property(e => e.RepeatParentId)
                    .HasColumnName("repeat_parent_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.RepeatSelector)
                    .HasColumnName("repeat_selector")
                    .HasMaxLength(36);

                entity.Property(e => e.RepeatType)
                    .HasColumnName("repeat_type")
                    .HasMaxLength(36);

                entity.Property(e => e.RepeatUnit)
                    .HasColumnName("repeat_unit")
                    .HasMaxLength(36);

                entity.Property(e => e.RepeatUntil)
                    .HasColumnName("repeat_until")
                    .HasColumnType("date");

                entity.Property(e => e.Sequence)
                    .HasColumnName("sequence")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Planned')");

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'Sugar')");
            });

            modelBuilder.Entity<MeetingsContacts>(entity =>
            {
                entity.ToTable("meetings_contacts", "db_taylormade");

                entity.HasIndex(e => e.ContactId)
                    .HasName("idx_con_mtg_con");

                entity.HasIndex(e => e.MeetingId)
                    .HasName("idx_con_mtg_mtg");

                entity.HasIndex(e => new { e.MeetingId, e.ContactId })
                    .HasName("idx_meeting_contact");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcceptStatus)
                    .HasColumnName("accept_status")
                    .HasMaxLength(25)
                    .HasDefaultValueSql("(N'none')");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MeetingId)
                    .HasColumnName("meeting_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Required)
                    .HasColumnName("required")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'1')");
            });

            modelBuilder.Entity<MeetingsLeads>(entity =>
            {
                entity.ToTable("meetings_leads", "db_taylormade");

                entity.HasIndex(e => e.LeadId)
                    .HasName("idx_lead_meeting_lead");

                entity.HasIndex(e => e.MeetingId)
                    .HasName("idx_lead_meeting_meeting");

                entity.HasIndex(e => new { e.MeetingId, e.LeadId })
                    .HasName("idx_meeting_lead");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcceptStatus)
                    .HasColumnName("accept_status")
                    .HasMaxLength(25)
                    .HasDefaultValueSql("(N'none')");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LeadId)
                    .HasColumnName("lead_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.MeetingId)
                    .HasColumnName("meeting_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Required)
                    .HasColumnName("required")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'1')");
            });

            modelBuilder.Entity<MeetingsUsers>(entity =>
            {
                entity.ToTable("meetings_users", "db_taylormade");

                entity.HasIndex(e => e.MeetingId)
                    .HasName("idx_usr_mtg_mtg");

                entity.HasIndex(e => e.UserId)
                    .HasName("idx_usr_mtg_usr");

                entity.HasIndex(e => new { e.MeetingId, e.UserId })
                    .HasName("idx_meeting_users");

                entity.HasIndex(e => new { e.MeetingId, e.UserId, e.Deleted })
                    .HasName("idx_meeting_users_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcceptStatus)
                    .HasColumnName("accept_status")
                    .HasMaxLength(25)
                    .HasDefaultValueSql("(N'none')");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MeetingId)
                    .HasColumnName("meeting_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Required)
                    .HasColumnName("required")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'1')");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<MetadataCache>(entity =>
            {
                entity.ToTable("metadata_cache", "db_taylormade");

                entity.HasIndex(e => e.Type)
                    .HasName("type_indx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Notes>(entity =>
            {
                entity.ToTable("notes", "db_taylormade");

                entity.HasIndex(e => e.ContactId)
                    .HasName("idx_note_contact");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_notes_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("notesmod");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_note_name");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_notes_tmst_id");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_notes_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_notes_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_notes_name_del");

                entity.HasIndex(e => new { e.ParentId, e.ParentType })
                    .HasName("idx_notes_parent");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EmbedFlag)
                    .HasColumnName("embed_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FileMimeType)
                    .HasColumnName("file_mime_type")
                    .HasMaxLength(100);

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasMaxLength(255);

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ParentType)
                    .HasColumnName("parent_type")
                    .HasMaxLength(255);

                entity.Property(e => e.PortalFlag)
                    .HasColumnName("portal_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.UploadId)
                    .HasColumnName("upload_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<NotesCstm>(entity =>
            {
                entity.HasKey(e => e.IdC);

                entity.ToTable("notes_cstm", "db_taylormade");

                entity.Property(e => e.IdC)
                    .HasColumnName("id_c")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClicktoolsAttachmentC)
                    .HasColumnName("clicktools_attachment_c")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.ToTable("notifications", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_notifications_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("notificationsmod");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_notifications_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_notifications_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_notifications_name_del");

                entity.HasIndex(e => new { e.AssignedUserId, e.IsRead, e.Deleted })
                    .HasName("idx_notifications_my_unread_items");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.IsRead)
                    .HasColumnName("is_read")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ParentType)
                    .HasColumnName("parent_type")
                    .HasMaxLength(100);

                entity.Property(e => e.Severity)
                    .HasColumnName("severity")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<NotificationsAudit>(entity =>
            {
                entity.ToTable("notifications_audit", "db_taylormade");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_notifications_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.AfterValueText).HasColumnName("after_value_text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.BeforeValueText).HasColumnName("before_value_text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<OauthConsumer>(entity =>
            {
                entity.ToTable("oauth_consumer", "db_taylormade");

                entity.HasIndex(e => e.CKey)
                    .HasName("oauth_consumer$ckey")
                    .IsUnique();

                entity.HasIndex(e => e.ClientType)
                    .HasName("idx_oauthkey_client_type");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_oauth_consumer_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("oauth_consumermod");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_oauthkey_name");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_oauth_consumer_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_oauth_consumer_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_oauth_consumer_name_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CKey)
                    .HasColumnName("c_key")
                    .HasMaxLength(255);

                entity.Property(e => e.CSecret)
                    .HasColumnName("c_secret")
                    .HasMaxLength(255);

                entity.Property(e => e.ClientType)
                    .HasColumnName("client_type")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'user')");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.OauthType)
                    .HasColumnName("oauth_type")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'oauth1')");
            });

            modelBuilder.Entity<OauthNonce>(entity =>
            {
                entity.HasKey(e => new { e.Conskey, e.Nonce });

                entity.ToTable("oauth_nonce", "db_taylormade");

                entity.HasIndex(e => new { e.Conskey, e.NonceTs })
                    .HasName("oauth_nonce_keyts");

                entity.Property(e => e.Conskey)
                    .HasColumnName("conskey")
                    .HasMaxLength(32);

                entity.Property(e => e.Nonce)
                    .HasColumnName("nonce")
                    .HasMaxLength(32);

                entity.Property(e => e.NonceTs).HasColumnName("nonce_ts");
            });

            modelBuilder.Entity<OauthTokens>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Deleted });

                entity.ToTable("oauth_tokens", "db_taylormade");

                entity.HasIndex(e => e.Consumer)
                    .HasName("constoken_key");

                entity.HasIndex(e => new { e.Tstate, e.TokenTs })
                    .HasName("oauth_state_ts");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CallbackUrl)
                    .HasColumnName("callback_url")
                    .HasMaxLength(255);

                entity.Property(e => e.Consumer)
                    .IsRequired()
                    .HasColumnName("consumer")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DownloadToken)
                    .HasColumnName("download_token")
                    .HasMaxLength(36);

                entity.Property(e => e.ExpireTs)
                    .HasColumnName("expire_ts")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Platform)
                    .HasColumnName("platform")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'base')");

                entity.Property(e => e.Secret)
                    .HasColumnName("secret")
                    .HasMaxLength(32);

                entity.Property(e => e.TokenTs).HasColumnName("token_ts");

                entity.Property(e => e.Tstate)
                    .HasColumnName("tstate")
                    .HasMaxLength(1);

                entity.Property(e => e.Verify)
                    .HasColumnName("verify")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Opportunities>(entity =>
            {
                entity.ToTable("opportunities", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_opportunity_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("opportunitiesmod");

                entity.HasIndex(e => e.LeadSource)
                    .HasName("idx_opportunity_lead_source");

                entity.HasIndex(e => e.MktoId)
                    .HasName("idx_opportunity_mkto_id");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_opp_name");

                entity.HasIndex(e => e.NextStep)
                    .HasName("idx_opportunity_next_step");

                entity.HasIndex(e => e.OpportunityType)
                    .HasName("idx_opportunity_opportunity_type");

                entity.HasIndex(e => e.SalesStatus)
                    .HasName("idx_opportunity_sales_status");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_opportunities_tmst_id");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_opportunities_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_opp_id_deleted");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_opportunities_name_del");

                entity.HasIndex(e => new { e.AssignedUserId, e.DateClosedTimestamp, e.Deleted })
                    .HasName("idx_opp_assigned_timestamp");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.AmountUsdollar)
                    .HasColumnName("amount_usdollar")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.BaseRate)
                    .HasColumnName("base_rate")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.BestCase)
                    .HasColumnName("best_case")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CommitStage)
                    .HasColumnName("commit_stage")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("currency_id")
                    .HasColumnType("nchar(36)")
                    .HasDefaultValueSql("(N'-99')");

                entity.Property(e => e.DateClosed)
                    .HasColumnName("date_closed")
                    .HasColumnType("date");

                entity.Property(e => e.DateClosedTimestamp)
                    .HasColumnName("date_closed_timestamp")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.LeadSource)
                    .HasColumnName("lead_source")
                    .HasMaxLength(50);

                entity.Property(e => e.MktoId).HasColumnName("mkto_id");

                entity.Property(e => e.MktoSync)
                    .HasColumnName("mkto_sync")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.NextStep)
                    .HasColumnName("next_step")
                    .HasMaxLength(100);

                entity.Property(e => e.OpportunityType)
                    .HasColumnName("opportunity_type")
                    .HasMaxLength(255);

                entity.Property(e => e.Probability).HasColumnName("probability");

                entity.Property(e => e.SalesStage)
                    .HasColumnName("sales_stage")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'Prospecting')");

                entity.Property(e => e.SalesStatus)
                    .HasColumnName("sales_status")
                    .HasMaxLength(255);

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.WorstCase)
                    .HasColumnName("worst_case")
                    .HasColumnType("decimal(26, 6)");
            });

            modelBuilder.Entity<OpportunitiesAudit>(entity =>
            {
                entity.ToTable("opportunities_audit", "db_taylormade");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_opportunities_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.AfterValueText).HasColumnName("after_value_text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.BeforeValueText).HasColumnName("before_value_text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<OpportunitiesContacts>(entity =>
            {
                entity.ToTable("opportunities_contacts", "db_taylormade");

                entity.HasIndex(e => e.ContactId)
                    .HasName("idx_con_opp_con");

                entity.HasIndex(e => e.OpportunityId)
                    .HasName("idx_con_opp_opp");

                entity.HasIndex(e => new { e.OpportunityId, e.ContactId })
                    .HasName("idx_opportunities_contacts");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ContactRole)
                    .HasColumnName("contact_role")
                    .HasMaxLength(50);

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OpportunityId)
                    .HasColumnName("opportunity_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<OpsBackups>(entity =>
            {
                entity.ToTable("ops_backups", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_ops_backups_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("idx_ops_backups_date_modfied");

                entity.HasIndex(e => e.ExpiresAt)
                    .HasName("idx_expires_at");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_ops_backups_id_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DownloadUrl)
                    .HasColumnName("download_url")
                    .HasMaxLength(1024);

                entity.Property(e => e.ExpiresAt)
                    .HasColumnName("expires_at")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<OutboundEmail>(entity =>
            {
                entity.ToTable("outbound_email", "db_taylormade");

                entity.HasIndex(e => new { e.Id, e.UserId })
                    .HasName("oe_user_id_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.MailSendtype)
                    .HasColumnName("mail_sendtype")
                    .HasMaxLength(8)
                    .HasDefaultValueSql("(N'smtp')");

                entity.Property(e => e.MailSmtpauthReq)
                    .HasColumnName("mail_smtpauth_req")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MailSmtppass)
                    .HasColumnName("mail_smtppass")
                    .HasMaxLength(100);

                entity.Property(e => e.MailSmtpport)
                    .HasColumnName("mail_smtpport")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MailSmtpserver)
                    .HasColumnName("mail_smtpserver")
                    .HasMaxLength(100);

                entity.Property(e => e.MailSmtpssl)
                    .HasColumnName("mail_smtpssl")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MailSmtptype)
                    .HasColumnName("mail_smtptype")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'other')");

                entity.Property(e => e.MailSmtpuser)
                    .HasColumnName("mail_smtpuser")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("(N'user')");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("user_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<Pdfmanager>(entity =>
            {
                entity.ToTable("pdfmanager", "db_taylormade");

                entity.HasIndex(e => e.BaseModule)
                    .HasName("idx_pdfmanager_base_module");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_pdfmanager_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("pdfmanagermod");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_pdfmanager_name");

                entity.HasIndex(e => e.Published)
                    .HasName("idx_pdfmanager_published");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_pdfmanager_tmst_id");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_pdfmanager_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_pdfmanager_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_pdfmanager_name_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Author)
                    .HasColumnName("author")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'SugarCRM')");

                entity.Property(e => e.BaseModule)
                    .HasColumnName("base_module")
                    .HasMaxLength(100);

                entity.Property(e => e.BodyHtml).HasColumnName("body_html");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Field)
                    .HasColumnName("field")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'0')");

                entity.Property(e => e.FooterText)
                    .HasColumnName("footer_text")
                    .HasMaxLength(255);

                entity.Property(e => e.HeaderLogo)
                    .HasColumnName("header_logo")
                    .HasMaxLength(255);

                entity.Property(e => e.HeaderText)
                    .HasColumnName("header_text")
                    .HasMaxLength(255);

                entity.Property(e => e.HeaderTitle)
                    .HasColumnName("header_title")
                    .HasMaxLength(255);

                entity.Property(e => e.Keywords)
                    .HasColumnName("keywords")
                    .HasMaxLength(255);

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Published)
                    .HasColumnName("published")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'yes')");

                entity.Property(e => e.Subject)
                    .HasColumnName("subject")
                    .HasMaxLength(255);

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TemplateName)
                    .HasColumnName("template_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<PProductRegistrations>(entity =>
            {
                entity.ToTable("p_product_registrations", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("p_product_registrationsmod");

                entity.HasIndex(e => e.Serial)
                    .HasName("idx_serial");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_p_product_registrations_tmst_id");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_p_product_registrations_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_p_product_registrations_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_name_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.PurchaseDate)
                    .HasColumnName("purchase_date")
                    .HasColumnType("date");

                entity.Property(e => e.Retailer)
                    .HasColumnName("retailer")
                    .HasMaxLength(255);

                entity.Property(e => e.Serial)
                    .HasColumnName("serial")
                    .HasMaxLength(100);

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<PProductRegistrationsAudit>(entity =>
            {
                entity.ToTable("p_product_registrations_audit", "db_taylormade");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_p_product_registrations_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.AfterValueText).HasColumnName("after_value_text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.BeforeValueText).HasColumnName("before_value_text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<PProductRegistrationsCConsumersC>(entity =>
            {
                entity.ToTable("p_product_registrations_c_consumers_c", "db_taylormade");

                entity.HasIndex(e => e.PProductRegistrationsCConsumerscConsumersIda)
                    .HasName("p_product_registrations_c_consumers_ida1");

                entity.HasIndex(e => e.PProductRegistrationsCConsumerspProductRegistrationsIdb)
                    .HasName("p_product_registrations_c_consumers_alt");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(36)
                    .ValueGeneratedNever();

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PProductRegistrationsCConsumerscConsumersIda)
                    .HasColumnName("p_product_registrations_c_consumersc_consumers_ida")
                    .HasMaxLength(36);

                entity.Property(e => e.PProductRegistrationsCConsumerspProductRegistrationsIdb)
                    .HasColumnName("p_product_registrations_c_consumersp_product_registrations_idb")
                    .HasMaxLength(36);
            });

            modelBuilder.Entity<PProductRegistrationsCstm>(entity =>
            {
                entity.HasKey(e => e.IdC);

                entity.ToTable("p_product_registrations_cstm", "db_taylormade");

                entity.Property(e => e.IdC)
                    .HasColumnName("id_c")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.BackTrackC)
                    .HasColumnName("back_track_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BagColorC)
                    .HasColumnName("bag_color_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BagPanelFontC)
                    .HasColumnName("bag_panel_font_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BagPanelNumberC)
                    .HasColumnName("bag_panel_number_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BagPanelSkuC)
                    .HasColumnName("bag_panel_sku_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BagPanelText2C)
                    .HasColumnName("bag_panel_text2_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BagPanelText3C)
                    .HasColumnName("bag_panel_text3_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BagPanelTextC)
                    .HasColumnName("bag_panel_text_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BagQualityC)
                    .HasColumnName("bag_quality_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BagUsageC)
                    .HasColumnName("bag_usage_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CategoryC)
                    .HasColumnName("category_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ClubLengthC)
                    .HasColumnName("club_length_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ClubLieC)
                    .HasColumnName("club_lie_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ClubLoftC)
                    .HasColumnName("club_loft_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ClubSetMakeupC)
                    .HasColumnName("club_set_makeup_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FrontTrackC)
                    .HasColumnName("front_track_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.GripNameC)
                    .HasColumnName("grip_name_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.HandC)
                    .HasColumnName("hand_c")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LogoPositionC)
                    .HasColumnName("logo_position_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PurchasePriceC)
                    .HasColumnName("purchase_price_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PurchasedC)
                    .HasColumnName("purchased_c")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RecommendationC)
                    .HasColumnName("recommendation_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ShaftCompositionC)
                    .HasColumnName("shaft_composition_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShaftNameC)
                    .HasColumnName("shaft_name_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShafttypeprC)
                    .HasColumnName("shafttypepr_c")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SleeveAdjustmentFctC)
                    .HasColumnName("sleeve_adjustment_fct_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SoleAdjustC)
                    .HasColumnName("sole_adjust_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TipAdjustC)
                    .HasColumnName("tip_adjust_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.WeightAdjustmentFctC)
                    .HasColumnName("weight_adjustment_fct_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.WrapNumberC)
                    .HasColumnName("wrap_number_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<ProductBundleNote>(entity =>
            {
                entity.ToTable("product_bundle_note", "db_taylormade");

                entity.HasIndex(e => e.BundleId)
                    .HasName("idx_pbn_bundle");

                entity.HasIndex(e => e.NoteId)
                    .HasName("idx_pbn_note");

                entity.HasIndex(e => new { e.NoteId, e.BundleId })
                    .HasName("idx_pbn_pb_nb");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.BundleId)
                    .HasColumnName("bundle_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NoteId)
                    .HasColumnName("note_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.NoteIndex)
                    .HasColumnName("note_index")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ProductBundleNotes>(entity =>
            {
                entity.ToTable("product_bundle_notes", "db_taylormade");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<ProductBundleProduct>(entity =>
            {
                entity.ToTable("product_bundle_product", "db_taylormade");

                entity.HasIndex(e => e.BundleId)
                    .HasName("idx_pbp_bundle");

                entity.HasIndex(e => e.ProductId)
                    .HasName("idx_pbp_quote");

                entity.HasIndex(e => new { e.ProductId, e.BundleId })
                    .HasName("idx_pbp_bq");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.BundleId)
                    .HasColumnName("bundle_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ProductIndex)
                    .HasColumnName("product_index")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ProductBundleQuote>(entity =>
            {
                entity.ToTable("product_bundle_quote", "db_taylormade");

                entity.HasIndex(e => e.BundleId)
                    .HasName("idx_pbq_bundle");

                entity.HasIndex(e => e.BundleIndex)
                    .HasName("bundle_index_idx");

                entity.HasIndex(e => e.QuoteId)
                    .HasName("idx_pbq_quote");

                entity.HasIndex(e => new { e.QuoteId, e.BundleId })
                    .HasName("idx_pbq_bq");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.BundleId)
                    .HasColumnName("bundle_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.BundleIndex)
                    .HasColumnName("bundle_index")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QuoteId)
                    .HasColumnName("quote_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<ProductBundles>(entity =>
            {
                entity.ToTable("product_bundles", "db_taylormade");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_product_bundles_tmst_id");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_products_bundles");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.BaseRate)
                    .HasColumnName("base_rate")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.BundleStage)
                    .HasColumnName("bundle_stage")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("currency_id")
                    .HasColumnType("nchar(36)")
                    .HasDefaultValueSql("(N'-99')");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DealTot)
                    .HasColumnName("deal_tot")
                    .HasColumnType("decimal(26, 2)");

                entity.Property(e => e.DealTotUsdollar)
                    .HasColumnName("deal_tot_usdollar")
                    .HasColumnType("decimal(26, 2)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.NewSub)
                    .HasColumnName("new_sub")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.NewSubUsdollar)
                    .HasColumnName("new_sub_usdollar")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.Shipping)
                    .HasColumnName("shipping")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.ShippingUsdollar)
                    .HasColumnName("shipping_usdollar")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.Subtotal)
                    .HasColumnName("subtotal")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.SubtotalUsdollar)
                    .HasColumnName("subtotal_usdollar")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.Tax)
                    .HasColumnName("tax")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.TaxUsdollar)
                    .HasColumnName("tax_usdollar")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.TaxrateId)
                    .HasColumnName("taxrate_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Total)
                    .HasColumnName("total")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.TotalUsdollar)
                    .HasColumnName("total_usdollar")
                    .HasColumnType("decimal(26, 6)");
            });

            modelBuilder.Entity<ProductCategories>(entity =>
            {
                entity.ToTable("product_categories", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_product_categories_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("idx_product_categories_date_modfied");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_product_categories_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_product_categories_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_productcategories");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.ListOrder).HasColumnName("list_order");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<ProductProduct>(entity =>
            {
                entity.ToTable("product_product", "db_taylormade");

                entity.HasIndex(e => e.ChildId)
                    .HasName("idx_pp_child");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_pp_parent");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChildId)
                    .HasColumnName("child_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.ToTable("products", "db_taylormade");

                entity.HasIndex(e => e.AccountId)
                    .HasName("idx_product_account");

                entity.HasIndex(e => e.ContactId)
                    .HasName("idx_product_contact");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_products_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("productsmod");

                entity.HasIndex(e => e.OpportunityId)
                    .HasName("idx_product_opp");

                entity.HasIndex(e => e.Quantity)
                    .HasName("idx_product_quantity");

                entity.HasIndex(e => e.QuoteId)
                    .HasName("idx_product_quote");

                entity.HasIndex(e => e.RevenuelineitemId)
                    .HasName("idx_product_rli");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_products_tmst_id");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_products_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_products_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_products");

                entity.HasIndex(e => new { e.Id, e.AssignedUserId, e.DateClosedTimestamp })
                    .HasName("idx_prod_user_dc_timestamp");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.AssetNumber)
                    .HasColumnName("asset_number")
                    .HasMaxLength(50);

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.BaseRate)
                    .HasColumnName("base_rate")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.BookValue)
                    .HasColumnName("book_value")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.BookValueDate)
                    .HasColumnName("book_value_date")
                    .HasColumnType("date");

                entity.Property(e => e.BookValueUsdollar)
                    .HasColumnName("book_value_usdollar")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CostPrice)
                    .HasColumnName("cost_price")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.CostUsdollar)
                    .HasColumnName("cost_usdollar")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("currency_id")
                    .HasColumnType("nchar(36)")
                    .HasDefaultValueSql("(N'-99')");

                entity.Property(e => e.DateClosed)
                    .HasColumnName("date_closed")
                    .HasColumnType("date");

                entity.Property(e => e.DateClosedTimestamp)
                    .HasColumnName("date_closed_timestamp")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DatePurchased)
                    .HasColumnName("date_purchased")
                    .HasColumnType("date");

                entity.Property(e => e.DateSupportExpires)
                    .HasColumnName("date_support_expires")
                    .HasColumnType("date");

                entity.Property(e => e.DateSupportStarts)
                    .HasColumnName("date_support_starts")
                    .HasColumnType("date");

                entity.Property(e => e.DealCalc)
                    .HasColumnName("deal_calc")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.DealCalcUsdollar)
                    .HasColumnName("deal_calc_usdollar")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DiscountAmount)
                    .HasColumnName("discount_amount")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.DiscountAmountUsdollar)
                    .HasColumnName("discount_amount_usdollar")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.DiscountPrice)
                    .HasColumnName("discount_price")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.DiscountRatePercent)
                    .HasColumnName("discount_rate_percent")
                    .HasColumnType("decimal(26, 2)");

                entity.Property(e => e.DiscountSelect).HasColumnName("discount_select");

                entity.Property(e => e.DiscountUsdollar)
                    .HasColumnName("discount_usdollar")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.ListPrice)
                    .HasColumnName("list_price")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.ListUsdollar)
                    .HasColumnName("list_usdollar")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.ManufacturerId)
                    .HasColumnName("manufacturer_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.MftPartNum)
                    .HasColumnName("mft_part_num")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.NextStep)
                    .HasColumnName("next_step")
                    .HasMaxLength(100);

                entity.Property(e => e.OpportunityId)
                    .HasColumnName("opportunity_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.PricingFactor).HasColumnName("pricing_factor");

                entity.Property(e => e.PricingFormula)
                    .HasColumnName("pricing_formula")
                    .HasMaxLength(100);

                entity.Property(e => e.ProductTemplateId)
                    .HasColumnName("product_template_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((1.00))");

                entity.Property(e => e.QuoteId)
                    .HasColumnName("quote_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.RevenuelineitemId)
                    .HasColumnName("revenuelineitem_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.SerialNumber)
                    .HasColumnName("serial_number")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(100);

                entity.Property(e => e.Subtotal)
                    .HasColumnName("subtotal")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.SupportContact)
                    .HasColumnName("support_contact")
                    .HasMaxLength(50);

                entity.Property(e => e.SupportDescription)
                    .HasColumnName("support_description")
                    .HasMaxLength(255);

                entity.Property(e => e.SupportName)
                    .HasColumnName("support_name")
                    .HasMaxLength(50);

                entity.Property(e => e.SupportTerm)
                    .HasColumnName("support_term")
                    .HasMaxLength(100);

                entity.Property(e => e.TaxClass)
                    .HasColumnName("tax_class")
                    .HasMaxLength(100);

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TotalAmount)
                    .HasColumnName("total_amount")
                    .HasColumnType("decimal(26, 6)")
                    .HasDefaultValueSql("((0.000000))");

                entity.Property(e => e.TypeId)
                    .HasColumnName("type_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.VendorPartNum)
                    .HasColumnName("vendor_part_num")
                    .HasMaxLength(50);

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(255);

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("decimal(12, 2)");
            });

            modelBuilder.Entity<ProductsAudit>(entity =>
            {
                entity.ToTable("products_audit", "db_taylormade");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_products_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.AfterValueText).HasColumnName("after_value_text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.BeforeValueText).HasColumnName("before_value_text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<ProductTemplates>(entity =>
            {
                entity.ToTable("product_templates", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_product_templates_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("idx_product_templates_date_modfied");

                entity.HasIndex(e => e.QtyInStock)
                    .HasName("idx_producttemplate_qty_in_stock");

                entity.HasIndex(e => e.Status)
                    .HasName("idx_producttemplate_status");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_product_templates_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_product_templates_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_product_template");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.BaseRate)
                    .HasColumnName("base_rate")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CostPrice)
                    .HasColumnName("cost_price")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.CostUsdollar)
                    .HasColumnName("cost_usdollar")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Currency)
                    .HasColumnName("currency")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("currency_id")
                    .HasColumnType("nchar(36)")
                    .HasDefaultValueSql("(N'-99')");

                entity.Property(e => e.DateAvailable)
                    .HasColumnName("date_available")
                    .HasColumnType("date");

                entity.Property(e => e.DateCostPrice)
                    .HasColumnName("date_cost_price")
                    .HasColumnType("date");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DiscountPrice)
                    .HasColumnName("discount_price")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.DiscountUsdollar)
                    .HasColumnName("discount_usdollar")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.ListPrice)
                    .HasColumnName("list_price")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.ListUsdollar)
                    .HasColumnName("list_usdollar")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.ManufacturerId)
                    .HasColumnName("manufacturer_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.MftPartNum)
                    .HasColumnName("mft_part_num")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.PricingFactor)
                    .HasColumnName("pricing_factor")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.PricingFormula)
                    .HasColumnName("pricing_formula")
                    .HasMaxLength(100);

                entity.Property(e => e.QtyInStock).HasColumnName("qty_in_stock");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(100);

                entity.Property(e => e.SupportContact)
                    .HasColumnName("support_contact")
                    .HasMaxLength(50);

                entity.Property(e => e.SupportDescription)
                    .HasColumnName("support_description")
                    .HasMaxLength(255);

                entity.Property(e => e.SupportName)
                    .HasColumnName("support_name")
                    .HasMaxLength(50);

                entity.Property(e => e.SupportTerm)
                    .HasColumnName("support_term")
                    .HasMaxLength(100);

                entity.Property(e => e.TaxClass)
                    .HasColumnName("tax_class")
                    .HasMaxLength(100);

                entity.Property(e => e.TypeId)
                    .HasColumnName("type_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.VendorPartNum)
                    .HasColumnName("vendor_part_num")
                    .HasMaxLength(50);

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(255);

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("decimal(12, 2)");
            });

            modelBuilder.Entity<ProductTemplatesAudit>(entity =>
            {
                entity.ToTable("product_templates_audit", "db_taylormade");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_product_templates_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.AfterValueText).HasColumnName("after_value_text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.BeforeValueText).HasColumnName("before_value_text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<ProductTypes>(entity =>
            {
                entity.ToTable("product_types", "db_taylormade");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_producttypes");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.ListOrder).HasColumnName("list_order");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("project", "db_taylormade");

                entity.HasIndex(e => e.EstimatedEndDate)
                    .HasName("idx_project_estimated_end_date");

                entity.HasIndex(e => e.EstimatedStartDate)
                    .HasName("idx_project_estimated_start_date");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_project_name");

                entity.HasIndex(e => e.Status)
                    .HasName("idx_project_status");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_project_tmst_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EstimatedEndDate)
                    .HasColumnName("estimated_end_date")
                    .HasColumnType("date");

                entity.Property(e => e.EstimatedStartDate)
                    .HasColumnName("estimated_start_date")
                    .HasColumnType("date");

                entity.Property(e => e.IsTemplate)
                    .HasColumnName("is_template")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(255);

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<ProjectResources>(entity =>
            {
                entity.ToTable("project_resources", "db_taylormade");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ResourceId)
                    .HasColumnName("resource_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ResourceType)
                    .HasColumnName("resource_type")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ProjectsAccounts>(entity =>
            {
                entity.ToTable("projects_accounts", "db_taylormade");

                entity.HasIndex(e => e.AccountId)
                    .HasName("idx_proj_acct_acct");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("idx_proj_acct_proj");

                entity.HasIndex(e => new { e.ProjectId, e.AccountId })
                    .HasName("projects_accounts_alt");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<ProjectsBugs>(entity =>
            {
                entity.ToTable("projects_bugs", "db_taylormade");

                entity.HasIndex(e => e.BugId)
                    .HasName("idx_proj_bug_bug");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("idx_proj_bug_proj");

                entity.HasIndex(e => new { e.ProjectId, e.BugId })
                    .HasName("projects_bugs_alt");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.BugId)
                    .HasColumnName("bug_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<ProjectsCases>(entity =>
            {
                entity.ToTable("projects_cases", "db_taylormade");

                entity.HasIndex(e => e.CaseId)
                    .HasName("idx_proj_case_case");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("idx_proj_case_proj");

                entity.HasIndex(e => new { e.ProjectId, e.CaseId })
                    .HasName("projects_cases_alt");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CaseId)
                    .HasColumnName("case_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<ProjectsContacts>(entity =>
            {
                entity.ToTable("projects_contacts", "db_taylormade");

                entity.HasIndex(e => e.ContactId)
                    .HasName("idx_proj_con_con");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("idx_proj_con_proj");

                entity.HasIndex(e => new { e.ProjectId, e.ContactId })
                    .HasName("projects_contacts_alt");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<ProjectsOpportunities>(entity =>
            {
                entity.ToTable("projects_opportunities", "db_taylormade");

                entity.HasIndex(e => e.OpportunityId)
                    .HasName("idx_proj_opp_opp");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("idx_proj_opp_proj");

                entity.HasIndex(e => new { e.ProjectId, e.OpportunityId })
                    .HasName("projects_opportunities_alt");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OpportunityId)
                    .HasColumnName("opportunity_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<ProjectsProducts>(entity =>
            {
                entity.ToTable("projects_products", "db_taylormade");

                entity.HasIndex(e => e.ProductId)
                    .HasName("idx_proj_prod_product");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("idx_proj_prod_project");

                entity.HasIndex(e => new { e.ProjectId, e.ProductId })
                    .HasName("projects_products_alt");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<ProjectsQuotes>(entity =>
            {
                entity.ToTable("projects_quotes", "db_taylormade");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("idx_proj_quote_proj");

                entity.HasIndex(e => e.QuoteId)
                    .HasName("idx_proj_quote_quote");

                entity.HasIndex(e => new { e.ProjectId, e.QuoteId })
                    .HasName("projects_quotes_alt");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.QuoteId)
                    .HasColumnName("quote_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<ProjectsRevenueLineItems>(entity =>
            {
                entity.ToTable("projects_revenue_line_items", "db_taylormade");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("idx_proj_rli_project");

                entity.HasIndex(e => e.RliId)
                    .HasName("idx_proj_rli_product");

                entity.HasIndex(e => new { e.ProjectId, e.RliId })
                    .HasName("projects_rli_alt");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.RliId)
                    .HasColumnName("rli_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<ProjectTask>(entity =>
            {
                entity.ToTable("project_task", "db_taylormade");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_project_task_tmst_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActualDuration).HasColumnName("actual_duration");

                entity.Property(e => e.ActualEffort).HasColumnName("actual_effort");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateDue)
                    .HasColumnName("date_due")
                    .HasColumnType("date");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateFinish)
                    .HasColumnName("date_finish")
                    .HasColumnType("date");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateStart)
                    .HasColumnName("date_start")
                    .HasColumnType("date");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.DurationUnit).HasColumnName("duration_unit");

                entity.Property(e => e.EstimatedEffort).HasColumnName("estimated_effort");

                entity.Property(e => e.MilestoneFlag).HasColumnName("milestone_flag");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("order_number")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ParentTaskId).HasColumnName("parent_task_id");

                entity.Property(e => e.PercentComplete).HasColumnName("percent_complete");

                entity.Property(e => e.Predecessors).HasColumnName("predecessors");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasMaxLength(255);

                entity.Property(e => e.ProjectId)
                    .IsRequired()
                    .HasColumnName("project_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ProjectTaskId).HasColumnName("project_task_id");

                entity.Property(e => e.ResourceId).HasColumnName("resource_id");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(255);

                entity.Property(e => e.TaskNumber).HasColumnName("task_number");

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TimeDue).HasColumnName("time_due");

                entity.Property(e => e.TimeFinish).HasColumnName("time_finish");

                entity.Property(e => e.TimeStart).HasColumnName("time_start");

                entity.Property(e => e.Utilization)
                    .HasColumnName("utilization")
                    .HasDefaultValueSql("((100))");
            });

            modelBuilder.Entity<ProjectTaskAudit>(entity =>
            {
                entity.ToTable("project_task_audit", "db_taylormade");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_project_task_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.AfterValueText).HasColumnName("after_value_text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.BeforeValueText).HasColumnName("before_value_text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<ProspectListCampaigns>(entity =>
            {
                entity.ToTable("prospect_list_campaigns", "db_taylormade");

                entity.HasIndex(e => e.CampaignId)
                    .HasName("idx_cam_id");

                entity.HasIndex(e => e.ProspectListId)
                    .HasName("idx_pro_id");

                entity.HasIndex(e => new { e.ProspectListId, e.CampaignId })
                    .HasName("idx_prospect_list_campaigns");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProspectListId)
                    .HasColumnName("prospect_list_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<ProspectLists>(entity =>
            {
                entity.ToTable("prospect_lists", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_prospect_list_date_entered");

                entity.HasIndex(e => e.ListType)
                    .HasName("idx_prospect_list_list_type");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_prospect_list_name");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_prospect_lists_tmst_id");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_prospect_lists_assigned_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DomainName)
                    .HasColumnName("domain_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ListType)
                    .HasColumnName("list_type")
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<ProspectListsProspects>(entity =>
            {
                entity.ToTable("prospect_lists_prospects", "db_taylormade");

                entity.HasIndex(e => e.ProspectListId)
                    .HasName("idx_plp_pro_id");

                entity.HasIndex(e => new { e.RelatedId, e.RelatedType, e.ProspectListId })
                    .HasName("idx_plp_rel_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProspectListId)
                    .HasColumnName("prospect_list_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.RelatedId)
                    .HasColumnName("related_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.RelatedType)
                    .HasColumnName("related_type")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<Prospects>(entity =>
            {
                entity.ToTable("prospects", "db_taylormade");

                entity.HasIndex(e => e.AssignedUserId)
                    .HasName("idx_prospects_assigned");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_prospect_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("prospectsmod");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_prospects_tmst_id");

                entity.HasIndex(e => e.Title)
                    .HasName("idx_prospect_title");

                entity.HasIndex(e => e.TrackerKey)
                    .HasName("prospect_auto_tracker_key");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_prospects_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_prospects_id_del");

                entity.HasIndex(e => new { e.LastName, e.Deleted })
                    .HasName("idx_prospecs_del_last");

                entity.HasIndex(e => new { e.FirstName, e.LastName, e.Deleted })
                    .HasName("idx_prospects_first_last");

                entity.HasIndex(e => new { e.LastName, e.FirstName, e.Deleted })
                    .HasName("idx_prospects_last_first");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(150);

                entity.Property(e => e.AltAddressCity)
                    .HasColumnName("alt_address_city")
                    .HasMaxLength(100);

                entity.Property(e => e.AltAddressCountry)
                    .HasColumnName("alt_address_country")
                    .HasMaxLength(255);

                entity.Property(e => e.AltAddressPostalcode)
                    .HasColumnName("alt_address_postalcode")
                    .HasMaxLength(20);

                entity.Property(e => e.AltAddressState)
                    .HasColumnName("alt_address_state")
                    .HasMaxLength(100);

                entity.Property(e => e.AltAddressStreet)
                    .HasColumnName("alt_address_street")
                    .HasMaxLength(150);

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Assistant)
                    .HasColumnName("assistant")
                    .HasMaxLength(75);

                entity.Property(e => e.AssistantPhone)
                    .HasColumnName("assistant_phone")
                    .HasMaxLength(100);

                entity.Property(e => e.Birthdate)
                    .HasColumnName("birthdate")
                    .HasColumnType("date");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Department)
                    .HasColumnName("department")
                    .HasMaxLength(255);

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DnbPrincipalId)
                    .HasColumnName("dnb_principal_id")
                    .HasMaxLength(30);

                entity.Property(e => e.DoNotCall)
                    .HasColumnName("do_not_call")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Facebook)
                    .HasColumnName("facebook")
                    .HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(100);

                entity.Property(e => e.Googleplus)
                    .HasColumnName("googleplus")
                    .HasMaxLength(100);

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(100);

                entity.Property(e => e.LeadId)
                    .HasColumnName("lead_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.PhoneFax)
                    .HasColumnName("phone_fax")
                    .HasMaxLength(100);

                entity.Property(e => e.PhoneHome)
                    .HasColumnName("phone_home")
                    .HasMaxLength(100);

                entity.Property(e => e.PhoneMobile)
                    .HasColumnName("phone_mobile")
                    .HasMaxLength(100);

                entity.Property(e => e.PhoneOther)
                    .HasColumnName("phone_other")
                    .HasMaxLength(100);

                entity.Property(e => e.PhoneWork)
                    .HasColumnName("phone_work")
                    .HasMaxLength(100);

                entity.Property(e => e.Picture)
                    .HasColumnName("picture")
                    .HasMaxLength(255);

                entity.Property(e => e.PrimaryAddressCity)
                    .HasColumnName("primary_address_city")
                    .HasMaxLength(100);

                entity.Property(e => e.PrimaryAddressCountry)
                    .HasColumnName("primary_address_country")
                    .HasMaxLength(255);

                entity.Property(e => e.PrimaryAddressPostalcode)
                    .HasColumnName("primary_address_postalcode")
                    .HasMaxLength(20);

                entity.Property(e => e.PrimaryAddressState)
                    .HasColumnName("primary_address_state")
                    .HasMaxLength(100);

                entity.Property(e => e.PrimaryAddressStreet)
                    .HasColumnName("primary_address_street")
                    .HasMaxLength(150);

                entity.Property(e => e.Salutation)
                    .HasColumnName("salutation")
                    .HasMaxLength(255);

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100);

                entity.Property(e => e.TrackerKey)
                    .HasColumnName("tracker_key")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Twitter)
                    .HasColumnName("twitter")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Quotas>(entity =>
            {
                entity.ToTable("quotas", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_quotas_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("idx_quotas_date_modfied");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_quotas_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_quotas_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_quotas_name_del");

                entity.HasIndex(e => new { e.UserId, e.TimeperiodId })
                    .HasName("idx_quota_user_tp");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.AmountBaseCurrency)
                    .HasColumnName("amount_base_currency")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.BaseRate)
                    .HasColumnName("base_rate")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.Committed)
                    .HasColumnName("committed")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("currency_id")
                    .HasColumnType("nchar(36)")
                    .HasDefaultValueSql("(N'-99')");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.QuotaType)
                    .HasColumnName("quota_type")
                    .HasMaxLength(100);

                entity.Property(e => e.TimeperiodId)
                    .HasColumnName("timeperiod_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<QuotasAudit>(entity =>
            {
                entity.ToTable("quotas_audit", "db_taylormade");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_quotas_audit_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.AfterValueText).HasColumnName("after_value_text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.BeforeValueText).HasColumnName("before_value_text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<Quotes>(entity =>
            {
                entity.ToTable("quotes", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_quote_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("quotesmod");

                entity.HasIndex(e => e.DateQuoteExpectedClosed)
                    .HasName("idx_quote_date_quote_expected_closed");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_qte_name");

                entity.HasIndex(e => e.QuoteStage)
                    .HasName("idx_quote_quote_stage");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_quotes_tmst_id");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_quotes_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_quotes_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_quotes_name_del");

                entity.HasIndex(e => new { e.QuoteNum, e.SystemId })
                    .HasName("quotes$quote_num")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.BaseRate)
                    .HasColumnName("base_rate")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.BillingAddressCity)
                    .HasColumnName("billing_address_city")
                    .HasMaxLength(100);

                entity.Property(e => e.BillingAddressCountry)
                    .HasColumnName("billing_address_country")
                    .HasMaxLength(100);

                entity.Property(e => e.BillingAddressPostalcode)
                    .HasColumnName("billing_address_postalcode")
                    .HasMaxLength(20);

                entity.Property(e => e.BillingAddressState)
                    .HasColumnName("billing_address_state")
                    .HasMaxLength(100);

                entity.Property(e => e.BillingAddressStreet)
                    .HasColumnName("billing_address_street")
                    .HasMaxLength(150);

                entity.Property(e => e.CalcGrandTotal)
                    .HasColumnName("calc_grand_total")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("currency_id")
                    .HasColumnType("nchar(36)")
                    .HasDefaultValueSql("(N'-99')");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateOrderShipped)
                    .HasColumnName("date_order_shipped")
                    .HasColumnType("date");

                entity.Property(e => e.DateQuoteClosed)
                    .HasColumnName("date_quote_closed")
                    .HasColumnType("date");

                entity.Property(e => e.DateQuoteExpectedClosed)
                    .HasColumnName("date_quote_expected_closed")
                    .HasColumnType("date");

                entity.Property(e => e.DealTot)
                    .HasColumnName("deal_tot")
                    .HasColumnType("decimal(26, 2)");

                entity.Property(e => e.DealTotUsdollar)
                    .HasColumnName("deal_tot_usdollar")
                    .HasColumnType("decimal(26, 2)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Discount)
                    .HasColumnName("discount")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.NewSub)
                    .HasColumnName("new_sub")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.NewSubUsdollar)
                    .HasColumnName("new_sub_usdollar")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.OrderStage)
                    .HasColumnName("order_stage")
                    .HasMaxLength(100);

                entity.Property(e => e.OriginalPoDate)
                    .HasColumnName("original_po_date")
                    .HasColumnType("date");

                entity.Property(e => e.PaymentTerms)
                    .HasColumnName("payment_terms")
                    .HasMaxLength(128);

                entity.Property(e => e.PurchaseOrderNum)
                    .HasColumnName("purchase_order_num")
                    .HasMaxLength(50);

                entity.Property(e => e.QuoteNum)
                    .HasColumnName("quote_num")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.QuoteStage)
                    .HasColumnName("quote_stage")
                    .HasMaxLength(100);

                entity.Property(e => e.QuoteType)
                    .HasColumnName("quote_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ShipperId)
                    .HasColumnName("shipper_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Shipping)
                    .HasColumnName("shipping")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.ShippingAddressCity)
                    .HasColumnName("shipping_address_city")
                    .HasMaxLength(100);

                entity.Property(e => e.ShippingAddressCountry)
                    .HasColumnName("shipping_address_country")
                    .HasMaxLength(100);

                entity.Property(e => e.ShippingAddressPostalcode)
                    .HasColumnName("shipping_address_postalcode")
                    .HasMaxLength(20);

                entity.Property(e => e.ShippingAddressState)
                    .HasColumnName("shipping_address_state")
                    .HasMaxLength(100);

                entity.Property(e => e.ShippingAddressStreet)
                    .HasColumnName("shipping_address_street")
                    .HasMaxLength(150);

                entity.Property(e => e.ShippingUsdollar)
                    .HasColumnName("shipping_usdollar")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.ShowLineNums)
                    .HasColumnName("show_line_nums")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Subtotal)
                    .HasColumnName("subtotal")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.SubtotalUsdollar)
                    .HasColumnName("subtotal_usdollar")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.SystemId).HasColumnName("system_id");

                entity.Property(e => e.Tax)
                    .HasColumnName("tax")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.TaxUsdollar)
                    .HasColumnName("tax_usdollar")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.TaxrateId)
                    .HasColumnName("taxrate_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Total)
                    .HasColumnName("total")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.TotalUsdollar)
                    .HasColumnName("total_usdollar")
                    .HasColumnType("decimal(26, 6)");
            });

            modelBuilder.Entity<QuotesAccounts>(entity =>
            {
                entity.ToTable("quotes_accounts", "db_taylormade");

                entity.HasIndex(e => e.AccountId)
                    .HasName("idx_acc_qte_acc");

                entity.HasIndex(e => e.QuoteId)
                    .HasName("idx_acc_qte_opp");

                entity.HasIndex(e => new { e.QuoteId, e.AccountRole })
                    .HasName("idx_quote_account_role");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.AccountRole)
                    .HasColumnName("account_role")
                    .HasMaxLength(20);

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QuoteId)
                    .HasColumnName("quote_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<QuotesAudit>(entity =>
            {
                entity.ToTable("quotes_audit", "db_taylormade");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_quotes_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.AfterValueText).HasColumnName("after_value_text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.BeforeValueText).HasColumnName("before_value_text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<QuotesContacts>(entity =>
            {
                entity.ToTable("quotes_contacts", "db_taylormade");

                entity.HasIndex(e => e.ContactId)
                    .HasName("idx_con_qte_con");

                entity.HasIndex(e => e.QuoteId)
                    .HasName("idx_con_qte_opp");

                entity.HasIndex(e => new { e.QuoteId, e.ContactRole })
                    .HasName("idx_quote_contact_role");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ContactRole)
                    .HasColumnName("contact_role")
                    .HasMaxLength(20);

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QuoteId)
                    .HasColumnName("quote_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<QuotesOpportunities>(entity =>
            {
                entity.ToTable("quotes_opportunities", "db_taylormade");

                entity.HasIndex(e => e.OpportunityId)
                    .HasName("idx_opp_qte_opp");

                entity.HasIndex(e => e.QuoteId)
                    .HasName("idx_quote_oportunities");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OpportunityId)
                    .HasColumnName("opportunity_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.QuoteId)
                    .HasColumnName("quote_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<RecordList>(entity =>
            {
                entity.ToTable("record_list", "db_taylormade");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .IsRequired()
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.ModuleName)
                    .HasColumnName("module_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Records).HasColumnName("records");
            });

            modelBuilder.Entity<Relationships>(entity =>
            {
                entity.ToTable("relationships", "db_taylormade");

                entity.HasIndex(e => e.RelationshipName)
                    .HasName("idx_rel_name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JoinKeyLhs)
                    .HasColumnName("join_key_lhs")
                    .HasMaxLength(128);

                entity.Property(e => e.JoinKeyRhs)
                    .HasColumnName("join_key_rhs")
                    .HasMaxLength(128);

                entity.Property(e => e.JoinTable)
                    .HasColumnName("join_table")
                    .HasMaxLength(128);

                entity.Property(e => e.LhsKey)
                    .HasColumnName("lhs_key")
                    .HasMaxLength(64);

                entity.Property(e => e.LhsModule)
                    .HasColumnName("lhs_module")
                    .HasMaxLength(100);

                entity.Property(e => e.LhsTable)
                    .HasColumnName("lhs_table")
                    .HasMaxLength(64);

                entity.Property(e => e.LhsVname)
                    .HasColumnName("lhs_vname")
                    .HasMaxLength(64);

                entity.Property(e => e.RelationshipName)
                    .HasColumnName("relationship_name")
                    .HasMaxLength(150);

                entity.Property(e => e.RelationshipRoleColumn)
                    .HasColumnName("relationship_role_column")
                    .HasMaxLength(64);

                entity.Property(e => e.RelationshipRoleColumnValue)
                    .HasColumnName("relationship_role_column_value")
                    .HasMaxLength(50);

                entity.Property(e => e.RelationshipType)
                    .HasColumnName("relationship_type")
                    .HasMaxLength(64);

                entity.Property(e => e.Reverse)
                    .HasColumnName("reverse")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RhsKey)
                    .HasColumnName("rhs_key")
                    .HasMaxLength(64);

                entity.Property(e => e.RhsModule)
                    .HasColumnName("rhs_module")
                    .HasMaxLength(100);

                entity.Property(e => e.RhsTable)
                    .HasColumnName("rhs_table")
                    .HasMaxLength(64);

                entity.Property(e => e.RhsVname)
                    .HasColumnName("rhs_vname")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<Releases>(entity =>
            {
                entity.ToTable("releases", "db_taylormade");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_releases");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.ListOrder).HasColumnName("list_order");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ReportCache>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.AssignedUserId });

                entity.ToTable("report_cache", "db_taylormade");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Contents).HasColumnName("contents");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasMaxLength(1);

                entity.Property(e => e.ReportOptions).HasColumnName("report_options");
            });

            modelBuilder.Entity<ReportSchedules>(entity =>
            {
                entity.ToTable("report_schedules", "db_taylormade");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateStart)
                    .HasColumnName("date_start")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NextRun)
                    .HasColumnName("next_run")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.ReportId)
                    .HasColumnName("report_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ScheduleType)
                    .HasColumnName("schedule_type")
                    .HasMaxLength(3);

                entity.Property(e => e.TimeInterval).HasColumnName("time_interval");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<RevenueLineItems>(entity =>
            {
                entity.ToTable("revenue_line_items", "db_taylormade");

                entity.HasIndex(e => e.CommitStage)
                    .HasName("idx_revenuelineitem_commit_stage");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_revenue_line_items_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("revenue_line_itemsmod");

                entity.HasIndex(e => e.OpportunityId)
                    .HasName("idx_revenuelineitem_oppid");

                entity.HasIndex(e => e.Probability)
                    .HasName("idx_revenuelineitem_probability");

                entity.HasIndex(e => e.Quantity)
                    .HasName("idx_revenuelineitem_quantity");

                entity.HasIndex(e => e.SalesStage)
                    .HasName("idx_revenuelineitem_sales_stage");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_revenue_line_items_tmst_id");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_revenue_line_items_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_revenue_line_items_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_revenuelineitem");

                entity.HasIndex(e => new { e.Id, e.AssignedUserId, e.DateClosedTimestamp })
                    .HasName("idx_rli_user_dc_timestamp");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.AssetNumber)
                    .HasColumnName("asset_number")
                    .HasMaxLength(50);

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.BaseRate)
                    .HasColumnName("base_rate")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.BestCase)
                    .HasColumnName("best_case")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.BookValue)
                    .HasColumnName("book_value")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.BookValueDate)
                    .HasColumnName("book_value_date")
                    .HasColumnType("date");

                entity.Property(e => e.BookValueUsdollar)
                    .HasColumnName("book_value_usdollar")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CommitStage)
                    .HasColumnName("commit_stage")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'exclude')");

                entity.Property(e => e.CostPrice)
                    .HasColumnName("cost_price")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.CostUsdollar)
                    .HasColumnName("cost_usdollar")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("currency_id")
                    .HasColumnType("nchar(36)")
                    .HasDefaultValueSql("(N'-99')");

                entity.Property(e => e.DateClosed)
                    .HasColumnName("date_closed")
                    .HasColumnType("date");

                entity.Property(e => e.DateClosedTimestamp)
                    .HasColumnName("date_closed_timestamp")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DatePurchased)
                    .HasColumnName("date_purchased")
                    .HasColumnType("date");

                entity.Property(e => e.DateSupportExpires)
                    .HasColumnName("date_support_expires")
                    .HasColumnType("date");

                entity.Property(e => e.DateSupportStarts)
                    .HasColumnName("date_support_starts")
                    .HasColumnType("date");

                entity.Property(e => e.DealCalc)
                    .HasColumnName("deal_calc")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.DealCalcUsdollar)
                    .HasColumnName("deal_calc_usdollar")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DiscountAmount)
                    .HasColumnName("discount_amount")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.DiscountAmountUsdollar)
                    .HasColumnName("discount_amount_usdollar")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.DiscountPrice)
                    .HasColumnName("discount_price")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.DiscountRatePercent)
                    .HasColumnName("discount_rate_percent")
                    .HasColumnType("decimal(27, 2)");

                entity.Property(e => e.DiscountSelect).HasColumnName("discount_select");

                entity.Property(e => e.DiscountUsdollar)
                    .HasColumnName("discount_usdollar")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.LeadSource)
                    .HasColumnName("lead_source")
                    .HasMaxLength(50);

                entity.Property(e => e.LikelyCase)
                    .HasColumnName("likely_case")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.ListPrice)
                    .HasColumnName("list_price")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.ListUsdollar)
                    .HasColumnName("list_usdollar")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.ManufacturerId)
                    .HasColumnName("manufacturer_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.MftPartNum)
                    .HasColumnName("mft_part_num")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.NextStep)
                    .HasColumnName("next_step")
                    .HasMaxLength(100);

                entity.Property(e => e.OpportunityId)
                    .HasColumnName("opportunity_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.PricingFactor).HasColumnName("pricing_factor");

                entity.Property(e => e.PricingFormula)
                    .HasColumnName("pricing_formula")
                    .HasMaxLength(100);

                entity.Property(e => e.Probability).HasColumnName("probability");

                entity.Property(e => e.ProductTemplateId)
                    .HasColumnName("product_template_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ProductType)
                    .HasColumnName("product_type")
                    .HasMaxLength(255);

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((1.00))");

                entity.Property(e => e.QuoteId)
                    .HasColumnName("quote_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.SalesStage)
                    .HasColumnName("sales_stage")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'Prospecting')");

                entity.Property(e => e.SerialNumber)
                    .HasColumnName("serial_number")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(100);

                entity.Property(e => e.SupportContact)
                    .HasColumnName("support_contact")
                    .HasMaxLength(50);

                entity.Property(e => e.SupportDescription)
                    .HasColumnName("support_description")
                    .HasMaxLength(255);

                entity.Property(e => e.SupportName)
                    .HasColumnName("support_name")
                    .HasMaxLength(50);

                entity.Property(e => e.SupportTerm)
                    .HasColumnName("support_term")
                    .HasMaxLength(100);

                entity.Property(e => e.TaxClass)
                    .HasColumnName("tax_class")
                    .HasMaxLength(100);

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TotalAmount)
                    .HasColumnName("total_amount")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.TypeId)
                    .HasColumnName("type_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.VendorPartNum)
                    .HasColumnName("vendor_part_num")
                    .HasMaxLength(50);

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(255);

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.WorstCase)
                    .HasColumnName("worst_case")
                    .HasColumnType("decimal(26, 6)");
            });

            modelBuilder.Entity<RevenueLineItemsAudit>(entity =>
            {
                entity.ToTable("revenue_line_items_audit", "db_taylormade");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_revenue_line_items_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.AfterValueText).HasColumnName("after_value_text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.BeforeValueText).HasColumnName("before_value_text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.ToTable("roles", "db_taylormade");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_role_name");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_role_id_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Modules).HasColumnName("modules");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<RolesModules>(entity =>
            {
                entity.ToTable("roles_modules", "db_taylormade");

                entity.HasIndex(e => e.ModuleId)
                    .HasName("idx_module_id");

                entity.HasIndex(e => e.RoleId)
                    .HasName("idx_role_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Allow)
                    .HasColumnName("allow")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModuleId)
                    .HasColumnName("module_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.RoleId)
                    .HasColumnName("role_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<RolesUsers>(entity =>
            {
                entity.ToTable("roles_users", "db_taylormade");

                entity.HasIndex(e => e.RoleId)
                    .HasName("idx_ru_role_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("idx_ru_user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RoleId)
                    .HasColumnName("role_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<RRetailDemoDays>(entity =>
            {
                entity.ToTable("r_retail_demo_days", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_r_retail_demo_days_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("r_retail_demo_daysmod");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_r_retail_demo_days_tmst_id");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_r_retail_demo_days_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_r_retail_demo_days_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_r_retail_demo_days_name_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EventDate)
                    .HasColumnName("event_date")
                    .HasColumnType("date");

                entity.Property(e => e.EventHours)
                    .HasColumnName("event_hours")
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<RRetailDemoDaysAudit>(entity =>
            {
                entity.ToTable("r_retail_demo_days_audit", "db_taylormade");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_r_retail_demo_days_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.AfterValueText).HasColumnName("after_value_text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.BeforeValueText).HasColumnName("before_value_text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<SavedReports>(entity =>
            {
                entity.ToTable("saved_reports", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_savedreport_date_entered");

                entity.HasIndex(e => e.Module)
                    .HasName("idx_savedreport_module");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_saved_reports_tmst_id");

                entity.HasIndex(e => new { e.AssignedUserId, e.Name, e.Deleted })
                    .HasName("idx_rep_owner_module_name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ChartType)
                    .HasColumnName("chart_type")
                    .HasMaxLength(36)
                    .HasDefaultValueSql("(N'none')");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Favorite).HasColumnName("favorite");

                entity.Property(e => e.IsPublished)
                    .HasColumnName("is_published")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Module)
                    .HasColumnName("module")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.ReportType)
                    .HasColumnName("report_type")
                    .HasMaxLength(255);

                entity.Property(e => e.ScheduleType)
                    .HasColumnName("schedule_type")
                    .HasMaxLength(3)
                    .HasDefaultValueSql("(N'pro')");

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<SavedSearch>(entity =>
            {
                entity.ToTable("saved_search", "db_taylormade");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_saved_search_tmst_id");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_desc");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Contents).HasColumnName("contents");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(150);

                entity.Property(e => e.SearchModule)
                    .HasColumnName("search_module")
                    .HasMaxLength(150);

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<Schedulers>(entity =>
            {
                entity.ToTable("schedulers", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_schedulers_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("schedulersmod");

                entity.HasIndex(e => e.JobInterval)
                    .HasName("idx_scheduler_job_interval");

                entity.HasIndex(e => e.Status)
                    .HasName("idx_scheduler_status");

                entity.HasIndex(e => new { e.DateTimeStart, e.Deleted })
                    .HasName("idx_schedule");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_schedulers_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_schedulers_name_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CatchUp)
                    .HasColumnName("catch_up")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateTimeEnd)
                    .HasColumnName("date_time_end")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateTimeStart)
                    .HasColumnName("date_time_start")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Job)
                    .HasColumnName("job")
                    .HasMaxLength(255);

                entity.Property(e => e.JobInterval)
                    .HasColumnName("job_interval")
                    .HasMaxLength(100);

                entity.Property(e => e.LastRun)
                    .HasColumnName("last_run")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(100);

                entity.Property(e => e.TimeFrom).HasColumnName("time_from");

                entity.Property(e => e.TimeTo).HasColumnName("time_to");
            });

            modelBuilder.Entity<SchedulersTimes>(entity =>
            {
                entity.ToTable("schedulers_times", "db_taylormade");

                entity.HasIndex(e => new { e.SchedulerId, e.ExecuteTime })
                    .HasName("idx_scheduler_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExecuteTime)
                    .HasColumnName("execute_time")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.SchedulerId)
                    .IsRequired()
                    .HasColumnName("scheduler_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(25)
                    .HasDefaultValueSql("(N'ready')");
            });

            modelBuilder.Entity<SessionActive>(entity =>
            {
                entity.ToTable("session_active", "db_taylormade");

                entity.HasIndex(e => e.SessionId)
                    .HasName("session_active$idx_session_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsViolation)
                    .HasColumnName("is_violation")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastRequestTime)
                    .HasColumnName("last_request_time")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.NumActiveSessions)
                    .HasColumnName("num_active_sessions")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SessionId)
                    .HasColumnName("session_id")
                    .HasMaxLength(100);

                entity.Property(e => e.SessionType)
                    .HasColumnName("session_type")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SessionHistory>(entity =>
            {
                entity.ToTable("session_history", "db_taylormade");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsViolation)
                    .HasColumnName("is_violation")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastRequestTime)
                    .HasColumnName("last_request_time")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.NumActiveSessions)
                    .HasColumnName("num_active_sessions")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SessionId)
                    .HasColumnName("session_id")
                    .HasMaxLength(100);

                entity.Property(e => e.SessionType)
                    .HasColumnName("session_type")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Shippers>(entity =>
            {
                entity.ToTable("shippers", "db_taylormade");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_shippers");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DefaultCost)
                    .HasColumnName("default_cost")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.DefaultCostUsdollar)
                    .HasColumnName("default_cost_usdollar")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.ListOrder).HasColumnName("list_order");

                entity.Property(e => e.ModifiedUserId)
                    .IsRequired()
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SSurveys>(entity =>
            {
                entity.ToTable("s_surveys", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_s_surveys_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("s_surveysmod");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_s_surveys_tmst_id");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_s_surveys_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_s_surveys_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_s_surveys_name_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.OverallSatisfaction)
                    .HasColumnName("overall_satisfaction")
                    .HasMaxLength(255);

                entity.Property(e => e.SurveyLink)
                    .HasColumnName("survey_link")
                    .HasMaxLength(255);

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<SSurveysAccountsC>(entity =>
            {
                entity.ToTable("s_surveys_accounts_c", "db_taylormade");

                entity.HasIndex(e => e.SSurveysAccountsaccountsIdb)
                    .HasName("s_surveys_accounts_alt");

                entity.HasIndex(e => e.SSurveysAccountssSurveysIda)
                    .HasName("s_surveys_accounts_ida1");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(36)
                    .ValueGeneratedNever();

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SSurveysAccountsaccountsIdb)
                    .HasColumnName("s_surveys_accountsaccounts_idb")
                    .HasMaxLength(36);

                entity.Property(e => e.SSurveysAccountssSurveysIda)
                    .HasColumnName("s_surveys_accountss_surveys_ida")
                    .HasMaxLength(36);
            });

            modelBuilder.Entity<SSurveysAudit>(entity =>
            {
                entity.ToTable("s_surveys_audit", "db_taylormade");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_s_surveys_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.AfterValueText).HasColumnName("after_value_text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.BeforeValueText).HasColumnName("before_value_text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<SSurveysCasesC>(entity =>
            {
                entity.ToTable("s_surveys_cases_c", "db_taylormade");

                entity.HasIndex(e => e.SSurveysCasescasesIdb)
                    .HasName("s_surveys_cases_alt");

                entity.HasIndex(e => e.SSurveysCasessSurveysIda)
                    .HasName("s_surveys_cases_ida1");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(36)
                    .ValueGeneratedNever();

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SSurveysCasescasesIdb)
                    .HasColumnName("s_surveys_casescases_idb")
                    .HasMaxLength(36);

                entity.Property(e => e.SSurveysCasessSurveysIda)
                    .HasColumnName("s_surveys_casess_surveys_ida")
                    .HasMaxLength(36);
            });

            modelBuilder.Entity<SSurveysCConsumersC>(entity =>
            {
                entity.ToTable("s_surveys_c_consumers_c", "db_taylormade");

                entity.HasIndex(e => e.SSurveysCConsumerscConsumersIdb)
                    .HasName("s_surveys_c_consumers_alt");

                entity.HasIndex(e => e.SSurveysCConsumerssSurveysIda)
                    .HasName("s_surveys_c_consumers_ida1");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(36)
                    .ValueGeneratedNever();

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SSurveysCConsumerscConsumersIdb)
                    .HasColumnName("s_surveys_c_consumersc_consumers_idb")
                    .HasMaxLength(36);

                entity.Property(e => e.SSurveysCConsumerssSurveysIda)
                    .HasColumnName("s_surveys_c_consumerss_surveys_ida")
                    .HasMaxLength(36);
            });

            modelBuilder.Entity<SSurveysContactsC>(entity =>
            {
                entity.ToTable("s_surveys_contacts_c", "db_taylormade");

                entity.HasIndex(e => e.SSurveysContactscontactsIdb)
                    .HasName("s_surveys_contacts_alt");

                entity.HasIndex(e => e.SSurveysContactssSurveysIda)
                    .HasName("s_surveys_contacts_ida1");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(36)
                    .ValueGeneratedNever();

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SSurveysContactscontactsIdb)
                    .HasColumnName("s_surveys_contactscontacts_idb")
                    .HasMaxLength(36);

                entity.Property(e => e.SSurveysContactssSurveysIda)
                    .HasColumnName("s_surveys_contactss_surveys_ida")
                    .HasMaxLength(36);
            });

            modelBuilder.Entity<SSurveysCstm>(entity =>
            {
                entity.HasKey(e => e.IdC);

                entity.ToTable("s_surveys_cstm", "db_taylormade");

                entity.Property(e => e.IdC)
                    .HasColumnName("id_c")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.BallPreferenceC).HasColumnName("ball_preference_c");

                entity.Property(e => e.BallSubSvcC)
                    .HasColumnName("ball_sub_svc_c")
                    .HasMaxLength(100);

                entity.Property(e => e.BudgetCutC)
                    .HasColumnName("budget_cut_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ClubTypeC)
                    .HasColumnName("club_type_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DriverFrequencyC)
                    .HasColumnName("driver_frequency_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.EquipInvestC)
                    .HasColumnName("equip_invest_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IronFrequencyC)
                    .HasColumnName("iron_frequency_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.MaxBallPriceC)
                    .HasColumnName("max_ball_price_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PurchaseFactorC)
                    .HasColumnName("purchase_factor_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PutterFrequencyC)
                    .HasColumnName("putter_frequency_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<Styleguide>(entity =>
            {
                entity.ToTable("styleguide", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_styleguide_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("styleguidemod");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_styleguide_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_styleguide_id_del");

                entity.HasIndex(e => new { e.FirstName, e.LastName, e.Deleted })
                    .HasName("idx_styleguide_first_last");

                entity.HasIndex(e => new { e.LastName, e.FirstName, e.Deleted })
                    .HasName("idx_styleguide_last_first");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AltAddressCity)
                    .HasColumnName("alt_address_city")
                    .HasMaxLength(100);

                entity.Property(e => e.AltAddressCountry)
                    .HasColumnName("alt_address_country")
                    .HasMaxLength(255);

                entity.Property(e => e.AltAddressPostalcode)
                    .HasColumnName("alt_address_postalcode")
                    .HasMaxLength(20);

                entity.Property(e => e.AltAddressState)
                    .HasColumnName("alt_address_state")
                    .HasMaxLength(100);

                entity.Property(e => e.AltAddressStreet)
                    .HasColumnName("alt_address_street")
                    .HasMaxLength(150);

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Assistant)
                    .HasColumnName("assistant")
                    .HasMaxLength(75);

                entity.Property(e => e.AssistantPhone)
                    .HasColumnName("assistant_phone")
                    .HasMaxLength(100);

                entity.Property(e => e.Birthdate)
                    .HasColumnName("birthdate")
                    .HasColumnType("date");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("currency_id")
                    .HasColumnType("nchar(36)")
                    .HasDefaultValueSql("(N'-99')");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateStart)
                    .HasColumnName("date_start")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Department)
                    .HasColumnName("department")
                    .HasMaxLength(255);

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DoNotCall)
                    .HasColumnName("do_not_call")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Facebook)
                    .HasColumnName("facebook")
                    .HasMaxLength(100);

                entity.Property(e => e.FileMimeType)
                    .HasColumnName("file_mime_type")
                    .HasMaxLength(100);

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasMaxLength(255);

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(100);

                entity.Property(e => e.Googleplus)
                    .HasColumnName("googleplus")
                    .HasMaxLength(100);

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ListPrice)
                    .HasColumnName("list_price")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ParentType)
                    .HasColumnName("parent_type")
                    .HasMaxLength(255);

                entity.Property(e => e.PhoneFax)
                    .HasColumnName("phone_fax")
                    .HasMaxLength(100);

                entity.Property(e => e.PhoneHome)
                    .HasColumnName("phone_home")
                    .HasMaxLength(100);

                entity.Property(e => e.PhoneMobile)
                    .HasColumnName("phone_mobile")
                    .HasMaxLength(100);

                entity.Property(e => e.PhoneOther)
                    .HasColumnName("phone_other")
                    .HasMaxLength(100);

                entity.Property(e => e.PhoneWork)
                    .HasColumnName("phone_work")
                    .HasMaxLength(100);

                entity.Property(e => e.Picture)
                    .HasColumnName("picture")
                    .HasMaxLength(255);

                entity.Property(e => e.PrimaryAddressCity)
                    .HasColumnName("primary_address_city")
                    .HasMaxLength(100);

                entity.Property(e => e.PrimaryAddressCountry)
                    .HasColumnName("primary_address_country")
                    .HasMaxLength(255);

                entity.Property(e => e.PrimaryAddressPostalcode)
                    .HasColumnName("primary_address_postalcode")
                    .HasMaxLength(20);

                entity.Property(e => e.PrimaryAddressState)
                    .HasColumnName("primary_address_state")
                    .HasMaxLength(100);

                entity.Property(e => e.PrimaryAddressStreet)
                    .HasColumnName("primary_address_street")
                    .HasMaxLength(150);

                entity.Property(e => e.RadioButtonGroup)
                    .HasColumnName("radio_button_group")
                    .HasMaxLength(255);

                entity.Property(e => e.Salutation)
                    .HasColumnName("salutation")
                    .HasMaxLength(255);

                entity.Property(e => e.SecretPassword)
                    .HasColumnName("secret_password")
                    .HasMaxLength(255);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255);

                entity.Property(e => e.Twitter)
                    .HasColumnName("twitter")
                    .HasMaxLength(100);

                entity.Property(e => e.UserEmail)
                    .HasColumnName("user_email")
                    .HasMaxLength(100);

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Subscriptions>(entity =>
            {
                entity.ToTable("subscriptions", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_subscriptions_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("subscriptionsmod");

                entity.HasIndex(e => e.ParentId)
                    .HasName("subscription_parent");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_subscriptions_id_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ParentType)
                    .HasColumnName("parent_type")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Sugarfavorites>(entity =>
            {
                entity.ToTable("sugarfavorites", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_sugarfavorites_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("sugarfavoritesmod");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_sugarfavorites_assigned_del");

                entity.HasIndex(e => new { e.DateEntered, e.Deleted })
                    .HasName("idx_favs_date_entered");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_sugarfavorites_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_sugarfavorites_name_del");

                entity.HasIndex(e => new { e.RecordId, e.Id })
                    .HasName("idx_favs_id_record_id");

                entity.HasIndex(e => new { e.ModifiedUserId, e.Module, e.Deleted })
                    .HasName("idx_favs_user_module");

                entity.HasIndex(e => new { e.Module, e.RecordId, e.Deleted })
                    .HasName("idx_favs_module_record_deleted");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Module)
                    .HasColumnName("module")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.RecordId)
                    .HasColumnName("record_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<Systems>(entity =>
            {
                entity.ToTable("systems", "db_taylormade");

                entity.HasIndex(e => e.SystemId)
                    .HasName("system_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InstallMethod)
                    .HasColumnName("install_method")
                    .HasMaxLength(100);

                entity.Property(e => e.LastConnectDate)
                    .HasColumnName("last_connect_date")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.NumSyncs)
                    .HasColumnName("num_syncs")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'Active')");

                entity.Property(e => e.SystemId)
                    .HasColumnName("system_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SystemKey)
                    .HasColumnName("system_key")
                    .HasMaxLength(36);

                entity.Property(e => e.SystemName)
                    .HasColumnName("system_name")
                    .HasMaxLength(100);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<TagBeanRel>(entity =>
            {
                entity.ToTable("tag_bean_rel", "db_taylormade");

                entity.HasIndex(e => new { e.TagId, e.BeanId })
                    .HasName("idx_tagsrel_tagid_beanid");

                entity.HasIndex(e => new { e.Deleted, e.BeanModule, e.BeanId })
                    .HasName("idx_tag_bean_rel_del_bean_module_beanid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.BeanId)
                    .IsRequired()
                    .HasColumnName("bean_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.BeanModule)
                    .HasColumnName("bean_module")
                    .HasMaxLength(100);

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TagId)
                    .IsRequired()
                    .HasColumnName("tag_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<Tags>(entity =>
            {
                entity.ToTable("tags", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_tags_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("idx_tags_date_modfied");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_tag_name");

                entity.HasIndex(e => e.NameLower)
                    .HasName("idx_tag_name_lower");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_tags_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_tags_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_tags_name_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.NameLower)
                    .HasColumnName("name_lower")
                    .HasMaxLength(255);

                entity.Property(e => e.SourceId)
                    .HasColumnName("source_id")
                    .HasMaxLength(255);

                entity.Property(e => e.SourceMeta).HasColumnName("source_meta");

                entity.Property(e => e.SourceType)
                    .HasColumnName("source_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TagsAudit>(entity =>
            {
                entity.ToTable("tags_audit", "db_taylormade");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_tags_audit_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.AfterValueText).HasColumnName("after_value_text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.BeforeValueText).HasColumnName("before_value_text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<Tasks>(entity =>
            {
                entity.ToTable("tasks", "db_taylormade");

                entity.HasIndex(e => e.AssignedUserId)
                    .HasName("idx_task_assigned");

                entity.HasIndex(e => e.DateDue)
                    .HasName("idx_task_date_due");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_task_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("tasksmod");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_tsk_name");

                entity.HasIndex(e => e.Status)
                    .HasName("idx_task_status");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_tasks_tmst_id");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_tasks_assigned_del");

                entity.HasIndex(e => new { e.ContactId, e.Deleted })
                    .HasName("idx_task_con_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_tasks_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_tasks_name_del");

                entity.HasIndex(e => new { e.ParentId, e.ParentType, e.Deleted })
                    .HasName("idx_task_par_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateDue)
                    .HasColumnName("date_due")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateDueFlag)
                    .HasColumnName("date_due_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateStart)
                    .HasColumnName("date_start")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateStartFlag)
                    .HasColumnName("date_start_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ParentType)
                    .HasColumnName("parent_type")
                    .HasMaxLength(255);

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasMaxLength(100);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Not Started')");

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<TasksAudit>(entity =>
            {
                entity.ToTable("tasks_audit", "db_taylormade");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_tasks_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.AfterValueText).HasColumnName("after_value_text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.BeforeValueText).HasColumnName("before_value_text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<TasksCstm>(entity =>
            {
                entity.HasKey(e => e.IdC);

                entity.ToTable("tasks_cstm", "db_taylormade");

                entity.Property(e => e.IdC)
                    .HasColumnName("id_c")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CompletedDateC)
                    .HasColumnName("completed_date_c")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.TaskCycleTimeC).HasColumnName("task_cycle_time_c");

                entity.Property(e => e.UkAccountNameC)
                    .HasColumnName("uk_account_name_c")
                    .HasMaxLength(255);

                entity.Property(e => e.UkCaseNotesC).HasColumnName("uk_case_notes_c");

                entity.Property(e => e.UkReferenceNumberC)
                    .HasColumnName("uk_reference_number_c")
                    .HasMaxLength(255);

                entity.Property(e => e.UkTaskTypeC)
                    .HasColumnName("uk_task_type_c")
                    .HasMaxLength(100);

                entity.Property(e => e.UkTrackingNumberC)
                    .HasColumnName("uk_tracking_number_c")
                    .HasMaxLength(255);

                entity.Property(e => e.UkWarehouseC)
                    .HasColumnName("uk_warehouse_c")
                    .HasMaxLength(255);

                entity.Property(e => e.UkWorkLogC).HasColumnName("uk_work_log_c");

                entity.Property(e => e.UnassignedC)
                    .HasColumnName("unassigned_c")
                    .HasMaxLength(100);

                entity.Property(e => e.UserTypeC)
                    .HasColumnName("user_type_c")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Taxrates>(entity =>
            {
                entity.ToTable("taxrates", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_taxrates_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("idx_taxrates_date_modfied");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_taxrates_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_taxrates");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.ListOrder).HasColumnName("list_order");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(100);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("decimal(26, 6)");
            });

            modelBuilder.Entity<TeamMemberships>(entity =>
            {
                entity.ToTable("team_memberships", "db_taylormade");

                entity.HasIndex(e => new { e.TeamId, e.UserId })
                    .HasName("idx_teammemb_team_user");

                entity.HasIndex(e => new { e.UserId, e.TeamId })
                    .HasName("idx_team_membership");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExplicitAssign)
                    .HasColumnName("explicit_assign")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ImplicitAssign)
                    .HasColumnName("implicit_assign")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<TeamNotices>(entity =>
            {
                entity.ToTable("team_notices", "db_taylormade");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_team_notices_tmst_id");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_team_notice");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEnd)
                    .HasColumnName("date_end")
                    .HasColumnType("date");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateStart)
                    .HasColumnName("date_start")
                    .HasColumnType("date");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(100);

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(255);

                entity.Property(e => e.UrlTitle)
                    .HasColumnName("url_title")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Teams>(entity =>
            {
                entity.ToTable("teams", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_teams_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("teamsmod");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_team_del");

                entity.HasIndex(e => new { e.Deleted, e.Name })
                    .HasName("idx_team_del_name");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_teams_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_teams_name_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssociatedUserId)
                    .HasColumnName("associated_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(128);

                entity.Property(e => e.Name2)
                    .HasColumnName("name_2")
                    .HasMaxLength(128);

                entity.Property(e => e.Private)
                    .HasColumnName("private")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TeamSets>(entity =>
            {
                entity.ToTable("team_sets", "db_taylormade");

                entity.HasIndex(e => e.TeamMd5)
                    .HasName("idx_team_sets_md5");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(128);

                entity.Property(e => e.TeamCount)
                    .HasColumnName("team_count")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TeamMd5)
                    .HasColumnName("team_md5")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<TeamSetsModules>(entity =>
            {
                entity.ToTable("team_sets_modules", "db_taylormade");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_team_sets_modules");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModuleTableName)
                    .HasColumnName("module_table_name")
                    .HasMaxLength(128);

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<TeamSetsTeams>(entity =>
            {
                entity.ToTable("team_sets_teams", "db_taylormade");

                entity.HasIndex(e => e.TeamId)
                    .HasName("idx_ud_team_id");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_ud_team_set_id");

                entity.HasIndex(e => new { e.TeamSetId, e.TeamId })
                    .HasName("idx_ud_set_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<Timeperiods>(entity =>
            {
                entity.ToTable("timeperiods", "db_taylormade");

                entity.HasIndex(e => e.EndDate)
                    .HasName("idx_timeperiod_end_date");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_timeperiod_name");

                entity.HasIndex(e => e.StartDate)
                    .HasName("idx_timeperiod_start_date");

                entity.HasIndex(e => new { e.Id, e.StartDateTimestamp, e.EndDateTimestamp })
                    .HasName("idx_timestamps");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("date");

                entity.Property(e => e.EndDateTimestamp).HasColumnName("end_date_timestamp");

                entity.Property(e => e.IsFiscal)
                    .HasColumnName("is_fiscal")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsFiscalYear)
                    .HasColumnName("is_fiscal_year")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LeafCycle).HasColumnName("leaf_cycle");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(36);

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("date");

                entity.Property(e => e.StartDateTimestamp).HasColumnName("start_date_timestamp");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Tracker>(entity =>
            {
                entity.ToTable("tracker", "db_taylormade");

                entity.HasIndex(e => e.DateModified)
                    .HasName("idx_tracker_date_modified");

                entity.HasIndex(e => e.ItemId)
                    .HasName("idx_tracker_iid");

                entity.HasIndex(e => e.MonitorId)
                    .HasName("idx_tracker_monitor_id");

                entity.HasIndex(e => new { e.UserId, e.Deleted, e.Visible })
                    .HasName("idx_tracker_userid_del_vis");

                entity.HasIndex(e => new { e.UserId, e.ItemId, e.Visible })
                    .HasName("idx_tracker_userid_itemid_vis");

                entity.HasIndex(e => new { e.UserId, e.Visible, e.Id })
                    .HasName("idx_tracker_userid_vis_id");

                entity.HasIndex(e => new { e.ModuleName, e.UserId, e.DateModified, e.ItemId })
                    .HasName("idx_trckr_mod_uid_dtmod_item");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasColumnName("action")
                    .HasMaxLength(255);

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemId)
                    .HasColumnName("item_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ItemSummary)
                    .HasColumnName("item_summary")
                    .HasMaxLength(255);

                entity.Property(e => e.ModuleName)
                    .HasColumnName("module_name")
                    .HasMaxLength(255);

                entity.Property(e => e.MonitorId)
                    .IsRequired()
                    .HasColumnName("monitor_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.SessionId)
                    .HasColumnName("session_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Visible)
                    .HasColumnName("visible")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TrackerPerf>(entity =>
            {
                entity.ToTable("tracker_perf", "db_taylormade");

                entity.HasIndex(e => e.MonitorId)
                    .HasName("idx_tracker_perf_mon_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DbRoundTrips).HasColumnName("db_round_trips");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FilesOpened).HasColumnName("files_opened");

                entity.Property(e => e.MemoryUsage).HasColumnName("memory_usage");

                entity.Property(e => e.MonitorId)
                    .IsRequired()
                    .HasColumnName("monitor_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ServerResponseTime).HasColumnName("server_response_time");
            });

            modelBuilder.Entity<TrackerQueries>(entity =>
            {
                entity.ToTable("tracker_queries", "db_taylormade");

                entity.HasIndex(e => e.QueryHash)
                    .HasName("idx_tracker_queries_query_hash");

                entity.HasIndex(e => e.QueryId)
                    .HasName("idx_tracker_queries_query_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QueryHash)
                    .HasColumnName("query_hash")
                    .HasMaxLength(36);

                entity.Property(e => e.QueryId)
                    .IsRequired()
                    .HasColumnName("query_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.RunCount).HasColumnName("run_count");

                entity.Property(e => e.SecAvg).HasColumnName("sec_avg");

                entity.Property(e => e.SecTotal).HasColumnName("sec_total");

                entity.Property(e => e.Text).HasColumnName("text");
            });

            modelBuilder.Entity<TrackerSessions>(entity =>
            {
                entity.ToTable("tracker_sessions", "db_taylormade");

                entity.HasIndex(e => e.SessionId)
                    .HasName("idx_tracker_sessions_s_id");

                entity.HasIndex(e => new { e.UserId, e.Active, e.SessionId })
                    .HasName("idx_tracker_sessions_uas_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ClientIp)
                    .HasColumnName("client_ip")
                    .HasMaxLength(45);

                entity.Property(e => e.DateEnd)
                    .HasColumnName("date_end")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateStart)
                    .HasColumnName("date_start")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Seconds)
                    .HasColumnName("seconds")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SessionId)
                    .HasColumnName("session_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<TrackerTrackerQueries>(entity =>
            {
                entity.ToTable("tracker_tracker_queries", "db_taylormade");

                entity.HasIndex(e => e.MonitorId)
                    .HasName("idx_tracker_tq_monitor");

                entity.HasIndex(e => e.QueryId)
                    .HasName("idx_tracker_tq_query");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.MonitorId)
                    .HasColumnName("monitor_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.QueryId)
                    .HasColumnName("query_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<UkCases>(entity =>
            {
                entity.ToTable("uk_cases", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_uk_cases_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("uk_casesmod");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_uk_cases_tmst_id");

                entity.HasIndex(e => e.UkCasesNumber)
                    .HasName("uk_cases$uk_casesnumk")
                    .IsUnique();

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_uk_cases_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_uk_cases_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_uk_cases_name_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.BaseRate)
                    .HasColumnName("base_rate")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(100);

                entity.Property(e => e.Carrier)
                    .HasColumnName("carrier")
                    .HasMaxLength(100);

                entity.Property(e => e.CaseAge)
                    .HasColumnName("case_age")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CaseType)
                    .HasColumnName("case_type")
                    .HasMaxLength(100);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("currency_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CustomerType)
                    .HasColumnName("customer_type")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Account')");

                entity.Property(e => e.DateClosed)
                    .HasColumnName("date_closed")
                    .HasColumnType("date");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("email_address")
                    .HasMaxLength(255);

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.OtherDescription)
                    .HasColumnName("other_description")
                    .HasMaxLength(255);

                entity.Property(e => e.ParcelPalletCount)
                    .HasColumnName("parcel_pallet_count")
                    .HasMaxLength(255);

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasMaxLength(100);

                entity.Property(e => e.ProductCategory)
                    .HasColumnName("product_category")
                    .HasMaxLength(100);

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasMaxLength(255);

                entity.Property(e => e.RequestedDeliveryDate)
                    .HasColumnName("requested_delivery_date")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Resolution)
                    .HasColumnName("resolution")
                    .HasMaxLength(255);

                entity.Property(e => e.ShiptoId)
                    .HasColumnName("shipto_id")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(100);

                entity.Property(e => e.SubType)
                    .HasColumnName("sub_type")
                    .HasMaxLength(100);

                entity.Property(e => e.SystemId).HasColumnName("system_id");

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TotalCycleTime).HasColumnName("total_cycle_time");

                entity.Property(e => e.TrackingNumber)
                    .HasColumnName("tracking_number")
                    .HasMaxLength(255);

                entity.Property(e => e.TrackingUrl)
                    .HasColumnName("tracking_url")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'http://wwwapps.ups.com/WebTracking/OnlineTool?InquiryNumber={tracking_number}&loc=en_GB&TypeOfInquiryNumber=T')");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255);

                entity.Property(e => e.UkCasesNumber)
                    .HasColumnName("uk_cases_number")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.VasAccount)
                    .HasColumnName("vas_account")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Warehouse).HasColumnName("warehouse");

                entity.Property(e => e.WorkLog).HasColumnName("work_log");

                entity.Property(e => e.WorkflowCurrency)
                    .HasColumnName("workflow_currency")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<UkCasesAccountsC>(entity =>
            {
                entity.ToTable("uk_cases_accounts_c", "db_taylormade");

                entity.HasIndex(e => e.UkCasesAccountsaccountsIda)
                    .HasName("uk_cases_accounts_ida1");

                entity.HasIndex(e => e.UkCasesAccountsukCasesIdb)
                    .HasName("uk_cases_accounts_alt");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(36)
                    .ValueGeneratedNever();

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UkCasesAccountsaccountsIda)
                    .HasColumnName("uk_cases_accountsaccounts_ida")
                    .HasMaxLength(36);

                entity.Property(e => e.UkCasesAccountsukCasesIdb)
                    .HasColumnName("uk_cases_accountsuk_cases_idb")
                    .HasMaxLength(36);
            });

            modelBuilder.Entity<UkCasesAudit>(entity =>
            {
                entity.ToTable("uk_cases_audit", "db_taylormade");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_uk_cases_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.AfterValueText).HasColumnName("after_value_text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.BeforeValueText).HasColumnName("before_value_text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<UpgradeHistory>(entity =>
            {
                entity.ToTable("upgrade_history", "db_taylormade");

                entity.HasIndex(e => e.Md5sum)
                    .HasName("upgrade_history$upgrade_history_md5_uk")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Enabled)
                    .HasColumnName("enabled")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasMaxLength(255);

                entity.Property(e => e.IdName)
                    .HasColumnName("id_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Manifest).HasColumnName("manifest");

                entity.Property(e => e.Md5sum)
                    .HasColumnName("md5sum")
                    .HasMaxLength(32);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Patch).HasColumnName("patch");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(30);

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<UserPreferences>(entity =>
            {
                entity.ToTable("user_preferences", "db_taylormade");

                entity.HasIndex(e => new { e.AssignedUserId, e.Category })
                    .HasName("idx_userprefnamecat");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(50);

                entity.Property(e => e.Contents).HasColumnName("contents");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users", "db_taylormade");

                entity.HasIndex(e => e.Department)
                    .HasName("idx_user_department");

                entity.HasIndex(e => e.LastLogin)
                    .HasName("idx_last_login");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_users_tmst_id");

                entity.HasIndex(e => e.Title)
                    .HasName("idx_user_title");

                entity.HasIndex(e => new { e.ReportsToId, e.Id })
                    .HasName("idx_users_reports_to_id");

                entity.HasIndex(e => new { e.FirstName, e.LastName, e.Deleted })
                    .HasName("idx_user_first_last");

                entity.HasIndex(e => new { e.LastName, e.FirstName, e.Deleted })
                    .HasName("idx_user_last_first");

                entity.HasIndex(e => new { e.UserName, e.IsGroup, e.Status, e.LastName, e.FirstName, e.Id })
                    .HasName("idx_user_name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AclRoleSetId)
                    .HasColumnName("acl_role_set_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.AddressCity)
                    .HasColumnName("address_city")
                    .HasMaxLength(100);

                entity.Property(e => e.AddressCountry)
                    .HasColumnName("address_country")
                    .HasMaxLength(100);

                entity.Property(e => e.AddressPostalcode)
                    .HasColumnName("address_postalcode")
                    .HasMaxLength(20);

                entity.Property(e => e.AddressState)
                    .HasColumnName("address_state")
                    .HasMaxLength(100);

                entity.Property(e => e.AddressStreet)
                    .HasColumnName("address_street")
                    .HasMaxLength(150);

                entity.Property(e => e.AuthenticateId)
                    .HasColumnName("authenticate_id")
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DefaultTeam)
                    .HasColumnName("default_team")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Department)
                    .HasColumnName("department")
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EmployeeStatus)
                    .HasColumnName("employee_status")
                    .HasMaxLength(100);

                entity.Property(e => e.ExternalAuthOnly)
                    .HasColumnName("external_auth_only")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(30);

                entity.Property(e => e.IsAdmin)
                    .HasColumnName("is_admin")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsGroup).HasColumnName("is_group");

                entity.Property(e => e.LastLogin)
                    .HasColumnName("last_login")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(30);

                entity.Property(e => e.MessengerId)
                    .HasColumnName("messenger_id")
                    .HasMaxLength(100);

                entity.Property(e => e.MessengerType)
                    .HasColumnName("messenger_type")
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.PhoneFax)
                    .HasColumnName("phone_fax")
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneHome)
                    .HasColumnName("phone_home")
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneMobile)
                    .HasColumnName("phone_mobile")
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneOther)
                    .HasColumnName("phone_other")
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneWork)
                    .HasColumnName("phone_work")
                    .HasMaxLength(50);

                entity.Property(e => e.Picture)
                    .HasColumnName("picture")
                    .HasMaxLength(255);

                entity.Property(e => e.PortalOnly)
                    .HasColumnName("portal_only")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PreferredLanguage)
                    .HasColumnName("preferred_language")
                    .HasMaxLength(255);

                entity.Property(e => e.PwdLastChanged)
                    .HasColumnName("pwd_last_changed")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.ReceiveNotifications)
                    .HasColumnName("receive_notifications")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RepCodeC)
                    .HasColumnName("rep_code_c")
                    .HasMaxLength(255);

                entity.Property(e => e.ReportsToId)
                    .HasColumnName("reports_to_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ShowOnEmployees)
                    .HasColumnName("show_on_employees")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(100);

                entity.Property(e => e.SugarLogin)
                    .HasColumnName("sugar_login")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SystemGeneratedPassword).HasColumnName("system_generated_password");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(50);

                entity.Property(e => e.UserHash)
                    .HasColumnName("user_hash")
                    .HasMaxLength(255);

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(60);

                entity.Property(e => e.UserTypeC)
                    .HasColumnName("user_type_c")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<UsersHolidays>(entity =>
            {
                entity.ToTable("users_holidays", "db_taylormade");

                entity.HasIndex(e => e.HolidayId)
                    .HasName("idx_user_holi_holi");

                entity.HasIndex(e => e.UserId)
                    .HasName("idx_user_holi_user");

                entity.HasIndex(e => new { e.UserId, e.HolidayId })
                    .HasName("users_quotes_alt");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HolidayId)
                    .HasColumnName("holiday_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<UsersLastImport>(entity =>
            {
                entity.ToTable("users_last_import", "db_taylormade");

                entity.HasIndex(e => e.AssignedUserId)
                    .HasName("idx_user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.BeanId)
                    .HasColumnName("bean_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.BeanType)
                    .HasColumnName("bean_type")
                    .HasMaxLength(36);

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.ImportModule)
                    .HasColumnName("import_module")
                    .HasMaxLength(36);
            });

            modelBuilder.Entity<UsersPasswordLink>(entity =>
            {
                entity.ToTable("users_password_link", "db_taylormade");

                entity.HasIndex(e => e.Username)
                    .HasName("idx_username");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateGenerated)
                    .HasColumnName("date_generated")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(36);
            });

            modelBuilder.Entity<UsersSignatures>(entity =>
            {
                entity.ToTable("users_signatures", "db_taylormade");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("idx_usersig_created_by");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_users_signatures_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("users_signaturesmod");

                entity.HasIndex(e => e.UserId)
                    .HasName("idx_usersig_uid");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_users_signatures_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_users_signatures_name_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Signature).HasColumnName("signature");

                entity.Property(e => e.SignatureHtml).HasColumnName("signature_html");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<Vcals>(entity =>
            {
                entity.ToTable("vcals", "db_taylormade");

                entity.HasIndex(e => new { e.Type, e.UserId, e.Source })
                    .HasName("idx_vcal");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasMaxLength(100);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(100);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("user_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<Versions>(entity =>
            {
                entity.ToTable("versions", "db_taylormade");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_version");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DbVersion)
                    .HasColumnName("db_version")
                    .HasMaxLength(255);

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.FileVersion)
                    .HasColumnName("file_version")
                    .HasMaxLength(255);

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Weblogichooks>(entity =>
            {
                entity.ToTable("weblogichooks", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_weblogichooks_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("weblogichooksmod");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_weblogichooks_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_weblogichooks_name_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.RequestMethod)
                    .HasColumnName("request_method")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'POST')");

                entity.Property(e => e.TriggerEvent)
                    .HasColumnName("trigger_event")
                    .HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(255);

                entity.Property(e => e.WebhookTargetModule)
                    .HasColumnName("webhook_target_module")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Workflow>(entity =>
            {
                entity.ToTable("workflow", "db_taylormade");

                entity.HasIndex(e => e.BaseModule)
                    .HasName("idx_workflow_base_module");

                entity.HasIndex(e => e.Type)
                    .HasName("idx_workflow_type");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_workflow");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.BaseModule)
                    .HasColumnName("base_module")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.FireOrder)
                    .HasColumnName("fire_order")
                    .HasMaxLength(100);

                entity.Property(e => e.ListOrderY)
                    .HasColumnName("list_order_y")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.RecordType)
                    .HasColumnName("record_type")
                    .HasMaxLength(100);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<WorkflowActions>(entity =>
            {
                entity.ToTable("workflow_actions", "db_taylormade");

                entity.HasIndex(e => e.Deleted)
                    .HasName("idx_action");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdvType)
                    .HasColumnName("adv_type")
                    .HasMaxLength(10);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ext1)
                    .HasColumnName("ext1")
                    .HasMaxLength(50);

                entity.Property(e => e.Ext2)
                    .HasColumnName("ext2")
                    .HasMaxLength(50);

                entity.Property(e => e.Ext3)
                    .HasColumnName("ext3")
                    .HasMaxLength(50);

                entity.Property(e => e.Field)
                    .HasColumnName("field")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.SetType)
                    .HasColumnName("set_type")
                    .HasMaxLength(10);

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<WorkflowActionshells>(entity =>
            {
                entity.ToTable("workflow_actionshells", "db_taylormade");

                entity.HasIndex(e => e.Deleted)
                    .HasName("idx_actionshell");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActionModule)
                    .HasColumnName("action_module")
                    .HasMaxLength(255);

                entity.Property(e => e.ActionType)
                    .HasColumnName("action_type")
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Parameters)
                    .HasColumnName("parameters")
                    .HasMaxLength(255);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.RelModule)
                    .HasColumnName("rel_module")
                    .HasMaxLength(50);

                entity.Property(e => e.RelModuleType)
                    .HasColumnName("rel_module_type")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<WorkflowAlerts>(entity =>
            {
                entity.ToTable("workflow_alerts", "db_taylormade");

                entity.HasIndex(e => e.Deleted)
                    .HasName("idx_workflowalerts");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressType)
                    .HasColumnName("address_type")
                    .HasMaxLength(100);

                entity.Property(e => e.ArrayType)
                    .HasColumnName("array_type")
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FieldValue)
                    .HasColumnName("field_value")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.RelEmailValue)
                    .HasColumnName("rel_email_value")
                    .HasMaxLength(50);

                entity.Property(e => e.RelModule1)
                    .HasColumnName("rel_module1")
                    .HasMaxLength(255);

                entity.Property(e => e.RelModule1Type)
                    .HasColumnName("rel_module1_type")
                    .HasMaxLength(10);

                entity.Property(e => e.RelModule2)
                    .HasColumnName("rel_module2")
                    .HasMaxLength(255);

                entity.Property(e => e.RelModule2Type)
                    .HasColumnName("rel_module2_type")
                    .HasMaxLength(10);

                entity.Property(e => e.RelateType)
                    .HasColumnName("relate_type")
                    .HasMaxLength(100);

                entity.Property(e => e.UserDisplayType)
                    .HasColumnName("user_display_type")
                    .HasMaxLength(100);

                entity.Property(e => e.UserType)
                    .HasColumnName("user_type")
                    .HasMaxLength(100);

                entity.Property(e => e.WhereFilter)
                    .HasColumnName("where_filter")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<WorkflowAlertshells>(entity =>
            {
                entity.ToTable("workflow_alertshells", "db_taylormade");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_workflowalertshell");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AlertText).HasColumnName("alert_text");

                entity.Property(e => e.AlertType)
                    .HasColumnName("alert_type")
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CustomTemplateId)
                    .HasColumnName("custom_template_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.SourceType)
                    .HasColumnName("source_type")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<WorkflowSchedules>(entity =>
            {
                entity.ToTable("workflow_schedules", "db_taylormade");

                entity.HasIndex(e => new { e.WorkflowId, e.Deleted })
                    .HasName("idx_wkfl_schedule");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.BeanId)
                    .HasColumnName("bean_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateExpired)
                    .HasColumnName("date_expired")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Parameters)
                    .HasColumnName("parameters")
                    .HasMaxLength(255);

                entity.Property(e => e.TargetModule)
                    .HasColumnName("target_module")
                    .HasMaxLength(50);

                entity.Property(e => e.WorkflowId)
                    .HasColumnName("workflow_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<WorkflowTriggershells>(entity =>
            {
                entity.ToTable("workflow_triggershells", "db_taylormade");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Eval).HasColumnName("eval");

                entity.Property(e => e.Field)
                    .HasColumnName("field")
                    .HasMaxLength(50);

                entity.Property(e => e.FrameType)
                    .HasColumnName("frame_type")
                    .HasMaxLength(15);

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Parameters)
                    .HasColumnName("parameters")
                    .HasMaxLength(255);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.RelModule)
                    .HasColumnName("rel_module")
                    .HasMaxLength(255);

                entity.Property(e => e.RelModuleType)
                    .HasColumnName("rel_module_type")
                    .HasMaxLength(10);

                entity.Property(e => e.ShowPast)
                    .HasColumnName("show_past")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<WWhatsInTheBag>(entity =>
            {
                entity.ToTable("w_whats_in_the_bag", "db_taylormade");

                entity.HasIndex(e => e.DateEntered)
                    .HasName("idx_w_whats_in_the_bag_date_entered");

                entity.HasIndex(e => e.DateModified)
                    .HasName("w_whats_in_the_bagmod");

                entity.HasIndex(e => e.TeamSetId)
                    .HasName("idx_w_whats_in_the_bag_tmst_id");

                entity.HasIndex(e => new { e.AssignedUserId, e.Deleted })
                    .HasName("idx_w_whats_in_the_bag_assigned_del");

                entity.HasIndex(e => new { e.Id, e.Deleted })
                    .HasName("idx_w_whats_in_the_bag_id_del");

                entity.HasIndex(e => new { e.Name, e.Deleted })
                    .HasName("idx_w_whats_in_the_bag_name_del");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .HasColumnName("assigned_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("date_entered")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(255);

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnName("modified_user_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.PlanningToPurchase)
                    .HasColumnName("planning_to_purchase")
                    .HasMaxLength(100);

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.TeamSetId)
                    .HasColumnName("team_set_id")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.Vendor)
                    .HasColumnName("vendor")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<WWhatsInTheBagAudit>(entity =>
            {
                entity.ToTable("w_whats_in_the_bag_audit", "db_taylormade");

                entity.HasIndex(e => e.ParentId)
                    .HasName("idx_w_whats_in_the_bag_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfterValueString)
                    .HasColumnName("after_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.AfterValueText).HasColumnName("after_value_text");

                entity.Property(e => e.BeforeValueString)
                    .HasColumnName("before_value_string")
                    .HasMaxLength(255);

                entity.Property(e => e.BeforeValueText).HasColumnName("before_value_text");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("nchar(36)");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parent_id")
                    .HasColumnType("nchar(36)");
            });

            modelBuilder.Entity<WWhatsInTheBagCConsumersC>(entity =>
            {
                entity.ToTable("w_whats_in_the_bag_c_consumers_c", "db_taylormade");

                entity.HasIndex(e => e.WWhatsInTheBagCConsumerscConsumersIda)
                    .HasName("w_whats_in_the_bag_c_consumers_ida1");

                entity.HasIndex(e => e.WWhatsInTheBagCConsumerswWhatsInTheBagIdb)
                    .HasName("w_whats_in_the_bag_c_consumers_alt");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(36)
                    .ValueGeneratedNever();

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WWhatsInTheBagCConsumerscConsumersIda)
                    .HasColumnName("w_whats_in_the_bag_c_consumersc_consumers_ida")
                    .HasMaxLength(36);

                entity.Property(e => e.WWhatsInTheBagCConsumerswWhatsInTheBagIdb)
                    .HasColumnName("w_whats_in_the_bag_c_consumersw_whats_in_the_bag_idb")
                    .HasMaxLength(36);
            });

            modelBuilder.Entity<WWhatsInTheBagCstm>(entity =>
            {
                entity.HasKey(e => e.IdC);

                entity.ToTable("w_whats_in_the_bag_cstm", "db_taylormade");

                entity.Property(e => e.IdC)
                    .HasColumnName("id_c")
                    .HasColumnType("nchar(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveC)
                    .HasColumnName("active_c")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FaceLieAdjustmentC)
                    .HasColumnName("face_lie_adjustment_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FaceLoftAdjustmentC)
                    .HasColumnName("face_loft_adjustment_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FlexC)
                    .HasColumnName("flex_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.HeadLoftC)
                    .HasColumnName("head_loft_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LoftC)
                    .HasColumnName("loft_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShaftLengthC)
                    .HasColumnName("shaft_length_c")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SkuC)
                    .HasColumnName("sku_c")
                    .HasMaxLength(255);
            });
        }
    }
}
