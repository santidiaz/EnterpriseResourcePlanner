﻿using DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreEntities.Entities;

namespace DataAccess.Implementations
{
    public class ActivityPersistance : IActivityPersistance
    {
        public void AddActivity(Activity newActivity)
        {
            using (Context context = new Context())
            {
                context.activities.Add(newActivity);
                context.SaveChanges();
            }
        }

        public void DeleteActivity(Activity activityToDelete)
        {
            using (Context context = new Context())
            {
                context.activities.Attach(activityToDelete);
                context.activities.Remove(activityToDelete);
                context.SaveChanges();
            }
        }

        public List<Activity> GetActivities()
        {
            throw new NotImplementedException();
        }

        public Activity GetActivityById(int id)
        {
            throw new NotImplementedException();
        }

        public void ModifyActivity(Activity activityToModify)
        {
            throw new NotImplementedException();
        }
    }
}
