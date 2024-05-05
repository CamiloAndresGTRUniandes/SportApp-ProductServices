namespace SportApp.ProductsServices.Domain.Training ;
using Activities;
using Common;
using Goals;
using ValueObjects;

    public class TrainingPlan : BaseDomainModel
    {
        private readonly List<TrainingPlanActivities> _trainingPlanActivities = new();
        private readonly List<TrainingPlanGoals> _trainingPlanGoals = new();
        private readonly List<TrainingPlanUserTrainingPlans> _trainingPlanUserTrainingPlans = new();
        private readonly List<Training> _trainings = new();

        protected TrainingPlan()
        {
        }

        private TrainingPlan(
            Guid id,
            Age startAge,
            Age endAge,
            Guid user)
        {
            Id = id;
            StartAge = startAge;
            EndAge = endAge;
            CreatedBy = user;
            UpdatedBy = user;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            Enabled = true;
        }

        public Age StartAge { get; set; }
        public Age EndAge { get; set; }
        public IReadOnlyCollection<TrainingPlanActivities> TrainingPlanActivities => _trainingPlanActivities;
        public IReadOnlyCollection<TrainingPlanGoals> TrainingPlanGoals => _trainingPlanGoals;
        public IReadOnlyCollection<TrainingPlanUserTrainingPlans> TrainingPlanUserTrainingPlans => _trainingPlanUserTrainingPlans;
        public IReadOnlyCollection<Training> Training => _trainings;

        public static TrainingPlan Build(
            Guid id,
            Age startAge,
            Age endAge,
            Guid user)
        {
            var trainingPlan = new TrainingPlan(id, startAge, endAge, user);
            trainingPlan.SetAdded();
            return trainingPlan;
        }

        private void AddTraining(Training training)
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

        public void AddTrainings(ICollection<Training> trainings)
        {
            foreach (var training in trainings)
            {
                AddTraining(training);
            }
        }
    }
