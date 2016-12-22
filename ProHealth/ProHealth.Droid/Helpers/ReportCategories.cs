using System.Collections.Generic;
using System.Linq;

namespace ProHealth.Droid.Helpers
{
    public class ReportCategories
    {
        private int iconID;

        public int IconId
        {
            get { return iconID; }
            set { iconID = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

    }
    public class CategoriesOfReports
    {
        private static List<ReportCategories> AddCategories;
        public List<ReportCategories> Categories;
        public int NumOfCategories
        {
            get { return Categories != null ? Categories.Count : 0; }
        }
        public List<ReportCategories> MyReports
        {
            get { return MyReportsCategories.ToList<ReportCategories>(); }
        }

        public static ReportCategories[] MyReportsCategories =
        {
            new ReportCategories {IconId=Resource.Drawable.heart,Count=00,Name="Dinesh" },
            new ReportCategories {IconId=Resource.Drawable.heart,Count=01,Name="Rahul" },
            new ReportCategories {IconId=Resource.Drawable.heart,Count=05,Name="veswanth" },
            new ReportCategories {IconId=Resource.Drawable.heart,Count=03,Name="kiran" },
            new ReportCategories {IconId=Resource.Drawable.heart,Count=07,Name="siva" },
            new ReportCategories {IconId=Resource.Drawable.heart,Count=09,Name="Reddy" }
        };
        public CategoriesOfReports()
        {
            var categories = new List<ReportCategories>();
            categories.AddRange(MyReportsCategories);
            Categories = categories;
        }
        public ReportCategories this[int i]
        {
            get { return Categories[i]; }
        }
    }
}