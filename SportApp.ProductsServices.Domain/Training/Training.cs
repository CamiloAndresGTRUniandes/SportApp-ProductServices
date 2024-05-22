namespace SportApp.ProductsServices.Domain.Training ;
using Common;
using Common.ValueObjects;
using ProductService.ValueObjects;

    public class Training : BaseDomainModel
    {
        private readonly List<Exercise> _exercises = new();

        protected Training()
        {
        }

        private Training(
            Guid id,
            Name name,
            Description description,
            Guid user)
        {
            Id = id;
            Name = name;
            Description = description;
            CreatedBy = user;
            UpdatedBy = user;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            Enabled = true;
        }

        public Name Name { get; set; }
        public Description Description { get; set; }
        public IReadOnlyCollection<Exercise> Exercise => _exercises;

        public static Training Build(Guid id,
            Name name,
            Description description,
            Guid user)
        {
            var training = new Training(id, name, description, user);
            training.SetAdded();
            return training;
        }

        private void AddExercise(Exercise exercise)
        {
            if (exercise is null)
            {
                return;
            }
            var currentExercise = _exercises.FirstOrDefault(e => e.Id == exercise.Id);
            if (currentExercise is null)
            {
                _exercises.Add(exercise);
            }
            SetModifiedIfNotAdded();
        }

        public void AddExercises(ICollection<Exercise> exercises)
        {
            foreach (var exercise in exercises)
            {
                AddExercise(exercise);
            }
        }
    }
