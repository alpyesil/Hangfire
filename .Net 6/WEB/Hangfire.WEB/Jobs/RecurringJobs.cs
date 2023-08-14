namespace Hangfire.WEB.Jobs;

public static class RecurringJobs
{
    public static void Run()
    {
        #region Fire in 2 minutes

        RecurringJob.RemoveIfExists(nameof(HelloHangfireWEB));
        RecurringJob.AddOrUpdate<HelloHangfireWEB>(nameof(HelloHangfireWEB),
            job => job.Execute(), "*/2 * * * *", TimeZoneInfo.Local);

        #endregion

        #region Fire in 5 minutes

        RecurringJob.RemoveIfExists(nameof(HelloHangfireWEB));
        RecurringJob.AddOrUpdate<HelloHangfireWEB>(nameof(HelloHangfireWEB),
            job => job.Execute(), "*/5 * * * *", TimeZoneInfo.Local);

        #endregion

        #region Fire in 45 minutes

        RecurringJob.RemoveIfExists(nameof(HelloHangfireWEB));
        RecurringJob.AddOrUpdate<HelloHangfireWEB>(nameof(HelloHangfireWEB),
            job => job.Execute(), "*/45 * * * *", TimeZoneInfo.Local);

        #endregion
    }
}