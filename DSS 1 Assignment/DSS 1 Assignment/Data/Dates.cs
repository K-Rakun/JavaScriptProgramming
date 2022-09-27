using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DSS_1_Assignment.Data;
using System;
using System.Linq;

namespace DSS_1_Assignment.Models
{
    public static class Dates
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DSS_1_AssignmentContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DSS_1_AssignmentContext>>()))
            {

                if (context.ReleaseDate.Any())
                {
                    return;
                }

                context.ReleaseDate.AddRange(
                    new DSS_1_Assignment.Models.ReleaseDate
                    {
                        Year = 1999
                    },

                    new DSS_1_Assignment.Models.ReleaseDate
                    {
                        Year = 2000
                    },

                    new DSS_1_Assignment.Models.ReleaseDate
                    {
                        Year = 2001
                    },

                    new DSS_1_Assignment.Models.ReleaseDate
                    {
                        Year = 2002
                    },

                    new DSS_1_Assignment.Models.ReleaseDate
                    {
                        Year = 2003
                    },

                    new DSS_1_Assignment.Models.ReleaseDate
                    {
                        Year = 2004
                    },

                    new DSS_1_Assignment.Models.ReleaseDate
                    {
                        Year = 2005
                    },

                    new DSS_1_Assignment.Models.ReleaseDate
                    {
                        Year = 2006
                    },

                    new DSS_1_Assignment.Models.ReleaseDate
                    {
                        Year = 2007
                    },

                    new DSS_1_Assignment.Models.ReleaseDate
                    {
                        Year = 2008
                    },

                    new DSS_1_Assignment.Models.ReleaseDate
                    {
                        Year = 2009
                    },

                    new DSS_1_Assignment.Models.ReleaseDate
                    {
                        Year = 2010
                    },

                    new DSS_1_Assignment.Models.ReleaseDate
                    {
                        Year = 2011
                    },

                    new DSS_1_Assignment.Models.ReleaseDate
                    {
                        Year = 2012
                    },

                    new DSS_1_Assignment.Models.ReleaseDate
                    {
                        Year = 2013
                    },

                    new DSS_1_Assignment.Models.ReleaseDate
                    {
                        Year = 2014
                    },
                    
                    new DSS_1_Assignment.Models.ReleaseDate
                    {
                        Year = 2015
                    },

                    new DSS_1_Assignment.Models.ReleaseDate
                    {
                        Year = 2016
                    },

                    new DSS_1_Assignment.Models.ReleaseDate
                    {
                        Year = 2017
                    },

                    new DSS_1_Assignment.Models.ReleaseDate
                    {
                        Year = 2018
                    },

                    new DSS_1_Assignment.Models.ReleaseDate
                    {
                        Year = 2019
                    },

                    new DSS_1_Assignment.Models.ReleaseDate
                    {
                        Year = 2020
                    },

                    new DSS_1_Assignment.Models.ReleaseDate
                    {
                        Year = 2021
                    },

                    new DSS_1_Assignment.Models.ReleaseDate
                    {
                        Year = 2022
                    }
                );
                context.SaveChanges();
            }
        }
    }
}