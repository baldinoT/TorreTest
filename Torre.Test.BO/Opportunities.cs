using Newtonsoft.Json;
using System;


namespace Torre.Test.BO
{



    public partial class Opportunities
    {
        [JsonProperty("attachments")]
        public Attachment[] Attachments { get; set; }

        [JsonProperty("boardVersion")]
        public long BoardVersion { get; set; }

        [JsonProperty("prefilledStatus")]
        public PrefilledStatus PrefilledStatus { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("objective")]
        public string Objective { get; set; }

        [JsonProperty("stats")]
        public StatsO StatsO { get; set; }

        [JsonProperty("review")]
        public string Review { get; set; }

        [JsonProperty("draft")]
        public object Draft { get; set; }

        [JsonProperty("members")]
        public Member[] Members { get; set; }

        [JsonProperty("details")]
        public Detail[] Details { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("place")]
        public Place Place { get; set; }

        [JsonProperty("deadline")]
        public DateTimeOffset Deadline { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("serpTags")]
        public SerpTags SerpTags { get; set; }

        [JsonProperty("owner")]
        public Owner Owner { get; set; }

        [JsonProperty("completion")]
        public long Completion { get; set; }

        [JsonProperty("agreement")]
        public Agreement Agreement { get; set; }

        [JsonProperty("languages")]
        public LanguageElement[] Languages { get; set; }

        [JsonProperty("created")]
        public DateTimeOffset Created { get; set; }

        [JsonProperty("crawled")]
        public bool Crawled { get; set; }

        [JsonProperty("opportunity")]
        public string Opportunity { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("commitment")]
        public Commitment Commitment { get; set; }

        [JsonProperty("stableOn")]
        public DateTimeOffset StableOn { get; set; }

        [JsonProperty("timezones")]
        public string[] Timezones { get; set; }

        [JsonProperty("strengths")]
        public Strength[] Strengths { get; set; }

        [JsonProperty("organizations")]
        public Organization[] Organizations { get; set; }

        [JsonProperty("compensation")]
        public Compensation Compensation { get; set; }

        [JsonProperty("openGraph")]
        public Uri OpenGraph { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public partial class Agreement
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("currencyTaxes")]
        public string CurrencyTaxes { get; set; }
    }

    public partial class Attachment
    {
        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("address")]
        public Uri Address { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }
    }

    public partial class Commitment
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("hours")]
        public long Hours { get; set; }
    }

    public partial class Compensation
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("estimate")]
        public bool Estimate { get; set; }

        [JsonProperty("minAmount")]
        public long MinAmount { get; set; }

        [JsonProperty("maxAmount")]
        public long MaxAmount { get; set; }

        [JsonProperty("periodicity")]
        public string Periodicity { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }
    }

    public partial class Detail
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public partial class LanguageElement
    {
        [JsonProperty("language")]
        public LanguageLanguage Language { get; set; }

        [JsonProperty("fluency")]
        public string Fluency { get; set; }
    }

    public partial class LanguageLanguage
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class Member
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("person")]
        public Owner Person { get; set; }

        [JsonProperty("manager")]
        public bool Manager { get; set; }

        [JsonProperty("poster")]
        public bool Poster { get; set; }

        [JsonProperty("member")]
        public bool MemberMember { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }

        [JsonProperty("screeningQuestionsTipClosed")]
        public bool ScreeningQuestionsTipClosed { get; set; }
    }

    public partial class Owner
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("hasEmail")]
        public bool HasEmail { get; set; }

        [JsonProperty("professionalHeadline")]
        public string ProfessionalHeadline { get; set; }

        [JsonProperty("picture", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Picture { get; set; }

        [JsonProperty("pictureThumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public Uri PictureThumbnail { get; set; }

        [JsonProperty("hasBio")]
        public bool HasBio { get; set; }

        [JsonProperty("bioCompletion")]
        public double BioCompletion { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("subjectId")]
        public long SubjectId { get; set; }
    }

    public partial class Organization
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("picture")]
        public Uri Picture { get; set; }
    }

    public partial class Place
    {
        [JsonProperty("remote")]
        public bool Remote { get; set; }

        [JsonProperty("anywhere")]
        public bool Anywhere { get; set; }

        [JsonProperty("timezone")]
        public bool Timezone { get; set; }

        [JsonProperty("location")]
        public object[] Location { get; set; }
    }

    public partial class PrefilledStatus
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public partial class SerpTags
    {
        [JsonProperty("@context")]
        public Uri Context { get; set; }

        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("identifier")]
        public Identifier Identifier { get; set; }

        [JsonProperty("datePosted")]
        public DateTimeOffset DatePosted { get; set; }

        [JsonProperty("employmentType")]
        public string[] EmploymentType { get; set; }

        [JsonProperty("validThrough")]
        public DateTimeOffset ValidThrough { get; set; }

        [JsonProperty("hiringOrganization")]
        public HiringOrganization HiringOrganization { get; set; }

        [JsonProperty("jobLocationType")]
        public string JobLocationType { get; set; }

        [JsonProperty("applicantLocationRequirements")]
        public ApplicantLocationRequirement[] ApplicantLocationRequirements { get; set; }

        [JsonProperty("baseSalary")]
        public BaseSalary BaseSalary { get; set; }
    }

    public partial class ApplicantLocationRequirement
    {
        [JsonProperty("@type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class BaseSalary
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public Value Value { get; set; }
    }

    public partial class Value
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("minValue")]
        public long MinValue { get; set; }

        [JsonProperty("maxValue")]
        public long MaxValue { get; set; }

        [JsonProperty("unitText")]
        public string UnitText { get; set; }
    }

    public partial class HiringOrganization
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("logo")]
        public Uri Logo { get; set; }
    }

    public partial class Identifier
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public partial class StatsO
    {
        [JsonProperty("finishedApplications")]
        public long FinishedApplications { get; set; }
    }

    public partial class Strength
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public long Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("experience")]
        public string Experience { get; set; }
    }

    public enum Status { Accepted, Pending };

    public enum TypeEnum { Country };
}