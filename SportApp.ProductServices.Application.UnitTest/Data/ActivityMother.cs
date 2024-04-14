namespace SportApp.ProductServices.Application.UnitTest.Data ;
using ProductsServices.Domain.Activities;

    public static class ActivityMother
    {
        public static Activity Create(string id = "7300e12e-f3df-4a8b-9847-45f07362cee9",
            string name = "New Activity Name",
            string user = "6ad77258-01bf-4d2b-b8ee-37e2099e0216")
        {
            return Activity.Build(Guid.Parse(id), name, Guid.Parse(user));
        }
    }
