using System.Linq;
using hm_4.Models;

namespace hm_4
{
    public static class SampleData
    {
        public static void Initialize(MenuContext context)
        {
            if (!context.AdminList.Any())
            {
                context.AdminList.AddRange(
                new Admin
                {
                    FirstName = "ктота",
                    SecondName = "какойта",
                    Age = 666,
                    City = "гдета"
                },
                new Admin
                {
                    FirstName = "чел",
                    SecondName = "челочич",
                    Age = 444,
                    City = "человековск"
                },
                new Admin
                {
                    FirstName = "Митяй",
                    SecondName = "Минин",
                    Age = 18,
                    City = "ВДК"
                }
                );
                context.SaveChanges();
            }

            if (!context.ModeratorList.Any())
            {
                context.ModeratorList.AddRange(
                new Moderator
                {
                    FirstName = "Модер",
                    SecondName = "Модерович",
                    Age = 1,
                    Experience = 1000
                },
                new Moderator
                {
                    FirstName = "Каратель228",
                    SecondName = "ТвоюМа",
                    Age = 10,
                    Experience = 10
                }
                );

            context.SaveChanges();
            }
        }
    }
}