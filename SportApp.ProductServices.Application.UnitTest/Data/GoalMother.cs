namespace SportApp.ProductServices.Application.UnitTest.Data ;
using ProductsServices.Domain.Goals;

    public static class GoalMother
    {
        public static Goal Create(string id = "7300e12e-f3df-4a8b-9847-45f07362cee9",
            string name = "New Goal Name",
            string user = "6ad77258-01bf-4d2b-b8ee-37e2099e0216")
        {
            return Goal.Build(Guid.Parse(id), name, Guid.Parse(user));
        }
    }
