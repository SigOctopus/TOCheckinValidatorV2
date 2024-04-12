// See https://aka.ms/new-console-template for more information
//Data Source=10.0.115.10; Initial Catalog=tourdb; User Id=instantuser; Password=inde2019; TrustServerCertificate=true;

using ConsoleApp1;
using ConsoleApp1.Context;
using ConsoleApp1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Quartz;

Console.WriteLine("Hello, World!");

var builder = Host.CreateDefaultBuilder()
    .ConfigureServices((ctx, services) =>
    {
        services.AddQuartz(q =>
        {
            // inizializzo la chiave identificativa del quest renewer
            q.UseMicrosoftDependencyInjectionJobFactory();
            var checkinValidatorKey = new JobKey("checkin-validator");
            q.AddJob<CheckinValidator>(opts => opts.WithIdentity(checkinValidatorKey));

            // inizializzo il trigger per il quest renewer
            q.AddTrigger(opts => opts
                .ForJob(checkinValidatorKey)
                .WithIdentity("checkin-validator-trigger")
                .WithCronSchedule("0 * * * * ?"));
        });
        services.AddQuartzHostedService(opt =>
        {
            opt.WaitForJobsToComplete = true;
        });
    }).Build();

builder.Run();

Console.WriteLine("end");

