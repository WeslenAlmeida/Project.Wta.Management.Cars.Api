using Project.Wta.Management.Cars.CrossCutting.Configuration.AppModels;

namespace Project.Wta.Management.Cars.CrossCutting.Configuration
{
    public static class AppSettings
    {
        public static MongoSettings MongoSettings { get{ return new MongoSettings(); } }
    }
}