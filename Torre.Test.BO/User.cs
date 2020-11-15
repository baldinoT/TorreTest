﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torre.Test.BO
{

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Flags
    {
        public bool benefits { get; set; }
        public bool canary { get; set; }
        public bool enlauSource { get; set; }
        public bool fake { get; set; }
        public bool featureDiscovery { get; set; }
        public bool getSignaledBenefitsViewed { get; set; }
        public bool firstSignalSent { get; set; }
        public bool promoteYourselfBenefitsViewed { get; set; }
        public bool promoteYourselfCompleted { get; set; }
        public bool importingLinkedin { get; set; }
        public bool onBoarded { get; set; }
        public bool remoter { get; set; }
        public bool signalsFeatureDiscovery { get; set; }
        public bool signedInToOpportunities { get; set; }
        public bool importingLinkedinRecommendations { get; set; }
        public bool contactsImported { get; set; }
        public bool appContactsImported { get; set; }
        public bool genomeCompletionAcknowledged { get; set; }
    }

    public class Link
    {
        public string id { get; set; }  
        public string name { get; set; }    
        public string address { get; set; } 
    }

    public class Location
    {
        public string name { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string timezone { get; set; }
        public int timezoneOffSet { get; set; }
    }

    public class Person
    {
        public string professionalHeadline { get; set; }
        public int completion { get; set; }
        public bool showPhone { get; set; }
        public DateTime created { get; set; }
        public bool verified { get; set; }
        public Flags flags { get; set; }
        public int weight { get; set; }
        public string locale { get; set; }
        public int subjectId { get; set; }
        public string picture { get; set; }
        public bool hasEmail { get; set; }
        public string name { get; set; }
        public List<Link> links { get; set; }   
        public Location location { get; set; }
        public string theme { get; set; }
        public string id { get; set; }
        public string pictureThumbnail { get; set; }
        public bool claimant { get; set; }
        public string weightGraph { get; set; }
        public string publicId { get; set; }
    }

    public class Stats
    {
        public int strengths { get; set; }
        public int education { get; set; }
        public int interests { get; set; }
        public int jobs { get; set; }
        public int projects { get; set; }
    }

    public partial class Strength
    {
        //public string id { get; set; } //elbt15112020
        protected string id { get; set; }  //agbt15112020
        //public int code { get; set; }  //elbt15112020
        protected int code { get; set; }   //agbt15112020
        protected string name { get; set; }   //mdbt15112020: public string name { get; set; } 
        protected int weight { get; set; }     //mdbt15112020: public int weight { get; set; } 
        protected int recommendations { get; set; } //mdbt15112020: public int recommendations { get; set; }
        protected List<object> media { get; set; }  //mdbt15112020: public List<object> media { get; set; }
        protected DateTime created { get; set; }   //mdbt15112020: public DateTime created { get; set; }
    }

    public class Interest
    {
        public string id { get; set; }
        public int code { get; set; }
        public string name { get; set; }
        public List<object> media { get; set; }
        public DateTime created { get; set; }
    }

    public partial class Organization
    {
        protected int id { get; set; }        //md15112020:  public int id { get; set; }
        protected string name { get; set; }        //mdbt public string name { get; set; }
        protected string picture { get; set; }      //mdbt public string picture { get; set; }
    }

    public class Experience
    {
        public string id { get; set; }
        public string category { get; set; }
        public string name { get; set; }
        public List<Organization> organizations { get; set; }
        public List<object> responsibilities { get; set; }
        public string fromMonth { get; set; }
        public string fromYear { get; set; }
        public string toMonth { get; set; }
        public string toYear { get; set; }
        public bool remote { get; set; }
        public string additionalInfo { get; set; }
        public bool highlighted { get; set; }
        public int weight { get; set; }
        public int verifications { get; set; }
        public int recommendations { get; set; }
        public List<object> media { get; set; }
        public int rank { get; set; }
    }

    public class Organization2
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Job
    {
        public string id { get; set; }
        public string category { get; set; }
        public string name { get; set; }
        public List<Organization2> organizations { get; set; }
        public List<object> responsibilities { get; set; }
        public string fromMonth { get; set; }
        public string fromYear { get; set; }
        public string toMonth { get; set; }
        public string toYear { get; set; }
        public bool remote { get; set; }
        public string additionalInfo { get; set; }
        public bool highlighted { get; set; }
        public int weight { get; set; }
        public int verifications { get; set; }
        public int recommendations { get; set; }
        public List<object> media { get; set; }
        public int rank { get; set; }
    }

    public class Project
    {
        public string id { get; set; }
        public string category { get; set; }
        public string name { get; set; }
        public List<object> organizations { get; set; }
        public List<object> responsibilities { get; set; }
        public string fromMonth { get; set; }
        public string fromYear { get; set; }
        public string toMonth { get; set; }
        public string toYear { get; set; }
        public bool highlighted { get; set; }
        public int weight { get; set; }
        public int verifications { get; set; }
        public int recommendations { get; set; }
        public List<object> media { get; set; }
        public int rank { get; set; }
    }

    public class Organization3
    {
        public int id { get; set; }
        public string name { get; set; }
        public string picture { get; set; }
    }

    public class Education
    {
        public string id { get; set; }
        public string category { get; set; }
        public string name { get; set; }
        public List<Organization3> organizations { get; set; }
        public List<object> responsibilities { get; set; }
        public string fromMonth { get; set; }
        public string fromYear { get; set; }
        public bool remote { get; set; }
        public string additionalInfo { get; set; }
        public bool highlighted { get; set; }
        public int weight { get; set; }
        public int verifications { get; set; }
        public int recommendations { get; set; }
        public List<object> media { get; set; }
        public int rank { get; set; }
        public string toMonth { get; set; }
        public string toYear { get; set; }
    }

    public class Opportunity
    {
        public string id { get; set; }
        public string interest { get; set; }
        public string field { get; set; }
        public object data { get; set; }
    }

    public class Language
    {
        public string code { get; set; }
        public string language { get; set; }
        public string fluency { get; set; }
    }

    public class Group
    {
        public string id { get; set; }
        public int order { get; set; }
        public double median { get; set; }
        public double stddev { get; set; }
    }

    public class Analysis
    {
        public string groupId { get; set; }
        public double analysis { get; set; }
    }

    public class PersonalityTraitsResults
    {
        public List<Group> groups { get; set; }
        public List<Analysis> analyses { get; set; }
    }

    public class Group2
    {
        public string id { get; set; }
        public string text { get; set; }
        public string answer { get; set; }
        public int order { get; set; }
    }

    public class Analysis2
    {
        public string groupId { get; set; }
        public string section { get; set; }
        public double analysis { get; set; }
    }

    public class ProfessionalCultureGenomeResults
    {
        public List<Group2> groups { get; set; }
        public List<Analysis2> analyses { get; set; }
    }

    public class User
    {
        public Person person { get; set; }
        public Stats stats { get; set; }
        public List<Strength> strengths { get; set; }
        public List<Interest> interests { get; set; }
        public List<Experience> experiences { get; set; }
        public List<object> awards { get; set; }
        public List<Job> jobs { get; set; }
        public List<Project> projects { get; set; }
        public List<object> publications { get; set; }
        public List<Education> education { get; set; }
        public List<Opportunity> opportunities { get; set; }
        public List<Language> languages { get; set; }
        

        public PersonalityTraitsResults personalityTraitsResults { get; set; }
        public ProfessionalCultureGenomeResults professionalCultureGenomeResults { get; set; }
    }


}
