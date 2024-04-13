namespace SportApp.ProductsServices.Domain.Training ;
using Common;
using Common.ValueObjects;
using ProductService.ValueObjects;
using ValueObjects;

    public class Exercise : BaseDomainModel
    {
        protected Exercise()
        {
        }

        private Exercise(
            Guid id,
            Name name,
            Description description,
            Set sets,
            Repeat repeats,
            Weight weight,
            Uri picture,
            Guid user)
        {
            Id = id;
            Name = name;
            Description = description;
            Sets = sets;
            Repeats = repeats;
            Weight = weight;
            Picture = picture;
            CreatedBy = user;
            UpdatedBy = user;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            Enabled = true;
        }

        public Name Name { get; set; }
        public Description Description { get; set; }
        public Set Sets { get; set; }
        public Repeat Repeats { get; set; }
        public Weight Weight { get; set; }
        public Uri Picture { get; set; }

        public static Exercise Build(
            Guid id,
            Name name,
            Description description,
            Set sets,
            Repeat repeats,
            Weight weight,
            Uri picture,
            Guid user)
        {
            var exercise = new Exercise(id, name, description, sets, repeats, weight, picture, user);
            exercise.SetAdded();
            return exercise;
        }
    }
