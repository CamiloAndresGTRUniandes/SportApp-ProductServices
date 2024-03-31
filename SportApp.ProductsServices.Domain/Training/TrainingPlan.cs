namespace SportApp.ProductsServices.Domain.Training ;
using Activities;
using Common;
using Common.ValueObjects;
using Enums;
using Goals;
using ProductService.ValueObjects;
using ValueObjects;

    public class TrainingPlan : BaseDomainModel
    {
        private readonly List<TrainingPlanActivities> _trainingPlanActivities = new();
        private readonly List<TrainingPlanGoals> _trainingPlanGoals = new();
        private readonly List<Training> _trainings = new();

        protected TrainingPlan()
        {
        }

        private TrainingPlan(
            Guid id,
            Name name,
            Description description,
            Age startAge,
            Age endAge,
            SportLevel sportLevel,
            Guid user)
        {
            Id = id;
            Name = name;
            Description = description;
            StartAge = startAge;
            EndAge = endAge;
            SportLevel = sportLevel;
            CreatedBy = user;
            UpdatedBy = user;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            Enabled = true;
        }

        public Name Name { get; set; }
        public Description Description { get; set; }
        public Age StartAge { get; set; }
        public Age EndAge { get; set; }
        public SportLevel SportLevel { get; set; }
        public IReadOnlyCollection<TrainingPlanActivities> TrainingPlanActivities => _trainingPlanActivities;
        public IReadOnlyCollection<TrainingPlanGoals> TrainingPlanGoals => _trainingPlanGoals;
        public IReadOnlyCollection<Training> Training => _trainings;

        public static TrainingPlan Build(
            Guid id,
            Name name,
            Description description,
            Age startAge,
            Age endAge,
            SportLevel sportLevel,
            Guid user)
        {
            var trainingPlan = new TrainingPlan(id, name, description, startAge, endAge, sportLevel, user);
            trainingPlan.SetAdded();
            return trainingPlan;
        }

        internal void AddTraining(Training training)
        {
            if (training is null)
            {
                return;
            }
            var currentTraining = _trainings.FirstOrDefault(e => e.Id == training.Id);
            if (currentTraining is null)
            {
                _trainings.Add(training);
            }
            SetModifiedIfNotAdded();
        }
    }
